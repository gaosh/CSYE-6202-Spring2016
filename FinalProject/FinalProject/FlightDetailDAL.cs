using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class FlightDetailDAL : InterfaceDAL
    {
        private SqlConnection connection = null;
        public void OpenConnection(string connenctonString)
        {
            connection = new SqlConnection();
            connection.ConnectionString = connenctonString;
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
        public void InsertFlightDetail(FlightDetail FD)
        {
            string sql = string.Format("Insert Into FlightDetails" +
               "(Crew_Info, Carrier_Info, Flight_number) Values" +
               "('{0}', '{1}','{2}')", FD.Crew_Info, FD.Carrier_Info, FD.Flight_number);


            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFlightDetail(string Flight_number)
        {
            string sql = string.Format("Delete from FlightDetails where Flight_Number = '{0}'", Flight_number);

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
        public FlightDetail GetDetail(string Flight_number)
        {
            FlightDetail fd;
            string sql = string.Format("Select * From FlightDetails Where Flight_number = '{0}'", Flight_number);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                fd = new FlightDetail {Flight_number = (string)dr["Flight_number"],Carrier_Info = (string)dr["Carrier_Info"],Crew_Info = (string)dr["Crew_Info"] };
                
            }
                return fd;
        }
    }
}
