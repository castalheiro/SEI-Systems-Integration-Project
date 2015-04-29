using System;
using System.IO;
using System.Messaging;
namespace RequestApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Waiting for message...");
                
                string queueName = @".\private$\shipping_input_queue";
                MessageQueue mq = new MessageQueue(queueName);
                Message msg = mq.Receive();
               
                Console.WriteLine("Message has been received!");
                StreamReader reader = new StreamReader(msg.BodyStream);
                string request = reader.ReadToEnd();
                Console.WriteLine(request);
                
                Console.Write("Approve? (Yes/No) ");
                string approved = Console.ReadLine();
                string response = "<ns0:Request xmlns:ns0=\"http://Supplier.ShippingNotice\">\n";
                string[] lines = request.Split('\n');
                response += lines[1] + '\n';
                response += lines[2] + '\n';
                response += " <DeliveryDate>" + DateTime.Now.ToString() + "</DeliveryDate>\n";
                response += "</ns0:Request>";
                Console.WriteLine(response);
               
                queueName = @".\private$\shipping_output_queue";
                mq = new MessageQueue(queueName);
                msg = new Message();
                StreamWriter writer = new StreamWriter(msg.BodyStream);
                writer.Write(response);
                writer.Flush();
                mq.Send(msg);
                Console.WriteLine("Message has been sent!");
            }
        }
    }
}