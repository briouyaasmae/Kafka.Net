using Confluent.Kafka;
using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka.Serialization;

namespace TimeManagement.Streaming.Consumer
{
    public class BookingConsumer : IBookingConsumer
    {
        public void Listen(Action<string> message)
        {
            var config = new Dictionary<string, object>
        {
            {"group.id","console-consumer-24339" },
            {"bootstrap.servers", "localhost:9092" },
            {"enable.auto.commit", "false" },
           
        };

            using (var consumer = new Consumer<Null, string>(config, null, new StringDeserializer(Encoding.UTF8)))
            {
                consumer.Subscribe("timeistime");
                consumer.OnMessage += (_, msg) =>
                {
                    message(msg.Value);
                };

                while (true)
                {
                    consumer.Poll(100);
                }
            }
        }
    }
}
