using System;
using System.Diagnostics;
using Oracle.ManagedDataAccess.Client;

// 20.06.2021
// Oracle resists as a Docker Container, but this is another story
// Table Foo in Oracle with only column int id created by hand, filled by hand. Also another Story
// https://www.oracle.com/webfolder/technetwork/tutorials/obe/db/dotnet/ODPNET_Core_get_started/index.html
// Oracle DB Access with DotnetCore - Oracle.ManagedAccess.Client

namespace OracleAdoNet {
    class Program {
        static void Main(string [] args) {
            Stopwatch sw = new Stopwatch ();
            sw.Start ();
            string conString = "User Id=dummy;Password=dummy;Data Source=localhost:1521/ORCLCDB.localdomain";

            using (OracleConnection con= new OracleConnection (conString)) {
                using(OracleCommand command = con.CreateCommand()) {
                    try {
                        con.Open ();
                        command.CommandText = "select id from foo";
                        OracleDataReader reader = command.ExecuteReader ();
                        while (reader.Read ()) {
                            Console.WriteLine ($"id:{reader.GetInt32 (0)}");
                        }

                    }
                    catch (Exception ex) {
                        int i = 0;
                        i++;
                    }
                }
            }
            sw.Stop ();
            Console.WriteLine ($"Das Dauerte: {sw.ElapsedMilliseconds} ms");
        }

    }
}

