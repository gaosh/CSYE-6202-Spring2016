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
    public partial class BookedHistory : Form
    {
        string username;
        public BookedHistory(string Username)
        {
            username = Username;
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            BookedInfoDAL bdal = new BookedInfoDAL();
            bdal.OpenConnection(connectionStrings);
            var bindingList = new BindingList<BookedInfo>(bdal.getAllUserBookedInfo(username));
            bdal.CloseConnection();
            var source = new BindingSource(bindingList, null);
            if (source != null && source.Count > 0) BookedInfoView.DataSource = source;

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_unbook_Click(object sender, EventArgs e)
        {
            if (BookedInfoView.SelectedCells[0].Value == null)
            {
                MessageBox.Show("Please Select a Flight!", "BookedHistory Warning");
                return;
            }
            BookedInfo BI = new BookedInfo {username = BookedInfoView.SelectedCells[0].Value.ToString(),
            price = BookedInfoView.SelectedCells[1].Value.ToString(),
            Flight_number = BookedInfoView.SelectedCells[2].Value.ToString()
            };
            var confirmResult = MessageBox.Show("Are you sure you want to unpurchase this ticket?",
                                  "Unpurchase Confirm",
                                  MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes) { 
                G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            BookedInfoDAL bdal = new BookedInfoDAL();
            bdal.OpenConnection(connectionStrings);
            bdal.DeleteInfo(BI.Flight_number, BI.username, BI.price);
            bdal.CloseConnection();
            LoadData();
            }
            else
            {
                return;
            }
        }
    }
}
