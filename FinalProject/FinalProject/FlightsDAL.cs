using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FinalProject
{
    public class FlightsDAL:InterfaceDAL
    {

        private SqlConnection connection = null;
        public void OpenConnection(string connenctonString)
        {
           
            connection = new SqlConnection();
            connection.ConnectionString = connenctonString;
            try {
                connection.Open();
            }
            catch(SqlException e)
            {
                LogHelper.WriteLog(string.Format("Sql related exception occurred. Exception details: {0}", e.Message));
            }catch(Exception e)
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
        public void InsertFlight(Flight flight)
        {

            string sql = string.Format("Insert Into Flights" +
                "(Flight_Number, date, arrival, E_price,Eplus_price,B_price, carrier) Values" +
                "('{0}', '{1}', '{2}', '{3}','{4}','{5}','{6}')", flight.Flight_number,flight.date,flight.arrival,flight.E_pirce,flight.Eplus_pirce,flight.B_pirce,flight.carrier);


            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public void DeleteFlight(string flightnumber)
        {
            string sql = string.Format("Delete from Flights where Flight_Number = '{0}'", flightnumber);

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
                    LogHelper.WriteLog(string.Format("A general exception occurred. Exception details: {0}", e.Message));
                }
            }

        }
        public void UpdateCarPetName(string Flightnumber, Flight flight)
        {
            string sql = string.Format("Update Flights Set date = '{0}' Set arrival = '{1}' Set E_price = '{2}' Set Eplus_price= '{3}' Set B_price = '{4}' Set carrier = '{5}' Where Flight_Number = '{6}'",
                flight.date,flight.arrival,flight.E_pirce,flight.Eplus_pirce,flight.B_pirce,flight.carrier, Flightnumber);

            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                command.ExecuteNonQuery();
            }
        }
        public Flight getFlight(string flightnumber)
        {
            Flight flight;
            string sql = string.Format("Select Top(1) * From Flights Where Flight_number = '{0}'", flightnumber);
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                dr.Read();
                flight = new Flight
                {
                    Flight_number = (string)dr["Flight_number"],
                    carrier = (string)dr["carrier"],
                    date = (string)dr["date"],
                    arrival = (string)dr["arrival"],
                    E_pirce = (string)dr["E_price"],
                    Eplus_pirce = (string)dr["Eplus_price"],
                    B_pirce = (string)dr["B_price"]

                };
            }
                return flight;
        }
        public List<Flight> GetAllFlights()
        {
            var Flightlist = new List<Flight>();
            string sql = "Select * From Flights";
            using (SqlCommand command = new SqlCommand(sql, connection))
            {
                SqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Flightlist.Add(new Flight
                    {
                        Flight_number = (string)dr["Flight_number"],
                        carrier = (string)dr["carrier"],
                        date = (string)dr["date"],
                        arrival = (string)dr["arrival"],
                        E_pirce = (string)dr["E_price"],
                        Eplus_pirce = (string)dr["Eplus_price"],
                        B_pirce = (string)dr["B_price"]

                    });
                }
            }
                return Flightlist;
        }
        
    }
}
