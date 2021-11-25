using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane[] civilAirplanes = { new Airplane { VendorName = "Airbus", Model = "A-380", FlightHours = 2000, Capacity = 853 },
                                          new Airplane { VendorName = "Boeing" , Model = "Dreamliner" , FlightHours = 4555, Capacity = 330 },
                                          new Airplane { VendorName = "Boeing", Model = "777-300", FlightHours = 11000, Capacity = 550 }

                                        };
            foreach(var airplane in civilAirplanes)
                Console.WriteLine(airplane);

            SoapFormatter civilAirplanesFormatter = new SoapFormatter();

            using (FileStream civilAirplanesFileStream = new FileStream(@"D:\Универ Валера\OOP\Lection13\ConsoleApp1\civilAirplanes.soap", FileMode.Create)) {
                civilAirplanesFormatter.Serialize(civilAirplanesFileStream, civilAirplanes);
                Console.WriteLine("Массив объектов сериализирован");
                Console.WriteLine(Environment.NewLine);
            }

            using (FileStream civilAirplanesFileStream = new FileStream(@"D:\Универ Валера\OOP\Lection13\ConsoleApp1\civilAirplanes.soap", FileMode.Open)) {
                Airplane[] deserializedCivilAirplanes = (Airplane[])civilAirplanesFormatter.Deserialize(civilAirplanesFileStream);
                Console.WriteLine("Десериализированный массив");
                foreach (var airplane in deserializedCivilAirplanes) {
                    Console.WriteLine(airplane);
                }
            }
            Console.WriteLine(Environment.NewLine);

            Airplane[] militaryPlanes = {
                                            new Airplane{VendorName = "Lockheed Martin", Model = "Lockheed F-117 Nighthawk", Capacity = 1},
                                            new Airplane{ VendorName = "Northrop", Model = "B-2 Spirit", Capacity = 2 },
                                            new Airplane{ VendorName = "McDonnell Douglas/Boeing", Model = "F-15E Strike Eagle", Capacity = 1}
                                        };
            foreach(var plane in militaryPlanes)
                Console.WriteLine(plane);

            DataContractJsonSerializer militaryAirplanesJson = new DataContractJsonSerializer(typeof(Airplane[]));
            using (FileStream militaryAirplanesFileStream = new FileStream(@"D:\Универ Валера\OOP\Lection13\ConsoleApp1\militaryAirplanes.json", FileMode.Create)) {
                militaryAirplanesJson.WriteObject(militaryAirplanesFileStream, militaryPlanes);
                Console.WriteLine("Массив сериализирован в формате JSON");
                Console.WriteLine(Environment.NewLine);
            }
            using (FileStream militaryAirplanesFileStream = new FileStream(@"D:\Универ Валера\OOP\Lection13\ConsoleApp1\civilAirplanes.json", FileMode.Open)) {
                Airplane[] deserializedJsonMilitaryAirPlanes = (Airplane[])militaryAirplanesJson.ReadObject(militaryAirplanesFileStream);
                Console.WriteLine("Массив десериализирован в формате JSON");
                foreach(var plane in deserializedJsonMilitaryAirPlanes)
                    Console.WriteLine(plane);
            }
            Console.WriteLine(Environment.NewLine);

            Airplane[] bomberAirplanes = {
                                            new Airplane{ VendorName = "Boeing", Model = "B-29 Superfortress", Capacity = 11},
                                            new Airplane { VendorName = "Boeing", Model = "B-52 Stratofortress", Capacity = 6},
                                            new Airplane { VendorName = "Lockheed", Model = "F-117 Nighthawk", Capacity = 1}

                                         };
            foreach (var plane in bomberAirplanes)
                Console.WriteLine(plane);
            XmlSerializer bomberSerializer = new XmlSerializer(typeof(Airplane[]));
            using (FileStream bombersStream = new FileStream(@"D:\Универ Валера\OOP\Lection13\ConsoleApp1\bombers.xml", FileMode.Create)) {
                bomberSerializer.Serialize(bombersStream, bomberAirplanes);
                Console.WriteLine("Массив сериализирован в XML");
            }
            Console.WriteLine(Environment.NewLine);
            using (FileStream bombersStream = new FileStream(@"D:\Универ Валера\OOP\Lection13\ConsoleApp1\bombers.xml", FileMode.Open)) {
                Airplane[] deserialiazedBombers = (Airplane[])bomberSerializer.Deserialize(bombersStream);
                Console.WriteLine("Десериализированный массив из XML");
                foreach(var plane in deserialiazedBombers)
                    Console.WriteLine(plane);
                
            }

                Console.ReadKey();

        }
    }
}
