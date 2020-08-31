using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinApp.Models
{
    public class Transaction
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Amount { get; set; }
        public string Description { get; set; }

        public DateTime Date { get; set; }
    }
}
