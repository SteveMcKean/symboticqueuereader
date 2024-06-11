// See https://aka.ms/new-console-template for more information

using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using SymboticQueueReader;

var factory = new ConnectionFactory() 
    {
        HostName = "192.168.0.90", // Just the host IP or name
        Port = 5672, // Default port for RabbitMQ; adjust if different
        UserName = "symbotic", // Username for authentication
        Password = "setup1234", // Password for authentication
        
    };

using var connection = await factory.CreateConnectionAsync();
using var channel = await connection.CreateChannelAsync();

// Declare the exchange
var exchangeName = "Symbotic.ItemMaster";
await channel.ExchangeDeclareAsync(exchange: exchangeName, type: "topic", durable:true);

// Declare and bind the queue with a wildcard routing key
var queueName = "SymboticItemMasterQueue";
await channel.QueueDeclareAsync(queue: queueName, durable: true, exclusive: false, autoDelete: false, arguments: null);
var routingKey = "Symbotic.ItemMaster.Command.#";
await channel.QueueBindAsync(queue: queueName, exchange: exchangeName, routingKey: routingKey);

// Set up a consumer to consume messages from the queue
var consumer = new EventingBasicConsumer(channel);
consumer.Received += async (model, ea) =>
    {
        var body = ea.Body.ToArray();
        var message = Encoding.UTF8.GetString(body);
        Console.WriteLine("Received: {0}", message);
        // Acknowledge the message as processed
        await channel.BasicAckAsync(deliveryTag: ea.DeliveryTag, multiple: false);
        
        var item = JsonConvert.DeserializeObject<Item>(message);
        // Process the message and prepare a response
        var teachInResponse = new SkuTeachInCompleted(item.RequestId, item.Sku, SkuTeachInCompletedResultEnum.Success, "Operation completed successfully");
        
        // Serialize the response to JSON
        var responseMessage = JsonConvert.SerializeObject(teachInResponse);
        var responseBytes = Encoding.UTF8.GetBytes(responseMessage);

        // Publish the response
        var responseExchange = "Symbotic.ItemMaster"; // Set the exchange name if needed
        var responseRoutingKey = "Symbotic.ItemMaster.Event.Sku.TeachInCompleted"; // Set the routing key
       
        // Serialize the response to JSON
        // Asynchronously publish the response
        await channel.BasicPublishAsync(
            exchange: responseExchange,
            routingKey: responseRoutingKey,
            mandatory: false,
            basicProperties: new BasicProperties{Persistent = true},
            body: new ReadOnlyMemory<byte>(responseBytes)
        );

        Console.WriteLine("Response sent");
        // Acknowledge the original message
      
    };

await channel.BasicConsumeAsync(queue: queueName, autoAck: false, consumer: consumer);

Console.WriteLine("Press [enter] to exit.");
Console.ReadLine();