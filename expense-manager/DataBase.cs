using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Drawing;
using System.IO;

namespace expense_manager
{
	public class DataBase
	{
		private string dbName;
		private SQLiteConnection sql_con; // database handler
		private SQLiteCommand sql_cmd; // command to execute 
		private string path = @"C:\ProgramData\ExpenseManager\db\";

		public DataBase(string name)
		{
			this.dbName = name;
			ConnectToDB();
			InitDB();
		}

		private void ConnectToDB()
		{
			sql_con = new SQLiteConnection("Data Source="+path+dbName);
		}

		private void ExecuteNonQuery()
		{
			sql_con.Open();
			sql_cmd.ExecuteNonQuery();
			sql_con.Close();
		}

		private void InitDB()
		{
			if (!DBExist())
			{
				 CreateDB();
			}
		}

		private void CreateDB()
		{
			CreatePath();

			string quarryCategory = "CREATE TABLE Category (" +
			                        "id	INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
			                        "name TEXT UNIQUE)";
			string quarryDescription = "CREATE TABLE Description (" +
			                           "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE," +
			                           "text TEXT)";
			string quarryProfile = "CREATE TABLE Profile (" +
			                       "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
			                       "name TEXT NOT NULL UNIQUE)";
			string quarryExpense = "CREATE TABLE Expense (" +
			                       "id INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT UNIQUE, " +
			                       "amount REAL," +
			                       "category_id	INTEGER, " +
			                       "description_id INTEGER," +
								   "day INTEGER, " +
			                       "month INTEGER, " +
			                       "year INTEGER," +
			                       "profile_id INTEGER)";

			SQLiteConnection.CreateFile(path+dbName);

			sql_cmd = new SQLiteCommand(quarryCategory, sql_con);
			ExecuteNonQuery();
			sql_cmd = new SQLiteCommand(quarryDescription, sql_con);
			ExecuteNonQuery();
			sql_cmd = new SQLiteCommand(quarryProfile, sql_con);
			ExecuteNonQuery();
			sql_cmd = new SQLiteCommand(quarryExpense, sql_con);
			ExecuteNonQuery();
		}

		private void CreatePath()
		{
			if (!System.IO.Directory.Exists(path))
				System.IO.Directory.CreateDirectory(path);
		}

		private bool DBExist()
		{
			return File.Exists(path + dbName);
		}

		public void AddExpense(Expense ex1)
		{
			int category_id;
			int description_id;
			int profile_id;

			string quarry = "INSERT OR IGNORE INTO Category (`name`) VALUES (@name)";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@name", ex1.Category);
			ExecuteNonQuery();

			quarry = "SELECT id FROM Category WHERE name = @name";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@name", ex1.Category);
			SQLiteDataReader result = sql_cmd.ExecuteReader();
			result.Read();
			category_id = Convert.ToInt32(result[0]);
			result.Close();
			sql_con.Close();

			quarry = "INSERT INTO Description (`text`) VALUES (@text)";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@text", ex1.Description);
			ExecuteNonQuery();

			quarry = "SELECT id FROM Description WHERE (`text`) = @text";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@text", ex1.Description);
			result = sql_cmd.ExecuteReader();
			result.Read();
			description_id =Convert.ToInt32(result[0]);
			result.Close();
			sql_con.Close();

			quarry = "SELECT id FROM Profile WHERE (`name`) = @name";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@name", ex1.Profile);
			result = sql_cmd.ExecuteReader();
			result.Read();
			profile_id = Convert.ToInt32(result[0]);
			result.Close();
			sql_con.Close();

			quarry = "INSERT INTO expense (`amount`, `category_id`, `description_id`, `day`, `month`, `year`, `profile_id`) " +
					 "VALUES (@amount, @category_id, @description_id, @day, @month, @year, @profile_id)";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@amount", ex1.Ammount);
			sql_cmd.Parameters.AddWithValue("@category_id", category_id);
			sql_cmd.Parameters.AddWithValue("@description_id", description_id);
			sql_cmd.Parameters.AddWithValue("@day", ex1.Day);
			sql_cmd.Parameters.AddWithValue("@month", ex1.Month);
			sql_cmd.Parameters.AddWithValue("@year", ex1.Year);
			sql_cmd.Parameters.AddWithValue("@profile_id", profile_id);
			ExecuteNonQuery();
		}

