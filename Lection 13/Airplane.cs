using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ConsoleApp1
{
    [Serializable]
    [DataContract]
    public class Airplane
    {
        [DataMember]
        public string VendorName { get; set; }
        [DataMember]
        public string Model { get; set; }

        public int FlightHours { get; set; }
        [DataMember]
        public int Capacity { get; set; }
        public Airplane() { }
        public override string ToString()
        {
            return $"Фирма производитель -- {VendorName}  Модель -- {Model}  Часы налёта -- {FlightHours}  Пассажировместимость {Capacity}";
        }
    }
}
