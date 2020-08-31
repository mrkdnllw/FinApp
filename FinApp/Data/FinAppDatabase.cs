using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;
using FinApp.Models;


namespace FinApp.Data
{
    public class FinAppDatabase
    {
        //ok
        readonly SQLiteAsyncConnection _database;

        public FinAppDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Misc>().Wait();
            _database.CreateTableAsync<Transaction>().Wait();
        }

        #region MISC OPERATIONS
        //get all miscs
        public Task<List<Misc>> GetMiscsAsync()
        {
            return _database.Table<Misc>().ToListAsync();
        }

        //get specific misc
        public Task<Misc> GetMiscAsync(int id)
        {
            return _database.Table<Misc>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        //save one misc
        public Task<int> SaveMiscAsync(Misc misc)
        {
            if (misc.ID != 0)
            {
                return _database.UpdateAsync(misc);
            }
            else
            {
                return _database.InsertAsync(misc);
            }
        }

        //del one misc
        public Task<int> DeleteMiscAsync(Misc misc)
        {
            return _database.DeleteAsync(misc);
        }
        #endregion

        #region TRANSACTIONS OPERATIONS
        //TRANSACTIONS OPERATIONS
        //get all transactions
        public Task<List<Transaction>> GetTransactionsAsync()
        {
            return _database.Table<Transaction>().ToListAsync();
        }


        //get specific transaction
        public Task<Transaction> GetTransactionAsync(int id)
        {
            return _database.Table<Transaction>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        //add transaction
        public Task<int> SaveTransactionAsync(Transaction transaction)
        {
            if (transaction.ID != 0)
            {
                return _database.UpdateAsync(transaction);
            }
            else
            {
                return _database.InsertAsync(transaction);
            }
        }

        //del one transaction
        public Task<int> DeleteTransactionAsync(Transaction transaction)
        {
            return _database.DeleteAsync(transaction);
        }

        #endregion
    }


}// close namespace
