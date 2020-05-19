using System;
using System.Collections.Generic;
using System.Text;

namespace TimeManagement.Streaming.Producer
{
    interface IBookingProducer
    {
        void Produce(string message);
    }
}
