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
    public partial class UpdateFlightView : Form
    {
        public UpdateFlightView(Flight flight, FlightDetail flightdetail)
        {
            InitializeComponent();
            LoadDate(flight, flightdetail);
        }

        private void LoadDate(Flight flight,FlightDetail flightdetail)
        {
            txt_FN.Text = flight.Flight_number;
            txt_arrival.Text = flight.arrival;
            txt_carrier.Text = flight.carrier;
            txt_ebp.Text = flight.B_pirce;
            txt_ep.Text = flight.E_pirce;
            txt_epp.Text = flight.Eplus_pirce;
            rtxt_carrierinfo.Text = flightdetail.Carrier_Info;
            rtxt_crewinfo.Text = flightdetail.Crew_Info;
            date_picker.Value = Convert.ToDateTime(flight.date);
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (txt_FN.Text.Trim().Length == 0 || txt_arrival.Text.Trim().Length == 0 || txt_carrier.Text.Trim().Length == 0 || txt_ebp.Text.Trim().Length == 0 || txt_ep.Text.Trim().Length == 0 || txt_epp.Text.Trim().Length == 0 || rtxt_carrierinfo.Text.Trim().Length == 0 || rtxt_crewinfo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill in All The Blanks!");
                return;
            }
            else if (!AddFlightView.NumberCheck(txt_ep.Text.Trim()) || !AddFlightView.NumberCheck(txt_epp.Text.Trim()) || !AddFlightView.NumberCheck(txt_ebp.Text.Trim()))
            {
                MessageBox.Show("Please Fill in Numbers for Price!");
                return;
            }
            FlightsDAL fdal = new FlightsDAL();
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            fdal.OpenConnection(connectionStrings);
            Flight f = new Flight {Flight_number = txt_FN.Text,arrival = txt_arrival.Text,carrier = txt_carrier.Text,B_pirce = txt_ebp.Text,Eplus_pirce = txt_epp.Text,E_pirce = txt_ep.Text,date = date_picker.Value.ToShortDateString() };
            fdal.UpdateFlight(f.Flight_number, f);
            fdal.CloseConnection();
            FlightDetail fd = new FlightDetail { Carrier_Info = rtxt_carrierinfo.Text,Crew_Info = rtxt_crewinfo.Text,Flight_number =txt_FN.Text };
            FlightDetailDAL fddal = new FlightDetailDAL();
            fddal.OpenConnection(connectionStrings);
            fddal.UpdateFlightDetail(fd.Flight_number, fd);
            fddal.CloseConnection();
        }
    }
}
