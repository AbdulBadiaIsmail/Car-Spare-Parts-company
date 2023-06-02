
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Hosting;
using Owin;
using Microsoft.Owin.Cors;


namespace Car_Spare_Parts_company
{
    internal static class Program
    {
        static IDisposable SignalR;




        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            //string url = "https://localhost:7125/";
            // WebApp.Start<Startup>(url);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Dashboard(new HRusercontrol ()));
        }

        //public class Startup
        //{
        //    public void Configuration(IAppBuilder app)
        //    {
        //        app.UseCors(CorsOptions.AllowAll);

        //        app.MapSignalR();
                

        //    }
        //}

      

    }
}
