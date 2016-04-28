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
    public partial class FlightView : Form
    {
        string username;
        public FlightView(string name)
        {
            username = name;
            InitializeComponent();
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
        public void LoadSearchedFlightDataView(string deparr)
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            FlightsDAL fdal = new FlightsDAL();
            fdal.OpenConnection(connectionStrings);

            var bindingList = new BindingList<Flight>(fdal.GetSearchedFlights(deparr));

            fdal.CloseConnection();
            var source = new BindingSource(bindingList, null);
            if (source != null && source.Count > 0) FlightDataView.DataSource = source;
        }

        private void HandleFlightDataViewSelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            if (FlightDataView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please Select a Flight!", "FlightView Warning");
                return;
            }
            string flightnumber = FlightDataView.SelectedCells[0].Value.ToString();
            FlightDetailView FDV = new FlightDetailView();
            FDV.setFlightNumber(flightnumber);
            FDV.ShowDialog();
            
            
        }

        private void btn_bkhistory_Click(object sender, EventArgs e)
        {
            BookedHistory bh = new BookedHistory(username);
            bh.ShowDialog();
        }

        private void btn_book_Click(object sender, EventArgs e)
        {
            if (FlightDataView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please Select a Flight!", "FlightView Warning");
                return;
            }
            
            Flight flight = new Flight
            {
                Flight_number = FlightDataView.SelectedCells[0].Value.ToString(),
                date = FlightDataView.SelectedCells[1].Value.ToString(),
                arrival = FlightDataView.SelectedCells[2].Value.ToString(),
                carrier = FlightDataView.SelectedCells[3].Value.ToString(),
                E_pirce = FlightDataView.SelectedCells[4].Value.ToString(),
                Eplus_pirce = FlightDataView.SelectedCells[5].Value.ToString(),
                B_pirce = FlightDataView.SelectedCells[6].Value.ToString()

            };
            BookFlight bf = new BookFlight(flight, username);
            bf.ShowDialog();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Fill in The Blank!");
                return;
            }
            LoadSearchedFlightDataView(txt_Search.Text);
        }

        private void btn_viewall_Click(object sender, EventArgs e)
        {
            LoadFlightDataView();
        }
    }
}
