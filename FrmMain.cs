using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.IO;
namespace 重点用能数据上传
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            C_uploadEnergy c1 = new C_uploadEnergy();
            c1.deviceid = "e464c98e84850eb7ceadb94725879eb8";
            c1.enterpriseCode = "91120116MA0799365G";
            c1.data = new List<energyData>();
            using (energyDbDataContext db = new energyDbDataContext())
            {
                foreach (energyData eD in db.energyData)
                {
                    c1.data.Add(eD);
                }
            }


            string s = JsonConvert.SerializeObject(c1);
            t_post.Text = s;
            string url = "https://125.38.47.138:1444/uploadEnergyData";
            string respond;

            try
            {
                //respond = PostUrl(url, s);    //此版本的子程序通过测试
                //respond = HttpUitls.Post(url, s, "");  //此版本的子程序测试成功
                respond = Utilities.Post(url, s);
                t_respond.Text = respond;
            }
            catch (Exception ex)
            {
                t_respond.Text = ex.Message;
                return;
                //throw;
            }
        }

        private static string PostUrl(string url, string postData)
        {
            HttpWebRequest request = null;
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                request = WebRequest.Create(url) as HttpWebRequest;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                request.ProtocolVersion = HttpVersion.Version11;
                // 这里设置了协议类型。
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;// SecurityProtocolType.Tls1.2; 
                request.KeepAlive = false;
                ServicePointManager.CheckCertificateRevocationList = true;
                ServicePointManager.DefaultConnectionLimit = 100;
                ServicePointManager.Expect100Continue = false;
            }
            else
            {
                request = (HttpWebRequest)WebRequest.Create(url);
            }

            request.Method = "POST";    
            request.ContentType = "application/json";
            request.Accept = "application/json";
            //request.Referer = null;
            //request.AllowAutoRedirect = true;
            //request.UserAgent = "Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 5.2; .NET CLR 1.1.4322; .NET CLR 2.0.50727)";
            //request.Accept = "*/*";
            



            byte[] data = Encoding.UTF8.GetBytes(postData);
            Stream newStream = request.GetRequestStream();
            newStream.Write(data, 0, data.Length);
            newStream.Close();

            //获取网页响应结果
            
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            response.Headers.Add("Content-Type", "application/json");
            Stream stream = response.GetResponseStream();

            //client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            string result = string.Empty;
            using (StreamReader sr = new StreamReader(stream))
            {
                result = sr.ReadToEnd();
            }

            return result;
        }

        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; //总是接受  
        }

    
    }
}
