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
            string shangzheng = SinaStockinfo.Shangzheng();
            string shenzheng = SinaStockinfo.Shenzheng();
            string hushen300 = SinaStockinfo.HuShen300();
            string line1 = "", line2 = "", line3 = "", line4 = "";
            line1 = DateTime.Now.ToString("yyyy-MM-dd ") + DateTime.Now.ToShortTimeString().ToString();
            for (int i = 0; i < 16 - shangzheng.Length; i++)
            {
                line2 += " ";
            }
            line2 += shangzheng;

            for (int i = 0; i < 16 - shenzheng.Length; i++)
            {
                line3 += " ";
            }
            line3 += shenzheng;

            for (int i = 0; i < 16 - hushen300.Length; i++)
            {
                line4 += " ";
            }
            line4 += hushen300;

            byte[] Strbyte = Encoding.GetEncoding("utf-8").GetBytes(line1 + line2 + line3 + line4);
            _digiSpark.WriteBytes(Strbyte);

        }
    }
}
