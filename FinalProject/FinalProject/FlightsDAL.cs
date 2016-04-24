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
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
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
                    Console.WriteLine("Sql related exception occurred. Exception details: {0}", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("A generic exception occurred. Exception details: {0}", e.Message);
                }
            }

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
