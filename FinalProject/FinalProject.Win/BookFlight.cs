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
    public partial class BookFlight : Form
    {
        Flight flight = new Flight();
        BookedInfo bif = new BookedInfo();
        public BookFlight(Flight f,string username)
        {
            flight = f;
            InitializeComponent();
            InitData(f);
            bif.username = username;
        }
        public void InitData(Flight f)
        {
            Class_E.Text = string.Format("Economy Class, Price:{0}", f.E_pirce);
            Class_EP.Text = string.Format("Economy Plus Class, Price:{0}", f.Eplus_pirce);
            Class_B.Text = string.Format("Bussiness Class, Price:{0}", f.B_pirce);
        }

        private void btn_confrim_Click(object sender, EventArgs e)
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            BookedInfoDAL bdal = new BookedInfoDAL();
            bif.Flight_number = flight.Flight_number;
            var confirmResult = MessageBox.Show("Are you sure you want to purchase this ticket?",
                                    "Purchase Confirm",
                                    MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (rb_ec.Checked == true)
                {
                    bif.price = flight.E_pirce;
                }
                else if (rb_epc.Checked == true)
                {
                    bif.price = flight.Eplus_pirce;
                }
                else if (rb_bc.Checked == true)
                {
                    bif.price = flight.B_pirce;
                }
                else
                {
                    MessageBox.Show("Please Select One Class!", "Purchase Warning");
                    return;
                }
            }
            else
            {
                return;
            }
            bdal.OpenConnection(connectionStrings);
            bdal.InsertInfo(bif);
            bdal.CloseConnection();
 
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
