using System;
using Microsoft.Data.Sqlite;

namespace lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            SqliteConnection con = new SqliteConnection("Filename = MyDB.db");
            con.Open();

            // string name;
            // int age;
            // System.Console.WriteLine("Your name ");
            // name = Console.ReadLine();
            // System.Console.WriteLine("You age");
            // Int32.TryParse(Console.ReadLine(),out age);


            // string insertIntoTableQuery = "insert into MyTable(name,age) values(@name,@age)";
            // SqliteCommand insertIntoTable = new SqliteCommand(insertIntoTableQuery,con);

            // insertIntoTable.Parameters.Add(new SqliteParameter("@name", name));
            // insertIntoTable.Parameters.Add(new SqliteParameter("@age",age));
            // insertIntoTable.ExecuteNonQuery();





            // string createTableQuery = "create table if not exists MyTable(id integer primary key autoincrement,"+
            //     "name nvarchar(100) not null,age integer null)";
            // SqliteCommand createTable = new SqliteCommand(createTableQuery,con);
            // createTable.ExecuteNonQuery();

            // string insertIntoTableQuery = "insert into MyTable (name,age) values ('Dima',25)";
            // SqliteCommand insertIntoTable = new SqliteCommand(insertIntoTableQuery,con);
            // insertIntoTable.ExecuteNonQuery();

            // string selectFromTableQuery = "select * from MyTable";
            // SqliteCommand selectFromTable = new SqliteCommand(selectFromTableQuery,con);
            // SqliteDataReader reader =  selectFromTable.ExecuteReader();
            // while(reader.Read())
            // {
            //     System.Console.WriteLine($"id = {reader.GetInt32(0)}, name = {reader.GetString(1)}, age = {reader.GetInt32(2)}");
            // }

            // string updateTableQuery = "update MyTable set name = 'Dmitriy' where id = 1";
            // SqliteCommand updateTable = new SqliteCommand(updateTableQuery,con);
            // updateTable.ExecuteNonQuery();

            // selectFromTable.
            string deleteFromTableQuery = "delete from MyTable where age = null";
            SqliteCommand deleteFromTable = new SqliteCommand(deleteFromTableQuery,con);
            // deleteFromTable.ExecuteNonQuery();
            con.Close();
            
            // Sqli
            // SqliteConnection db =
            //     new SqliteConnection("Filename=sqliteSample.db");
            // db.Open();

            // string tableCommand = "CREATE TABLE IF NOT " +
            //     "EXISTS MyTable (Primary_Key INTEGER PRIMARY KEY AUTOINCREMENT, " +
            //     "Text_Entry NVARCHAR(2048) NULL)";

            // SqliteCommand createTable = new SqliteCommand(tableCommand, db);

            // // createTable.ExecuteReader();
            // createTable.ExecuteNonQuery();

            // tableCommand = "insert into MyTable (Text_Entry)" +
            //     "values('H')";
            // createTable = new SqliteCommand(tableCommand,db);
            // createTable.ExecuteNonQuery();

            // tableCommand = "select * from MyTable";
            // createTable = new SqliteCommand(tableCommand,db);

            // SqliteDataReader reader = createTable.ExecuteReader(); 
            // while(reader.Read())
            // {
            //     Console.WriteLine(reader.GetInt16(0));
            //     Console.WriteLine(reader.GetString(1));
            // }
            // Console.WriteLine("Hello World!");
            // db.Close();
        }
    }
}
