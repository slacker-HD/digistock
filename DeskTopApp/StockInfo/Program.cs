using System;
using System.Windows.Forms;

namespace StockInfo
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out bool ret);
            Frm_Setting frm  = null;
            ArduinoUsbDevice digiSpark = new ArduinoUsbDevice();
            digiSpark.ArduinoUsbDeviceChangeNotifier += digiSpark_ArduinoUsbDeviceChangeNotifier;

           if (ret)
            {
                frm = new Frm_Setting(digiSpark);
                frm.ShowTooltip(digiSpark.IsAvailable);
                Application.Run(frm);
                mutex.ReleaseMutex();
            }
            else
            {
                MessageBox.Show(null, "程序已运行。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }

            void digiSpark_ArduinoUsbDeviceChangeNotifier(object sender, EventArgs e)
            {
                Console.WriteLine("Device status changed: {0}", sender);
                frm.ShowTooltip(sender);
            }
        }
    }
}
