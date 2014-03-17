using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Collections;
using System.Diagnostics; 

namespace mobamon
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();  

        int Checkupdate = 1;
        int nbfiles = 0;
        int completed = 0;
        public Form1()
        {







            InitializeComponent();


            pictureBox6.MouseDown += new MouseEventHandler(move_window); // binding the method to the event




        }

 
        private void Form1_Load(object sender, System.EventArgs e)
        {
            pictureBox2.Parent = pictureBox6;
            pictureBox4.Parent = pictureBox6;
            pictureBox3.Parent = pictureBox6;
            pictureBox5.Parent = pictureBox6;
            label2.Parent = pictureBox6;
            label1.Parent = pictureBox6;
             
        //    pictureBox2.Parent = pictureBox6;



           // pictureBox2.Location.Offset(-pictureBox6.Left, -pictureBox6.Top);

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackColor = Color.Transparent;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://poke.theo-beaudenon.fr/");
                request.Timeout = 5000;
                request.Credentials = CredentialCache.DefaultNetworkCredentials;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.BeginInvoke((MethodInvoker)delegate
                    {
                        Checkupdatefonc();
                    });
                }
                else
                {
                   yolo.Text ="Offline";
                   Checkupdate =2;


                }
            }
            catch
            {
                yolo.Text = "Offline";
                  Checkupdate =2;
            }


         
     
        
        
        
        
        
        
        }
     
        bool flag = false;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Check if Flag is True ??? if so then make form position same
            //as Cursor position
            if (flag == true)
            {
                this.Location = Cursor.Position;
            }
        }
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

     

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int LPAR);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        const int WM_NCLBUTTONDOWN = 0xA1;
        const int HT_CAPTION = 0x2;

        private void move_window(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yolo_Click(object sender, EventArgs e)
        {

            Start();


        }

        private void Start()
        {

            if (Checkupdate == 0)
            {
               // System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
                System.Diagnostics.Process.Start("mobamon.exe");
                Application.Exit(); Application.ExitThread(); 

            }
            else if (Checkupdate == 2) { MessageBox.Show("We are Offline"); }
            else
            {

                MessageBox.Show("Update in progress.");

            }

            
        }

        private void Checkupdatefonc()
        {

            yolo.Text = "Checking diferencies";

 
                var url = "http://poke.theo-beaudenon.fr/gamedata/parse.php";

                var textFromFile = (new WebClient()).DownloadString(url);

 

          
           // Console.Write(textFromFile);

            string[] filedata = Regex.Split(textFromFile, "<br>");

            string appDataPath = System.IO.Directory.GetCurrentDirectory();;

           
 


           
            nbfiles = filedata.Length;
            completed = 0;
            int i;


                 for (i=0; i < filedata.Length; i++)
            {


                string[] file = Regex.Split(filedata[i], "---");

                try
                {


                    long length = new System.IO.FileInfo(file[0]).Length;
                    int len = Convert.ToInt32(file[1]);
                     Console.Write(length + "\n");
                    if (len.Equals((int)length))
                    {
                        completed += 1; // fichier identique
                    }
                    else
                    {
                        long lengtherr = new System.IO.FileInfo("dzdzdzdz.dzdzd").Length;

                    }

                }

                catch
                {

                    WebClient client = new WebClient();

                    ArrayList numbers = new ArrayList(file[0].Split(new char[] { '/' }));
                    String name = (string)numbers[numbers.Count - 1];
                    numbers.RemoveAt(numbers.Count - 1);

                    string[] array = numbers.ToArray(typeof(string)) as string[];

                    string result = string.Join("/", array);

                    try
                    {

                        Directory.CreateDirectory(result);
                    }
                    catch
                    {


                    }

                    // Starts the download
                    yolo.Text = "Downloading 1/" + filedata.Length;
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);

                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

                    client.DownloadFileAsync(new Uri("http://poke.theo-beaudenon.fr/gamedata/" + file[0]), file[0]);
                   

                }
                //DOWNLOAD
                if (completed == filedata.Length)
                {

                    progressBar2.Value = 100;
                          yolo.Text = "PLAY ";
                            label1.Text = "";
                            label1.Visible = false;
                            pictureBox5.Visible = false;
                            Checkupdate = 0;


                   }

            }
            
            //  throw new NotImplementedException();
        }

      

        private void pictureBox2_Click(object sender, EventArgs e)
        {

          
        }

        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate
            {
                double bytesIn = double.Parse(e.BytesReceived.ToString());
                double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = bytesIn / totalBytes * 100;


                // Update the label with how much data have been downloaded so far and the total size of the file we are currently downloading
                String vitesse = string.Format("{0} MB / {1} MB",
                    (e.BytesReceived / 1024d / 1024d).ToString("0.00"),
                    (e.TotalBytesToReceive / 1024d / 1024d).ToString("0.00"));



                label1.Text = "Downloaded " + e.BytesReceived + " of " + e.TotalBytesToReceive   + "    "  +   vitesse;
                progressBar2.Value = int.Parse(Math.Truncate(percentage).ToString());
            });
        }

        private void Completed(object sender, AsyncCompletedEventArgs e )
        {
            // Reset the stopwatch.
            sw.Reset();

            if (e.Cancelled == true)
            {
              
                MessageBox.Show("Download has been canceled.");
            }
            else
            {
                completed += 1;
                yolo.Text = "Downloading "+ completed  +"/" + nbfiles;
             //   MessageBox.Show("Download completed!");


                if (completed == nbfiles)
                {
                 
                    Checkupdatefonc();
                }
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
             
            WindowState = FormWindowState.Minimized;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            Console.Write(sender);
            			 


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

     

    


    }
}
