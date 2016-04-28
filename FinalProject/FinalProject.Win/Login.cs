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
    public partial class Login : Form
    {
        bool a = false;
        bool b = false;
        string username;
        public Login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_password.Text == null || txt_username.Text == null)
            {
                MessageBox.Show("Please Fill in All the Information!", "Login Warning!");
                return;
            }
            if(txt_username.Text == "admin" && txt_password.Text == "admin")
            {
                a = true;
                MessageBox.Show("Login Successful as Admin!", "Login Success");
                this.Close();
                return;
            }
            G.ConnectionStringSettings settings = G.ConfigurationManager.ConnectionStrings["Myconnection"];
            string connectionStrings = settings.ConnectionString;
            UserDAL udal = new UserDAL();
            User user = new User();
            udal.OpenConnection(connectionStrings);
            try
            {
                user = udal.FindUser(txt_username.Text);
            }catch(Exception)
            {
                MessageBox.Show("Wrong Username!", "Login Warning");
                return;
            }
            udal.CloseConnection();
            if(txt_password.Text == user.Password)
            {
                username = user.Username;
                MessageBox.Show("Login Successfully!", "Login Success");
                b = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Password!", "Login Warning");
                return;
            }
        }
        public Boolean getFlag()
        {
            return b;
        }
        public string getUsername()
        {
            
            return username;
        }
        public Boolean getAdmin()
        {
            return a;
        }
    }
}
