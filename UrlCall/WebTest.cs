using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrlCall
{
    class WebTest
    {

        public static string getWebContent(string url)
        {
            WebClient client = new WebClient();
            string downloadString = client.DownloadString(url);

            client.Dispose();
            return downloadString;
        }

        public static void getWebContent(string url, int times)
        {

            for (int i = 0; i < times; i++)
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString(url);

                client.Dispose();
                Logging.writeLog("<!--" + i.ToString() + "-->");
                Logging.writeLog(downloadString);
                Logging.writeLog("<!--End---" + i.ToString() + "-->");
                Thread.Sleep(100);
            }
            Application.Exit();
        }


    }
}
