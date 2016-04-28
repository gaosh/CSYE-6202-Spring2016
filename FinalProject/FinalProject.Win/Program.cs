using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace FinalProject.Win
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Login login = new Login();
            FlightView Fv;
            login.ShowDialog();
            LogHelper.WriteLog("Porgram Started!");
            if (login.getFlag())
            {
                LogHelper.WriteLog("Login Success!");
                Fv = new FlightView(login.getUsername());
                Fv.ShowDialog();
            }else if (login.getAdmin())
            {
                
                AdministratorView Ad = new AdministratorView();
                Ad.ShowDialog();
            }
            else
            {
                Application.Exit();
            }


        }
    }
}
