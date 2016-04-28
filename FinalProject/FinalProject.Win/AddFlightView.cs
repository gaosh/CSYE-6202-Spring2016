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
    public partial class AddFlightView : Form
    {
        public AddFlightView()
        {
            InitializeComponent();
            InitData();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void InitData()
        {
            txt_arrival.Text = "Dep/Arr";
            txt_carrier.Text = "CA";
            txt_ebp.Text = "1000";
            txt_ep.Text = "1000";
            txt_epp.Text = "1000";
            txt_FN.Text = "Text001";
            rtxt_carrierinfo.Text = "Input Carrier Info here.";
            rtxt_crewinfo.Text = "Input Crew Info here";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txt_FN.Text.Trim().Length == 0||txt_arrival.Text.Trim().Length == 0 || txt_carrier.Text.Trim().Length == 0|| txt_ebp.Text.Trim().Length == 0 || txt_ep.Text.Trim().Length == 0 || txt_epp.Text.Trim().Length == 0 || rtxt_carrierinfo.Text.Trim().Length == 0 || rtxt_crewinfo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill in All The Blanks!");
                return;
            }else if(!NumberCheck(txt_ep.Text)|| !NumberCheck(txt_epp.Text)|| !NumberCheck(txt_ebp.Text))
            {
                MessageBox.Show("Please Fill in Numbers for Price!");
                return;
            }
            else
            {
                
                Flight f = new Flight { Flight_number = txt_FN.Text, arrival = txt_arrival.Text, B_pirce = txt_ebp.Text, carrier = txt_carrier.Text, date = date_picker.Value.Date.ToShortDateString() , Eplus_pirce = txt_epp.Text, E_pirce = txt_ep.Text };
                FlightDetail fd = new FlightDetail { Flight_number = txt_FN.Text, Carrier_Info = rtxt_carrierinfo.Text, Crew_Info = rtxt_crewinfo.Text };
                G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
                string connectionStrings = settings.ConnectionString;
                FlightsDAL fdal = new FlightsDAL();
                fdal.OpenConnection(connectionStrings);
                fdal.InsertFlight(f);
                fdal.CloseConnection();
                FlightDetailDAL fddal = new FlightDetailDAL();
                fddal.OpenConnection(connectionStrings);
                fddal.InsertFlightDetail(fd);
                fddal.CloseConnection();
            }
        }
        public static Boolean NumberCheck(string gs)
        {
            Boolean b = true;

            if (gs == null)
            {
                return false;
            }

            char[] chars = gs.ToCharArray();
            foreach (char c in chars)
            {
                if (c > 47 && c < 58) { }
                else if (c == 46) { }
                else
                {
                    b = false;
                    break;
                }
            }
            return b;
        }
    }
}
