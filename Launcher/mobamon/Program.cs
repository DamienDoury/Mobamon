using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mobamon
{
    static class Program
    {
      
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
 

        static void Main()
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.google.fr/");
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK) { }
                else
                {
                    MessageBox.Show("You need an intenet connection"); Application.ExitThread();

                    Application.Exit();


                }
            }
            catch
            {
                MessageBox.Show("You need an intenet connection"); Application.ExitThread();

                Application.Exit();
            }




            Process[] pname = Process.GetProcessesByName("mobamon");
            if (pname.Length != 0)
            {
                MessageBox.Show("An instance is already in progress"); Application.ExitThread();

                Application.Exit();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());

            }
            
          
        }
    }
}
