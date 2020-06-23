using LibUsbDotNet;
using LibUsbDotNet.DeviceNotify;
using LibUsbDotNet.Main;
using System.Text;

namespace StockInfo
{
    public static class Digistump
    {
        const int DIGISPARKVID = 0x16c0;  //产品ID
        const int DIGISPARKPID = 0x05df;  //供应商ID
        private static UsbDevice usbDevice = null;
        public static UsbEndpointWriter writer = null;
        public static UsbEndpointReader reader = null;

        public static bool FindAndOpenUSB()
        {
            UsbRegDeviceList allDevices = UsbDevice.AllDevices;
            foreach (UsbRegistry usbRegistry in allDevices)
            {
                if (usbRegistry.Open(out usbDevice))
                {
                    if (usbDevice.Info.Descriptor.VendorID == DIGISPARKVID && usbDevice.Info.Descriptor.ProductID == DIGISPARKPID)
                    {
                        writer = usbDevice.OpenEndpointWriter(WriteEndpointID.Ep01);
                        return true;
                    }
                    usbDevice.Close();
                }
            }
            return false;
        }
        //关闭USB设备
        public static void CloseUSB()
        {
            if (usbDevice is object)
                usbDevice.Close();
        }

        public static void SendData()
        {
            ErrorCode ec = ErrorCode.None;

            int bytesWritten;
            try
            {
                ec = writer.Write(Encoding.Default.GetBytes("3243242"), 2000, out bytesWritten);
                if (ec != ErrorCode.None)
                {
                }
            }
            catch (System.Exception ex)
            {

            }
            finally
            {

            }
        }
        private static bool WriteByte(byte value)
        {


            var packet = new UsbSetupPacket(
                (byte)(UsbCtrlFlags.RequestType_Class | UsbCtrlFlags.Recipient_Device | UsbCtrlFlags.Direction_Out),
                0x09, // USBRQ_HID_SET_REPORT 
                0x300, // (USB_HID_REPORT_TYPE_FEATURE << 8) | 0,
                value, // the byte to write
                0); // according to usbdevice.py this is ignored, so passing in 0

            int numBytesTransferred;

            return usbDevice.ControlTransfer(ref packet, null, 0, out numBytesTransferred);
        }
        private static bool WriteBytes(byte[] values)
        {
            bool result = true;
            foreach (byte value in values)
            {
                result &= WriteByte(value);
            }
            return result;
        }

        public static void WriteString(string Str)
        {
            byte[] Strbyte = Encoding.GetEncoding("utf-8").GetBytes(Str);
            WriteBytes(Strbyte);
        }
    }
}
