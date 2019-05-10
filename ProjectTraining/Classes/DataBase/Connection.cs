using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace ProjectTraining.Classes.DataBase
{
    class Connection
    {
        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\alexs\Desktop\C# Projects\ProjectTraining\Classes\DataBase\Users.mdf;Integrated Security=True";

        private static SqlConnection sqlConnection = new SqlConnection(connectionString);

        private static SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

        private static DataTable dataTable = new DataTable();

        public static void InsertValues(string Login, string Password, string Fullname, string Email)
        {
            string insertValues = "INSERT INTO Users(Login, Password, Fullname, Email)VALUES ('"+ Login +"', '"+Password+"', '"+Fullname+"', '"+ Email +"')";

            try
            {
                SqlCommand insertValueComm = new SqlCommand(insertValues, sqlConnection); ;
                insertValueComm.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void SelectLoginPass(string Login, string Password)
        {
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter("SELECT COUNT(*) FROM Users WHERE Login = '"+ Login +"' AND Password = '"+ Password +"'", sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                if (dataTable.Rows[0][0].ToString() == "1")
                {
                    OpeningForms.OpenMainForm();
                }
                else
                {
                    MessageBox.Show("No such user found!");
                }
                sqlConnection.Close();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        public static void CheckValuesLogin(string Login, string Password,string Fullname,string Email)
        {
            string query = "SELECT [Login] FROM Users WHERE Login = '" + Login + "'";
            try
            {
                sqlConnection.Open();
                sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                    if (dataTable.Rows.Count == 1) MessageBox.Show("This login already exists.");
                    else
                    {
                        InsertValues(Login, Password, Fullname, Email);
                        MessageBox.Show("Registration completed successfully");
                    }
                sqlConnection.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
