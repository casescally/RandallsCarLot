using System;
using System.Collections.Generic;

namespace RandallsCarLot {
    class Program {
        static void Main (string[] args) {

            List<Dictionary<string, Dictionary<string, string>>> Vehicles = new List<Dictionary<string, Dictionary<string, string>>> ();

            Dictionary<string, Dictionary<string, string>> vehicle1 = new Dictionary<string, Dictionary<string, string>> ();

            vehicle1.Add ("vehicle1", new Dictionary<string, string> () { { "year", "2008" }, { "model", "Damfresh" }, { "make", "Biotraxquote" }, { "color", "sky magenta" }
            });

            Dictionary<string, Dictionary<string, string>> sales_agent1 = new Dictionary<string, Dictionary<string, string>> ();

            vehicle1.Add ("sales_agent1", new Dictionary<string, string> () { { "mobile", "(896) 478-6975" }, { "last_name", "Botsford" }, { "first_name", "Shaina" }
            });

            Dictionary<string, Dictionary<string, string>> credit1 = new Dictionary<string, Dictionary<string, string>> ();

            vehicle1.Add ("credit1", new Dictionary<string, string> () { { "credit_provider", "J.P.Morgan Chase & Co" }, { "account", "601109582720302" }
            });
            Dictionary<string, Dictionary<string, string>> vehicle2 = new Dictionary<string, Dictionary<string, string>> ();

            vehicle2.Add ("vehicle2", new Dictionary<string, string> () { { "year", "2010" }, { "model", "Hotquadtrax" }, { "make", "Transtintechno" }, { "color", "robin egg blue" }
            });

            Dictionary<string, Dictionary<string, string>> sales_agent2 = new Dictionary<string, Dictionary<string, string>> ();

            vehicle2.Add ("sales_agent2", new Dictionary<string, string> () { { "mobile", "562.300.2912" }, { "last_name", "Davis" }, { "first_name", "Gerardo" }
            });

            Dictionary<string, Dictionary<string, string>> credit2 = new Dictionary<string, Dictionary<string, string>> ();

            vehicle2.Add ("credit2", new Dictionary<string, string> () { { "credit_provider", "PNC Financial Services" }, { "account", "34578280562836" }
            });

            Vehicles.Add (vehicle1);
            Vehicles.Add (vehicle2);

            foreach (Dictionary<string, Dictionary<string, string>> Vehicle in Vehicles) {
                Console.WriteLine ();
                foreach (KeyValuePair<string, Dictionary<string, string>> vehicle in Vehicle) {
                    Console.WriteLine ();
                    Console.WriteLine ($"{vehicle.Key}");
                    foreach (KeyValuePair<string, string> info in vehicle.Value) {
                        Console.WriteLine ($"{info.Value}");
                    }
                }
            }

        }
    }
}