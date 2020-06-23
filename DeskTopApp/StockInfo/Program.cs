using System;
using System.Windows.Forms;

namespace StockInfo
{
    static class Program
    {
        //        public static UsbDevice MyUsbDevice;
        //        //设置USB的Vendor Product ID
        //        public static UsbDeviceFinder MyUsbFinder = new UsbDeviceFinder(5840, 1875);

        //         //0x16c0;  //产品ID
        //////        const int DIGISPARKPID = 0x05df;  //供应商ID

        //        static void Main(string[] args)
        //        {
        //            //保存异常数据
        //            ErrorCode ec = ErrorCode.None;
        //            try
        //            {
        //                //找到并打开USB设备
        //                MyUsbDevice = UsbDevice.OpenUsbDevice(MyUsbFinder);

        //                if (MyUsbDevice == null)
        //                {
        //                    throw new Exception("Device Not Found");
        //                }
        //                //如果设备打开and ready

        //                //libusb-win32是"whole"USB device，为IUsbDevice interface,不是（WinUSB）,则变量
        //                //wholeUSBDevice变量为null，是device interface,不需要configuration 和 interface
        //                //as is 判断两个变量是否相等，is 返回TRUE/FALSE; as 相同返回结果，不同返回null
        //                IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
        //                if (!ReferenceEquals(wholeUsbDevice, null))
        //                {
        //                    //这是个"whole"USB device,使用前选择configuration interface
        //                    //选中配置1
        //                    wholeUsbDevice.SetConfiguration(1);
        //                    wholeUsbDevice.ClaimInterface(0);

        //                }

        //                //打开并读取read endpoint1
        //                UsbEndpointReader reader = MyUsbDevice.OpenEndpointReader(ReadEndpointID.Ep01);

        //                byte[] readBuffer = new byte[1024];
        //                //如果5秒内设备没有发生数据，发生timeout error(ec=IoTimedOut)
        //                while (ec == ErrorCode.None) //一直在读取
        //                {
        //                    int bytesRead;
        //                    ec = reader.Read(readBuffer, 10000, out bytesRead);

        //                    if (bytesRead == 0) throw new Exception(string.Format("{0}:No more bytes", ec));
        //                    Console.WriteLine("{0} bytes read", bytesRead);

        //                    //将结果输出到控制台上
        //                    Console.Write(Encoding.Default.GetString(readBuffer, 0, bytesRead));
        //                }
        //                Console.WriteLine("\r\n Done! \r\n");
        //            }
        //            catch (System.Exception ex)
        //            {
        //                Console.WriteLine();
        //                Console.WriteLine((ec != ErrorCode.None ? ec + ":" : string.Empty) + ex.Message);
        //            }
        //            //读取数据后执行
        //            finally
        //            {
        //                if (MyUsbDevice != null)
        //                {
        //                    if (MyUsbDevice.IsOpen)
        //                    {
        //                        IUsbDevice wholeUsbDevice = MyUsbDevice as IUsbDevice;
        //                        if (!ReferenceEquals(wholeUsbDevice, null))
        //                        {
        //                            //释放interface 0
        //                            wholeUsbDevice.ReleaseInterface(0);
        //                        }
        //                        MyUsbDevice.Close();
        //                    }
        //                    MyUsbDevice = null;
        //                    //释放usb资源
        //                    UsbDevice.Exit();
        //                }

        //                Console.ReadKey();
        //            }
        //        }
        //    }


        [STAThread]
        static void Main()
        {
            System.Threading.Mutex mutex = new System.Threading.Mutex(true, Application.ProductName, out bool ret);
            if (ret)
            {
                if (Digistump.FindAndOpenUSB())
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Frm_Setting());
                    mutex.ReleaseMutex();
                }
                else
                {
                    MessageBox.Show(null, "未发现设备，程序将退出。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show(null, "程序已运行。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }
        }
    }
}
