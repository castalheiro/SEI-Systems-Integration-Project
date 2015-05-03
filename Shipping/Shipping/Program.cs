using System;
using System.IO;
using System.Messaging;
using System.Xml;
using System.Xml.Linq;
namespace Shipping
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Waiting for message...");
                
                string queueName = @".\private$\shipping_input_queue";
                /*if (!MessageQueue.Exists(queueName)) {
                    Console.WriteLine("The queue does not exist");
                    return;
                }*/
                MessageQueue mq = new MessageQueue(queueName);
                Message msg = mq.Receive();
               
                Console.WriteLine("Message has been received!");
                StreamReader reader = new StreamReader(msg.BodyStream);
                string request = reader.ReadToEnd();
                Console.WriteLine(request);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(request);
                XmlElement root = doc.DocumentElement;
                XmlNode purchaseNumber = root.SelectSingleNode("//PurchaseNumber");
                XmlNode deliveryAddress = root.SelectSingleNode("//DeliveryAddress");
                
                /* ns0:ShippingNotice aqui e' o nome do no raiz do schema Supplier.ShippingNotice */
                string response = "<ns0:ShippingNotice xmlns:ns0=\"http://Supplier.ShippingNotice\">" + '\n';
                string[] lines = request.Split('\n');
                response += purchaseNumber.OuterXml + '\n';
                response += deliveryAddress.OuterXml + '\n';
                response += " <DeliveryDate>" + DateTime.Now.ToString() + "</DeliveryDate>\n";
                response += "</ns0:ShippingNotice>";
                //Console.WriteLine("response: ");
                //Console.WriteLine(response);
               
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