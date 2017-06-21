using System;
using System.Collections.Generic;

namespace nd
{
    public class DatabaseObjectsModel
    {
        public List<Tuple<string, int, string>> Objects {get;set;}

        public DatabaseObjectsModel(string zpass) {
            Objects = new List<Tuple<string, int, string>>() {
                new Tuple<string, int, string>("Codeunit", 1, "Application Management"),
                new Tuple<string, int, string>("Table", 3, "Payment Terms"),
                new Tuple<string, int, string>("xxx", 9999, zpass),
            };
        }
    }
}