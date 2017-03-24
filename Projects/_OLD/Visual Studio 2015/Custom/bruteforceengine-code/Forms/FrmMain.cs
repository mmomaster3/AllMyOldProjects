using System;
using System.Diagnostics;
using System.Windows.Forms;
using Engine_Brute.Forms;
using Engine_Brute.Properties;


//using Microsoft.VisualBasic;

namespace Engine_Brute
{
    public partial class FrmMain : Form
    {
        public Checker Check1 = new  Checker();

        public FrmMain()
        {
            InitializeComponent();
        }

        public delegate void ParametrizedMethodInvoker(object arg);

        //этот метод будет выполняться главным потоком
        public void SetText(object arg)
        {
            try
            {
                if (this.InvokeRequired)
                {
                    //если мы не в главном потоке - то вызовем себя через инвокер
                    this.Invoke(new ParametrizedMethodInvoker(SetText), arg);
                    return;
                }
                //это присвоение всегда будет происходить только в главном потоке
                //независимо от того в каком потоке мы вызывает данный метод
                this.txtLog.Text = arg.ToString() + txtLog.Text;
            }catch{}
        } 

        public void SetLabelTxt(int txt, string combotext)
        {
            lblCountProxy.Text = txt.ToString();
            CbProxyType.Text = combotext;
        }

        public void SetSourceTxt(string count)
        {
            this.lblCountSource.Text = count;
        }
     
        private void BtnSourceClick(object sender, EventArgs e)
        {
            new FrmSource().ShowDialog();
        }

        private void BtnProxyClick(object sender, EventArgs e)
        {
            new FrmProxy().ShowDialog();
        }

        private void CbProxyTypeSelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbProxyType.Text == "HTTP")
            {
                Globals.TypeProxy = 1;
            }
            else if (CbProxyType.Text == "Socks4")
            {
                Globals.TypeProxy = 2;
            }
            else if (CbProxyType.Text == "Socks5")
            {
                Globals.TypeProxy = 3;
            } else
            {
                CbProxyType.Text = "HTTP";
                Globals.TypeProxy = 1;
            }
        }

        private void BtnStartClick(object sender, EventArgs e)
        {
            if(!Check1.IsWork)
            {
                
                if (Globals.Source.Count == 0 || Globals.Proxy.Count == 0)
                {
                    MessageBox.Show("Please load Source & Proxy files", "Engine Brute", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Globals.CountBad = 0;
                Globals.CountGood = 0;

                Globals.CountThreads = Convert.ToInt32(nThreads.Value);
                Globals.Delimiter = txtDelimiter.Text;
                try
                {
                    Globals.TimeOut = Convert.ToInt32(txtTimeOut.Text);
                }
                catch (Exception ex)
                {
                    Globals.WorkStatus = "TimeOut: " + ex.Message;
                }

                Check1.CreateThreads();

                btnStart.Text = "Stop    ";
                btnStart.Image = Resources.stop;

                tabSettings.Enabled = false;
                tabLists.Enabled = false;
                txtLog.Clear();
            } 
            else
            {
                Check1.StopThreads();

                btnStart.Text = "Start   ";
                btnStart.Image = Resources.start;
                tabSettings.Enabled = true;
                tabLists.Enabled = true;
            }

        }

        private void nThreads_ValueChanged(object sender, EventArgs e)
        {
            Globals.CountThreads = (int) nThreads.Value;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new FrmAbout().ShowDialog();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            CbProxyType.DataSource = new[] {"HTTP", "Socks4", "Socks5"};
            CbProxyType.DisplayMember = "Name";
        }

        private void Tray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
        
        private void picSound_Click(object sender, EventArgs e)
        {
            if(Globals.SoundOn )
            {
                Globals.SoundOn = false;
                picSound.Image = Resources.sound_off;
            } 
            else
            {
                Globals.SoundOn = true;
                picSound.Image = Resources.sound_on;
            }
        }

        private void Gui_Tick(object sender, EventArgs e)
        {
            if(!Check1.IsWork)
            {
                btnStart.Text = "Start   ";
                btnStart.Image = Resources.start;
                tabSettings.Enabled = true;
                tabLists.Enabled = true;

                this.lblCountLeft.Text = "0";
            }

            this.lblCountGood.Text = Globals.CountGood.ToString();
            this.lblCountBad.Text = Globals.CountBad.ToString();
            this.lblCountPPS.Text = Globals.Pps.ToString();
            this.lblCountLeft.Text = (Globals.Source.Count - (Globals.CountGood + Globals.CountBad)).ToString();
            
            Globals.Pps = 0;
        }

        private void txtLog_Clicked(object sender, EventArgs e)
        {
            btnStart.Focus();
        }

        private void trayShowStatistic_Click(object sender, EventArgs e)
        {
            Tray.BalloonTipIcon = ToolTipIcon.Info;
            Tray.BalloonTipTitle = "Statistics";
            Tray.BalloonTipText = Helper.RawStatisitc();
            Tray.ShowBalloonTip(5000);
        }

        private void trayShowProgram_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void trayExitApp_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtDelimiter_TextChanged(object sender, EventArgs e)
        {
            if (txtDelimiter.Text == "")
            {
                txtDelimiter.Text = ";";
            }
        }

        private void txtDelimiter_Click(object sender, EventArgs e)
        {
            txtDelimiter.SelectAll();
        }
        
        private void picTray_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Process.Start("http://extrime-code.ru/");
        }
    }
}