using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MovingIntake
{
    class UserInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime MoveDate { get; set; }
        public string FromStreet { get; set; }
        public string FromCity { get; set; }
        public string FromState { get; set; }
        public int FromZipCode { get; set; }
        public string ToStreet { get; set; }
        public string ToCity { get; set; }
        public string ToState { get; set; }
        public int ToZipCode { get; set; }
        public int Rooms { get; set; }
        public string Notes { get; set; }
        public int CustomerID { get; set; }
        public string SearchString { get; set; }

        static string configurationString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection connect = new SqlConnection(configurationString);
            DataTable tableView = new DataTable();
            try
            {
                var sqlSelectQuery = "SELECT * FROM UserIntake";
                SqlCommand command = new SqlCommand(sqlSelectQuery, connect);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                connect.Open();
                adapter.Fill(tableView);

            }
            catch (Exception)
            {

                throw new Exception("Database connection error on table pull");
            }
            finally
            {
                connect.Close();
            }
            return tableView;
        }
        public bool Submit(UserInfo userInfo)
        {
            var isSuccess = false;
            SqlConnection connect = new SqlConnection(configurationString);

            var sqlSubmitQuery = "INSERT INTO UserIntake (FirstName,LastName,Email,PhoneNumber,MoveDate,FromStreet,FromCity,FromState,FromZipCode,ToStreet,ToCity,ToState,ToZipCode,Rooms,Notes) VALUES (@FirstName,@LastName,@Email,@PhoneNumber,@MoveDate,@FromStreet,@FromCity,@FromState,@FromZipCode,@ToStreet,@ToCity,@ToState,@ToZipCode,@Rooms,@Notes)";
            SqlCommand command = new SqlCommand(sqlSubmitQuery, connect);
            command.Parameters.AddWithValue("@FirstName", userInfo.FirstName);
            command.Parameters.AddWithValue("@LastName", userInfo.LastName);
            command.Parameters.AddWithValue("@Email", userInfo.Email);
            command.Parameters.AddWithValue("@PhoneNumber", userInfo.PhoneNumber);
            command.Parameters.AddWithValue("@MoveDate", userInfo.MoveDate);
            command.Parameters.AddWithValue("@FromStreet", userInfo.FromStreet);
            command.Parameters.AddWithValue("@FromCity", userInfo.FromCity);
            command.Parameters.AddWithValue("@FromState", userInfo.FromState);
            command.Parameters.AddWithValue("@FromZipCode", userInfo.FromZipCode);
            command.Parameters.AddWithValue("@ToStreet", userInfo.ToStreet);
            command.Parameters.AddWithValue("@ToCity", userInfo.ToCity);
            command.Parameters.AddWithValue("@ToState", userInfo.ToState);
            command.Parameters.AddWithValue("@ToZipCode", userInfo.ToZipCode);
            command.Parameters.AddWithValue("@Rooms", userInfo.Rooms);
            command.Parameters.AddWithValue("@Notes", userInfo.Notes);

            connect.Open();
            int successCheck = command.ExecuteNonQuery();
            if (successCheck > 0)
                isSuccess = true;

            connect.Close();
            return isSuccess;
        }
        public bool Update(UserInfo userInfo)
        {
            var isSuccess = false;
            SqlConnection connect = new SqlConnection(configurationString);
            try
            {
                string sqlUpdateQuery = "UPDATE UserIntake SET FirstName=@FirstName,LastName=@LastName,Email=@Email,PhoneNumber=@PhoneNumber,MoveDate=@MoveDate,FromStreet=@FromStreet,FromCity=@FromCity,FromState=@FromState,FromZipCode=@FromZipCode,ToStreet=@ToStreet,ToCity=@ToCity,ToState=@ToState,ToZipCode=@ToZipCode,Rooms=@Rooms,Notes=@Notes WHERE CustomerID=@CustomerID";
                SqlCommand command = new SqlCommand(sqlUpdateQuery, connect);
                command.Parameters.AddWithValue("@CustomerID", userInfo.CustomerID);
                command.Parameters.AddWithValue("@FirstName", userInfo.FirstName);
                command.Parameters.AddWithValue("@LastName", userInfo.LastName);
                command.Parameters.AddWithValue("@Email", userInfo.Email);
                command.Parameters.AddWithValue("@PhoneNumber", userInfo.PhoneNumber);
                command.Parameters.AddWithValue("@MoveDate", userInfo.MoveDate);
                command.Parameters.AddWithValue("@FromStreet", userInfo.FromStreet);
                command.Parameters.AddWithValue("@FromCity", userInfo.FromCity);
                command.Parameters.AddWithValue("@FromState", userInfo.FromState);
                command.Parameters.AddWithValue("@FromZipCode", userInfo.FromZipCode);
                command.Parameters.AddWithValue("@ToStreet", userInfo.ToStreet);
                command.Parameters.AddWithValue("@ToCity", userInfo.ToCity);
                command.Parameters.AddWithValue("@ToState", userInfo.ToState);
                command.Parameters.AddWithValue("@ToZipCode", userInfo.ToZipCode);
                command.Parameters.AddWithValue("@Rooms", userInfo.Rooms);
                command.Parameters.AddWithValue("@Notes", userInfo.Notes);

                connect.Open();
                int successCheck = command.ExecuteNonQuery();
                if (successCheck > 0)
                    isSuccess = true;
            }
            catch (Exception)
            {
                throw new Exception("Database connection error on Update");
            }
            finally
            {
                connect.Close();
            }
            return isSuccess;
        }
        public bool Delete(UserInfo userInfo)
        {
            var isSuccess = false;
            SqlConnection connect = new SqlConnection(configurationString);
            try
            {
                string sqlDeleteQuery = "DELETE FROM UserIntake WHERE CustomerID=@CustomerID";
                SqlCommand command = new SqlCommand(sqlDeleteQuery, connect);
                command.Parameters.AddWithValue("@CustomerID", userInfo.CustomerID);
                connect.Open();
                int successCheck = command.ExecuteNonQuery();
                if (successCheck > 0)
                    isSuccess = true;
            }
            catch (Exception)
            {
                throw new Exception("Database connection error on Delete");
            }
            finally
            {
                connect.Close();
            }
            return isSuccess;
        }
        public DataTable Search(object sender)
        {
            TextBox passedbox = (TextBox)sender;
            var searchString = passedbox.Text;
            var sqlSearchQuery = "SELECT * FROM UserIntake WHERE FirstName LIKE '%"+searchString+"%' OR LastName LIKE '%"+searchString+"%' OR Email LIKE '%"+searchString+"%' OR PhoneNumber LIKE '%"+searchString+"%'";
            SqlConnection connect = new SqlConnection(configurationString);
            SqlDataAdapter sqlSearchAdapter = new SqlDataAdapter(sqlSearchQuery, connect);
            DataTable dt = new DataTable();
            sqlSearchAdapter.Fill(dt);
            return dt;
        }
    }
}