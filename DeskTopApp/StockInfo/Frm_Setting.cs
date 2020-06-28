using System;
using System.Text;
using System.Windows.Forms;

namespace StockInfo
{
    public partial class Frm_Setting : Form
    {
        private ArduinoUsbDevice _digiSpark;
        private string[] Codes;
        private int Showindex = 0;

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
            Codes = ConfigHelper.GetCodes().Split(',');
            Dgv_data.Rows.Clear();
            foreach (string code in Codes)
            {
                Dgv_data.Rows.Add(code);
            }
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

        private void Btn_Set_Click(object sender, EventArgs e)
        {
            string code = "";
            for (int i = 0; i < Dgv_data.Rows.Count - 1; i++)
            {
                code += Dgv_data.Rows[i].Cells[0].Value + ",";
            }
            if (code.Length > 0)
            {
                code = code.Substring(0, code.Length - 1);
            }
            ConfigHelper.SaveCodes(code);
            Codes = ConfigHelper.GetCodes().Split(',');
            Showindex = 0;
            this.WindowState = FormWindowState.Minimized;
        }

        private void Tm_main_Tick(object sender, EventArgs e)
        {
            if (_digiSpark.IsAvailable)
            {
                string line1 = "", line2 = "", line3 = "", line4 = "";
                if (Showindex == 0)
                {
                    line1 = DateTime.Now.ToString("yyyy-MM-dd ") + DateTime.Now.ToShortTimeString().ToString();
                    string[] results = SinaStockinfo.GetFirstScreenvalue();
                    for (int i = 0; i < 16 - results[0].Length; i++)
                    {
                        line2 += " ";
                    }
                    line2 += results[0];
                    for (int i = 0; i < 16 - results[1].Length; i++)
                    {
                        line3 += " ";
                    }
                    line3 += results[1];
                    for (int i = 0; i < 16 - results[2].Length; i++)
                    {
                        line4 += " ";
                    }
                    line4 += results[2];
                    Showindex++;
                }
                else
                {
                    if (Codes.Length - (Showindex - 1) * 4 >= 4)
                    {
                        string[] results = SinaStockinfo.Getvalue(Codes[(Showindex - 1) * 4] + "," + Codes[(Showindex - 1) * 4 + 1] + "," + Codes[(Showindex - 1) * 4 + 2] + "," + Codes[(Showindex - 1) * 4 + 3]);
                        line1 = Codes[(Showindex - 1) * 4];
                        for (int i = 0; i < 16 - results[0].Length - Codes[(Showindex - 1) * 4].Length; i++)
                        {
                            line1 += " ";
                        }
                        line1 += results[0];

                        line2 = Codes[(Showindex - 1) * 4 + 1];
                        for (int i = 0; i < 16 - results[1].Length - Codes[(Showindex - 1) * 4 + 1].Length; i++)
                        {
                            line2 += " ";
                        }
                        line2 += results[1];

                        line3 = Codes[(Showindex - 1) * 4 + 2];
                        for (int i = 0; i < 16 - results[2].Length - Codes[(Showindex - 1) * 4 + 2].Length; i++)
                        {
                            line3 += " ";
                        }
                        line3 += results[2];

                        line4 = Codes[(Showindex - 1) * 4 + 3];
                        for (int i = 0; i < 16 - results[2].Length - Codes[(Showindex - 1) * 4 + 3].Length; i++)
                        {
                            line4 += " ";
                        }
                        line4 += results[3];

                        if ((Showindex - 1) * 4 + 4 >= Codes.Length)
                        {
                            Showindex = 0;
                        }
                        else
                        {
                            Showindex++;
                        }
                    }
                    else if (Codes.Length - (Showindex - 1) * 4 == 3)
                    {
                        string[] results = SinaStockinfo.Getvalue(Codes[(Showindex - 1) * 4] + "," + Codes[(Showindex - 1) * 4 + 1] + "," + Codes[(Showindex - 1) * 4 + 2]);
                        line1 = Codes[(Showindex - 1) * 4];
                        for (int i = 0; i < 16 - results[0].Length - Codes[(Showindex - 1) * 4].Length; i++)
                        {
                            line1 += " ";
                        }
                        line1 += results[0];

                        line2 = Codes[(Showindex - 1) * 4 + 1];
                        for (int i = 0; i < 16 - results[1].Length - Codes[(Showindex - 1) * 4 + 1].Length; i++)
                        {
                            line2 += " ";
                        }
                        line2 += results[1];

                        line3 = Codes[(Showindex - 1) * 4 + 2];
                        for (int i = 0; i < 16 - results[2].Length - Codes[(Showindex - 1) * 4 + 2].Length; i++)
                        {
                            line3 += " ";
                        }
                        line3 += results[2];
                        line4 = "                ";
                        Showindex = 0;
                    }
                    else if (Codes.Length - (Showindex - 1) * 4 == 2)
                    {
                        string[] results = SinaStockinfo.Getvalue(Codes[(Showindex - 1) * 4] + "," + Codes[(Showindex - 1) * 4 + 1]);
                        line1 = Codes[(Showindex - 1) * 4];
                        for (int i = 0; i < 16 - results[0].Length - Codes[(Showindex - 1) * 4].Length; i++)
                        {
                            line1 += " ";
                        }
                        line1 += results[0];

                        line2 = Codes[(Showindex - 1) * 4 + 1];
                        for (int i = 0; i < 16 - results[1].Length - Codes[(Showindex - 1) * 4 + 1].Length; i++)
                        {
                            line2 += " ";
                        }
                        line2 += results[1];

                        line3 = "                ";
                        line4 = "                ";
                        Showindex = 0;
                    }
                    else
                    {
                        string[] results = SinaStockinfo.Getvalue(Codes[(Showindex - 1) * 4]);
                        line1 = Codes[(Showindex - 1) * 4];
                        for (int i = 0; i < 16 - results[0].Length - Codes[(Showindex - 1) * 4].Length; i++)
                        {
                            line1 += " ";
                        }
                        line1 += results[0];
                        line2 = "                ";
                        line3 = "                ";
                        line4 = "                ";
                        Showindex = 0;
                    }
                }

                byte[] Strbyte = Encoding.GetEncoding("utf-8").GetBytes(line1 + line2 + line3 + line4);
                _digiSpark.WriteBytes(Strbyte);
            }
        }
    }
}
