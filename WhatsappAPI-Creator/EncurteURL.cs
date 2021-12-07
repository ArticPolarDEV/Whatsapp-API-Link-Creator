using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappAPI_Creator
{
    public static class EncurteURL
    {
        public static string EncurtadorUrl(string url)
        {
            try
            {
                string urlMigreMe = string.Format("http://tinyurl.com/api-create.php?url={0}", url);

                var client = new WebClient();

                string response = client.DownloadString(urlMigreMe);

                client.Dispose();

                return response;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        public static string EncurtadorUrl(Uri url)
        {
            return EncurtadorUrl(url.AbsoluteUri);
        }
    }
}
