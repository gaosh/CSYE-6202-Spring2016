using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class UserDAL:InterfaceDAL
    {
        private SqlConnection connection = null;

        public void OpenConnection(string connenctonString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connenctonString;
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }
        public User FindUser(string userID)
        {
            User user;
            string sql = string.Format("Select * From Users Where UserID = '{0}'", userID);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                user = new User {Username = (string)dr["UserID"],Password = (string)dr["Password"] };
                user.Password = user.Password.TrimEnd();
                

            }
            return user;
        }

        public void InsertUser(User user)
        {
            string sql = string.Format("Insert Into Users" +
                "(UserID, Password) Values" +
                "('{0}','{1}')", user.Username, user.Password
                );
            using(SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteUser(string userid)
        {
            string sql = string.Format("Delete form Users where UserID = '{0}'", userid);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    Console.WriteLine("Sql related exception occurred. Exception details: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("A generic exception occurred. Exception details: {0}", e.Message);
                }
            }
        }
    }
}
