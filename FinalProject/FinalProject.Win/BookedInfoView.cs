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
    public partial class BookedInfoView : Form
    {
        string flightnumber;
        public BookedInfoView(string Flight_number)
        {
            this.flightnumber = Flight_number;
            InitializeComponent();
            LoadData();
            
            
        }
        public void LoadData()
        {
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            BookedInfoDAL bdal = new BookedInfoDAL();
            bdal.OpenConnection(connectionStrings);
            var bindingList = new BindingList<BookedInfo>(bdal.getAllFlightInfo(flightnumber));
            bdal.CloseConnection();
            var source = new BindingSource(bindingList, null);
            if (source != null && source.Count > 0) BookedUserView.DataSource = source;

        }
    }
}
