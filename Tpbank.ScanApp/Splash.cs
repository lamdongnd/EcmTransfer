using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using TpBank.Core.Componet;

namespace Tpbank.ScanApp
{
    public partial class Splash : Form
    {
        BackgroundWorker bgw = new BackgroundWorker();
        public Splash()
        {
            InitializeComponent();
            //Tasks
            //Starting
            tasks.Text = "Starting...";
            Thread.Sleep(100);

            bgw.DoWork += new DoWorkEventHandler(bgw_DoWork);
            bgw.ProgressChanged += new ProgressChangedEventHandler(bgw_ProgressChanged);
            bgw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bgw_RunWorkerCompleted);
            bgw.WorkerReportsProgress = true;
            bgw.RunWorkerAsync();
        }

        private void bgw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {   
            var newThread = new System.Threading.Thread(frmNewFormThread);
            newThread.SetApartmentState(System.Threading.ApartmentState.STA);
            Thread.Sleep(1000);
            newThread.Start();
            this.Close();
        }

        private void bgw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
            tasks.Text = String.Format("Progress: {0} %", e.ProgressPercentage);
            //label2.Text = String.Format("Total items transfered: {0}", e.UserState);
        }

        private void bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            ApplicationEngine.CheckAndCreateDefaultInfo();

            int total = 20; //some number (this is your variable to change)!!
            for (int i = 0; i <= total; i++) //some number (total)
            {
                System.Threading.Thread.Sleep(50);
                int percents = (i * 100) / total;
                bgw.ReportProgress(percents, i);
                //2 arguments:
                //1. procenteges (from 0 t0 100) - i do a calcumation 
                //2. some current value!
            }
        }

        public bool Isminimized = false;

        //Close Application
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Minimize Application
        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            Isminimized = true;
        }
        //Mouse hover and leave effects
        private void close_MouseHover(object sender, EventArgs e)
        {
            close.ForeColor = Color.Silver;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.ForeColor = Color.White;
        }

        private void minimize_MouseHover(object sender, EventArgs e)
        {
            minimize.ForeColor = Color.Silver;
        }

        private void minimize_MouseLeave(object sender, EventArgs e)
        {
            minimize.ForeColor = Color.White;
        }

        //Show MainForm(Form1)
        public void frmNewFormThread()
        {   
            var frmNewForm = new MainForm();
            if(Isminimized == true)
            {
                frmNewForm.WindowState = FormWindowState.Minimized;
            }
            else
            {
                frmNewForm.WindowState = FormWindowState.Normal;
            }
            Application.Run(frmNewForm);
        }

        private void Splash_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        

        private void Splash_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void Splash_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Splash_Shown(object sender, EventArgs e)
        {
            
        }
    }
}
