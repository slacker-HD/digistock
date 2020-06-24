using System;
using System.Text;
using System.Windows.Forms;

namespace StockInfo
{
    public partial class Frm_Setting : Form
    {
        private ArduinoUsbDevice _digiSpark;
        public Frm_Setting(ArduinoUsbDevice digiSpark)
        {
            InitializeComponent();
            _digiSpark = digiSpark;
        }

        public Frm_Setting()
        {
            InitializeComponent();
        }

        public void ShowTooltip(Object status)
        {
            if ((bool)status)
                nf_config.ShowBalloonTip(3000, "提示", "设备已连接", ToolTipIcon.Info);
            else
                nf_config.ShowBalloonTip(3000, "提示", "设备已断开", ToolTipIcon.Info);
        }

        private void Frm_Setting_Load(object sender, EventArgs e)
        {
        }

        private void Nf_config_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.WindowState = FormWindowState.Normal;
                this.Activate();
                this.ShowInTaskbar = true;
            }
        }

        private void Nf_config_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.ShowInTaskbar = true;
        }

        private void Frm_Setting_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
            }
            if (this.WindowState == FormWindowState.Normal)
            {
                this.ShowInTaskbar = true;
            }
        }

        private void Frm_Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                e.Cancel = true;
                this.Hide();
                this.ShowInTaskbar = false;
            }
        }

        private void Mn_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            byte[] Strbyte = Encoding.GetEncoding("utf-8").GetBytes(DateTime.Now.ToString("yyyy-MM-dd ") + DateTime.Now.ToShortTimeString().ToString() + "         2979.55" + "        11813.53" + "         4138.99");
            _digiSpark.WriteBytes(Strbyte);
            MessageBox.Show(SinaStockinfo.HuShen300());
        }
    }
}
