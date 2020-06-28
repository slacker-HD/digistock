using System;
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

        private static string GetStockInfo(string Stockcodes)
        {
            string[] Codes = Stockcodes.Split(',');
            string strURL = "http://hq.sinajs.cn/list=";
            foreach (string code in Codes)
            {
                string market = code.Substring(0, 1) == "6" ? "sh" : "sz";
                strURL += market + code + ",";
            }
            if (strURL.Length > 25)
            {
                strURL = strURL.Substring(0, strURL.Length - 1);
            }
            return StockInfoFromUrl(strURL);
        }

        public static string[] Getvalue(string Stockcodes)
        {
            string[] Resultstrings = GetStockInfo(Stockcodes).Split(';');
            {
                for (int i = 0; i < Resultstrings.Length - 1; i++)
                {
                    Resultstrings[i] = GetIndex(Resultstrings[i], 3);
                }
            }
            return Resultstrings;
        }


        public static string[] GetFirstScreenvalue()
        {
            string[] Resultstrings = StockInfoFromUrl("http://hq.sinajs.cn/list=s_sh000001,s_sz399001,sh000300").Split(';');
            Resultstrings[0] = GetIndex(Resultstrings[0], 1);
            Resultstrings[1] = GetIndex(Resultstrings[1], 1);
            Resultstrings[2] = GetIndex(Resultstrings[2], 3);
            return Resultstrings;
        }



        private static string GetIndex(string ReqJson, int Index)
        {
            if (ReqJson.Length < 60)
            {
                return "???";
            }
            else
            {
                var str = ReqJson.Split(',');
                if (str.Length > 3)
                {
                    return Convert.ToDecimal(str[Index]).ToString("0.00");
                }
                else
                    return "???";
            }
        }
    }
}
