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
        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        // Adds a new User to DB
        public Task<int> SaveUserAsync(User user)
        {
            return _database.InsertAsync(user);
        }

        // Returns a Specific User
        public Task<User> GetUserAsync(string name)
        {
            return _database.Table<User>().Where(User => User.Username == name).FirstOrDefaultAsync();
        }

        // Returns a Specific User if the provided username and password match or NULL if not
        public Task<User> LoginUser(string username, string password)
        {
            return _database.Table<User>().Where(User => User.Username == username).Where(User => User.Password == password).FirstOrDefaultAsync();
        }

    }
}
