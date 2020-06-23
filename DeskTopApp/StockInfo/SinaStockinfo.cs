using System.IO;
using System.Net;
using System.Text;

namespace StockInfo
{
    public static class SinaStockinfo
    {

        private static string StockInfoFromUrl(string StrinUrl)
        {
            WebRequest request;
            WebResponse response;
            try
            {
                request = WebRequest.Create(StrinUrl);
                response = request.GetResponse();
                StreamReader myreader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("GBK"));
                string responseText = myreader.ReadToEnd();
                myreader.Close();
                return responseText;
            }
            catch
            {
                return "";
            }
        }
        public static string GetStockInfo(string stockcode)
        {
            string market = stockcode.Substring(0, 1) == "6" ? "sh" : "sz";
            string strURL = "http://hq.sinajs.cn/list=" + market + stockcode;
            return StockInfoFromUrl(strURL);
        }
        public static string Shangzheng()
        {
            return StockInfoFromUrl("http://hq.sinajs.cn/list=s_sh000001");
        }
        public static string Shenzheng()
        {
            return StockInfoFromUrl("http://hq.sinajs.cn/list=s_sz399001");
        }

        public static string HuShen300()
        {
            return StockInfoFromUrl("http://hq.sinajs.cn/list=sh000300");
        }
        

    }
}
