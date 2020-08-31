using System;
using System.Collections.Generic;
using SQLite.Net.Attributes;

namespace FinApp.Models
{
    public class Misc
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
