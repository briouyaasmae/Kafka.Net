using System;

namespace TimeManagement.Streaming.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("let's talk please write something and if you want to leave please tap x .(to be honest we don't want you to leave)");
            var message = default(string);
            while ((message = Console.ReadLine()) != "x")
            {
                var producer = new BookingProducer();
                producer.Produce(message);
            }
        }
    }
}