		public void AddProfile(string profileName)
		{
			string quarry = "INSERT OR IGNORE INTO profile (`name`) VALUES (@name)";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@name", profileName);
			ExecuteNonQuery();
		}

		public void UpdateExpense(int id, Expense ex1)
		{
			//get cat_id

			string quarry = "INSERT OR IGNORE INTO Category (`name`) VALUES (@name)";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@name", ex1.Category);
			ExecuteNonQuery();

			quarry = "SELECT id FROM Category WHERE name = @name";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@name", ex1.Category);
			SQLiteDataReader result = sql_cmd.ExecuteReader();
			result.Read();
			int category_id = Convert.ToInt32(result[0]);
			result.Close();
			sql_con.Close();

			//get disc_id

			quarry = "INSERT INTO Description (`text`) VALUES (@text)";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@text", ex1.Description);
			ExecuteNonQuery();

			quarry = "SELECT id FROM Description WHERE (`text`) = @text";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@text", ex1.Description);
			result = sql_cmd.ExecuteReader();
			result.Read();
			int description_id =Convert.ToInt32(result[0]);
			result.Close();
			sql_con.Close();

			//edit
			quarry = "UPDATE Expense SET amount=@amount, category_id=@category_id, description_id=@description_id, day=@day, month=@month, year=@year WHERE ID = @id";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@amount", ex1.Ammount);
			sql_cmd.Parameters.AddWithValue("@category_id", category_id);
			sql_cmd.Parameters.AddWithValue("@description_id", description_id);
			sql_cmd.Parameters.AddWithValue("@day", ex1.Day);
			sql_cmd.Parameters.AddWithValue("@month", ex1.Month);
			sql_cmd.Parameters.AddWithValue("@year", ex1.Year);
			sql_cmd.Parameters.AddWithValue("@id", id);
			ExecuteNonQuery();


		}

		public void DeleteExpense(int id)
		{
			string quarry = "DELETE FROM Expense WHERE id = @id";
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@id", id);
			ExecuteNonQuery();
		}

		public List<Expense> GetExpenses(string profile)
		{
			int COLUMNS = 6; 
			List<Expense> expensesList = new List<Expense>();
			string quarry = "SELECT Expense.amount, Category.name, Description.text, Expense.day, Expense.month, Expense.year, Profile.name, Expense.id FROM Expense JOIN Category JOIN Description JOIN Profile ON Expense.category_id = Category.id AND Expense.description_id = Description.id AND Expense.profile_id = Profile.id WHERE Profile.name = @profile";

			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			sql_cmd.Parameters.AddWithValue("@profile", profile);
			SQLiteDataReader result = sql_cmd.ExecuteReader();
			if (result.HasRows)
			{
				int count = 0;
				while (result.Read())
				{
					expensesList.Add(new Expense(
						Convert.ToDouble(result[0]),
						Convert.ToString(result[1]),
						Convert.ToString(result[2]),
						Convert.ToInt32(result[3]),
						Convert.ToInt32(result[4]),
						Convert.ToInt32(result[5]),
						Convert.ToString(result[6])));
					expensesList[count].AddId(Convert.ToInt32(result[7]));
					count++;
				}
			}
			result.Close();
			sql_con.Close();

			return expensesList;
		}

		public List<string> GetProfiles()
		{
			List<string> profilesList = new List<string>();

			string quarry = "SELECT name FROM Profile";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			SQLiteDataReader result = sql_cmd.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					profilesList.Add(Convert.ToString(result[0]));
				}
			}
			result.Close();
			sql_con.Close();

			return profilesList;
		}

		public List<string> GetCategories()
		{
			List<string> categoryList = new List<string>();

			string quarry = "SELECT name FROM Category";
			sql_con.Open();
			sql_cmd = new SQLiteCommand(quarry, sql_con);
			SQLiteDataReader result = sql_cmd.ExecuteReader();
			if (result.HasRows)
			{
				while (result.Read())
				{
					categoryList.Add(Convert.ToString(result[0]));
				}
			}
			result.Close();
			sql_con.Close();

			return categoryList;
		}
	}
}
