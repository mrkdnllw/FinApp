using System;
using System.Collections.Generic;
using System.Text;

namespace FinApp.Models
{
    public static class TransactionTypeData
    {
        public static IList<TransactionType> TransactionTypes { get; private set; }

        static TransactionTypeData()
        {
            TransactionTypes = new List<TransactionType>();
            
            TransactionTypes.Add(new TransactionType
            {
                Name = "Income"
            });

            TransactionTypes.Add(new TransactionType
            {
                Name = "Expense"
            });
        }
    }
}
