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
    public partial class AdministratorView : Form
    {
        public AdministratorView()
        {
            InitializeComponent();
            LoadFlightDataView();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            AddFlightView add = new AddFlightView();
            add.ShowDialog();
            LoadFlightDataView();
        }

        public void LoadFlightDataView()
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            FlightsDAL fdal = new FlightsDAL();
            fdal.OpenConnection(connectionStrings);

            var bindingList = new BindingList<Flight>(fdal.GetAllFlights());

            fdal.CloseConnection();
            var source = new BindingSource(bindingList, null);
            if (source != null && source.Count > 0) FlightDataView.DataSource = source;
        }

        private void btn_flightdetail_Click(object sender, EventArgs e)
        {
            if (FlightDataView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please Select a Flight!", "AdminView Warning");
                return;
            }
            string flightnumber = FlightDataView.SelectedCells[0].Value.ToString();
            FlightDetailView FDV = new FlightDetailView();
            FDV.setFlightNumber(flightnumber);
            FDV.ShowDialog();
            LoadFlightDataView();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure you want to delete this flight?",
                      "Delete Confirm",
                      MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
                string connectionStrings = settings.ConnectionString;
                if (FlightDataView.SelectedCells[0].Value == null)
                {
                    MessageBox.Show("Please Select a Flight!", "AdminView Warning");
                    return;
                }
                string flightnumber = FlightDataView.SelectedCells[0].Value.ToString();
                FlightsDAL fdal = new FlightsDAL();
                fdal.OpenConnection(connectionStrings);
                fdal.DeleteFlight(flightnumber);
                fdal.CloseConnection();
                FlightDetailDAL fddal = new FlightDetailDAL();
                fddal.OpenConnection(connectionStrings);
                fddal.DeleteFlightDetail(flightnumber);
                fddal.CloseConnection();
                BookedInfoDAL bdal = new BookedInfoDAL();
                bdal.OpenConnection(connectionStrings);
                bdal.DeleteInfo(flightnumber);
                bdal.CloseConnection();
            }
            else
            {
                return;
            }
            LoadFlightDataView();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (FlightDataView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please Select a Flight!", "AdminView Warning");
                return;
            }
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            string flightnumber = FlightDataView.SelectedCells[0].Value.ToString();
            FlightsDAL fdal = new FlightsDAL();
            fdal.OpenConnection(connectionStrings);
            Flight f = fdal.getFlight(flightnumber);
            fdal.CloseConnection();
            FlightDetailDAL fddal = new FlightDetailDAL();
            fddal.OpenConnection(connectionStrings);
            FlightDetail fd = fddal.GetDetail(flightnumber);
            fddal.CloseConnection();
            UpdateFlightView ufv = new UpdateFlightView(f,fd);
            ufv.ShowDialog();
            LoadFlightDataView();

        }
    }
}
