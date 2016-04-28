using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class BookedInfoDAL:InterfaceDAL
    {
        protected SqlConnection connection = null;
        public void CloseConnection()
        {
            try
            {
                connection.Close();
            }
            catch (SqlException e)
            {
                LogHelper.WriteLog(string.Format("Sql related exception occurred. Exception details: {0}", e.Message));
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(string.Format("A generic exception occurred. Exception details: {0}", e.Message));
            }
            finally
            {
                connection.Close();
            }
        }

        public void OpenConnection(string connectionString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connectionString;
            try
            {
                connection.Open();
            }
            catch (SqlException e)
            {
                LogHelper.WriteLog(string.Format("Sql related exception occurred. Exception details: {0}", e.Message));
            }
            catch (Exception e)
            {
                LogHelper.WriteLog(string.Format("A generic exception occurred. Exception details: {0}", e.Message));
            }
        }
        public void InsertInfo(BookedInfo info)
        {
            
            string sql = string.Format("Insert Into BookedInfo" +
                "(username, price, Flight_number) Values" +
                "('{0}', '{1}','{2}')", info.username, info.price, info.Flight_number);

           
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteInfo(string flightnumber,string username,string price)
        {
            // get ID of the car to delete, then try
            string sql = string.Format("Delete Top(1) from BookedInfo where Flight_number = '{0}' And username = '{1}' And price = '{2}' ", flightnumber,username,price);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    LogHelper.WriteLog(string.Format("Sql related exception occurred. Exception details: {0}", e.Message));
                }
                catch (Exception e)
                {
                    LogHelper.WriteLog(string.Format("A generic exception occurred. Exception details: {0}", e.Message));
                }
            }
        }
        public void DeleteInfo(string flightnumber)
        {
            string sql = string.Format("Delete from BookedInfo where Flight_number = '{0}'", flightnumber);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException e)
                {
                    LogHelper.WriteLog(string.Format("Sql related exception occurred. Exception details: {0}", e.Message));
                }
                catch (Exception e)
                {
                    LogHelper.WriteLog(string.Format("A generic exception occurred. Exception details: {0}", e.Message));
                }
            }

        }
        public List<BookedInfo> getAllFlightInfo(string flight_number)
        {
            var infoList = new List<BookedInfo>();
            string sql = string.Format("Select * From BookedInfo Where Flight_number = '{0}'",flight_number);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    infoList.Add(new BookedInfo
                    {
                        username = (string)dr["username"],
                    price = (string)dr["price"],
                    Flight_number = (string)dr["Flight_number"]
                
                });
                }
                dr.Close();
            }
            return infoList;
        }
        public List<BookedInfo> getAllUserBookedInfo(string username)
        {
            var infoList = new List<BookedInfo>();
            string sql = string.Format("Select * From BookedInfo Where username = '{0}'", username);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    infoList.Add(new BookedInfo
                    {
                        username = (string)dr["username"],
                        price = (string)dr["price"],
                        Flight_number = (string)dr["Flight_number"]

                    });
                }
                dr.Close();
            }
            return infoList;
        }
    }
}
