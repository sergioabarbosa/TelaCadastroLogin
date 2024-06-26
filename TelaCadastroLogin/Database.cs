using System.Data.SQLite;

public class Database
{
    private SQLiteConnection connection;

    public Database()
    {
        connection = new SQLiteConnection("Data Source=users.db;Version=3;");
        connection.Open();
        string createTableQuery = "CREATE TABLE IF NOT EXISTS users (id INTEGER PRIMARY KEY, username TEXT, password TEXT)";
        SQLiteCommand command = new SQLiteCommand(createTableQuery, connection);
        command.ExecuteNonQuery();
    }

    public void RegisterUser(string username, string password)
    {
        string insertQuery = "INSERT INTO users (username, password) VALUES (@username, @password)";
        SQLiteCommand command = new SQLiteCommand(insertQuery, connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", password);
        command.ExecuteNonQuery();
    }

    public bool LoginUser(string username, string password)
    {
        string selectQuery = "SELECT * FROM users WHERE username = @username AND password = @password";
        SQLiteCommand command = new SQLiteCommand(selectQuery, connection);
        command.Parameters.AddWithValue("@username", username);
        command.Parameters.AddWithValue("@password", password);
        SQLiteDataReader reader = command.ExecuteReader();
        return reader.HasRows;
    }
}
