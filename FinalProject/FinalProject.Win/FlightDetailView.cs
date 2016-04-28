using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G = System.Configuration;

namespace FinalProject.Win
{
    public partial class FlightDetailView : Form
    {
        string Flight_number;
        public FlightDetailView()
        {
            InitializeComponent();
        }
        public void setFlightNumber(string flightnumber)
        {
            this.Flight_number = flightnumber;
        }

        private void btn_carrier_Click(object sender, EventArgs e)
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            FlightDetailDAL fdal = new FlightDetailDAL();
            fdal.OpenConnection(connectionStrings);
            Display.Text = fdal.GetDetail(Flight_number).Carrier_Info;
            fdal.CloseConnection();
           
        }

        private void btn_crew_Click(object sender, EventArgs e)
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            FlightDetailDAL fdal = new FlightDetailDAL();
            fdal.OpenConnection(connectionStrings);
            Display.Text = fdal.GetDetail(Flight_number).Crew_Info;
            fdal.CloseConnection();
        }

        private void btn_booked_Click(object sender, EventArgs e)
        {
            BookedInfoView BIF = new BookedInfoView(Flight_number);
            BIF.ShowDialog();
        }
    }
}
