using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;

namespace Braille.MainDataBase;

public class BrailleDB
{
    private const string connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\GitFilesInF\Braille\Braille\BrailleDatabase.mdf;Integrated Security=True";
    public string ConnectionString { get; set; }

    SqlConnection connection;
    SqlConnectionStringBuilder connectionStringBuilder;

    public BrailleDB(string connectionString)
    {
        this.ConnectionString = connectionString != connect ? connect : connectionString;
    }

    public BrailleDB()
    {
        this.ConnectionString = "Not Connect";
    }

    private void Insert(string symbol, string dots)
    {
        try
        {
            string sql = @"insert into Braille values('" + symbol + "', " + dots + ")";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            Debug.WriteLine($"Values added to Db {symbol} {dots}");
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            File.WriteAllText("InsertExceptionLog.json", e.Message);
        }
    }

    private void CreateTable()
    {
        string create = @"CREATE TABLE [dbo].[Braille]
                        (
                            [Id] INT IDENTITY (1, 1) PRIMARY KEY NOT NULL,
                            [Symbol] NVARCHAR (60) NOT NULL,
                            [Dots]   NVARCHAR (6)  NOT NULL
                        );";

        SqlCommand command = new SqlCommand(create, connection);
        command.ExecuteNonQuery();
        Debug.WriteLine("New Table is Created");
    }

    private void CheckAvailabilityTable()
    {
        string check = @"select s.id from sysobjects s WHERE xtype='U' AND name='Braille'";
        SqlCommand sqlCommand = new SqlCommand(check, connection);
        object id = sqlCommand.ExecuteScalar();
        if (id == null) CreateTable();
    }

    public void AddToDB(string symbol, string dots)
    {
        try
        {
            using (connection = new SqlConnection(GetConnectionStringBuilder().ConnectionString))
            {
                connection.Open();
                CheckAvailabilityTable();
                Insert(symbol, dots);
            }
        }
        catch (Exception e)
        {
            Debug.WriteLine(e.Message);
            File.WriteAllText("ExceptionFileLog.json", e.Message);
        }
        finally
        {
            connection.Close();
        }
    }

    private SqlConnectionStringBuilder GetConnectionStringBuilder()
    {
        if (this.ConnectionString == "Not Connect")
        {
            connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = @"(LocalDB)\MSSQLLocalDB",
                AttachDBFilename = @"F:\GitFilesInF\Braille\Braille\BrailleDatabase.mdf",
                IntegratedSecurity = true
            };
        }
        else
        {
            connectionStringBuilder = new SqlConnectionStringBuilder()
            {
                ConnectionString = this.ConnectionString
            };
        }
        return connectionStringBuilder;
    }
}
