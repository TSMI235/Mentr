using System.Collections.Generic;
using System.Threading.Tasks;
using SQLite;

namespace Mentr
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        // Opens Database and Creates tables if they aren't there
        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath); // Open DB
            _database.CreateTableAsync<User>().Wait(); // Creates tables if the database is new
            _database.CreateTableAsync<Mentor>().Wait();
            _database.CreateTableAsync<Match>().Wait();
            _database.CreateTableAsync<TextMessage>().Wait();
        }

        //--------------------//
        // Database Functions //
        //--------------------//

        // Returns a list of ALL users
        public Task<List<User>> GetUserAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        // Adds a new User to DB
        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }
    }
}
