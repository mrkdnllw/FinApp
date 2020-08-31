using FinApp.Models;
using System.Collections.Generic;

namespace FinApp
{
    public class AddTransactionPageViewModel : ViewModelBase
    {
        public IList<TransactionType> TransactionTypes { get { return TransactionTypeData.TransactionTypes; } }

        TransactionType selectedTransactionType;
        public TransactionType SelectedTransactionType
        {
            get { return selectedTransactionType; }
            set
            {
                if (selectedTransactionType != value)
                {
                    selectedTransactionType = value;
                    OnPropertyChanged();
                }
            }
        }
    }
}
