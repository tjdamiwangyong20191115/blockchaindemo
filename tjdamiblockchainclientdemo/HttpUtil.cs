using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Net;
using System.Threading;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;
using System.Collections.Specialized;
using Newtonsoft.Json;

namespace tjdamiblockchainclientdemo
{
    public class HttpUtil
    {
        public static Stream FileToStream(string fileName)
        {
            // 打开文件
            FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            // 读取文件的 byte[]
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, bytes.Length);
            fileStream.Close();
            // 把 byte[] 转换成 Stream
            Stream stream = new MemoryStream(bytes);
            return stream;
        }

        public static string Upload(string url, string fileName)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            Stream postStream = new MemoryStream();
            #region 处理Form表单文件上传
            //通过表单上传文件
            string boundary = "----" + DateTime.Now.Ticks.ToString("x");
            string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
 
 
            try
            {
                //准备文件流
                using (var fileStream = FileToStream(fileName))
                {
                    var formdata = string.Format(formdataTemplate, "file", System.IO.Path.GetFileName(fileName) /*Path.GetFileName(fileName)*/);
                    var formdataBytes = Encoding.UTF8.GetBytes(postStream.Length == 0 ? formdata.Substring(2, formdata.Length - 2) : formdata);//第一行不需要换行
                    postStream.Write(formdataBytes, 0, formdataBytes.Length);
 
                    //写入文件
                    byte[] buffer = new byte[1024];
                    int bytesRead = 0;
                    while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        postStream.Write(buffer, 0, bytesRead);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
 
            //结尾
            var footer = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
            postStream.Write(footer, 0, footer.Length);
            request.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
 
            #endregion
 
            request.ContentLength = postStream != null ? postStream.Length : 0;
            request.Accept = "*/*";
            //request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.KeepAlive = true;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
 
            #region 输入二进制流
            if (postStream != null)
            {
                postStream.Position = 0;

                //直接写入流
                Stream requestStream = request.GetRequestStream();
 
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                while ((bytesRead = postStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    requestStream.Write(buffer, 0, bytesRead);
                }
 
                postStream.Close();//关闭文件访问
            }
            #endregion
 
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
 
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(responseStream,Encoding.GetEncoding("utf-8")))
                {
                    string retString = myStreamReader.ReadToEnd();
                    return retString;
                }
            }
        }
 
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true; 
        }

        static public string HttpPost(string Url, string postDataStr, string strContentType)
        {

            string retString = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);

                if (Url.ToLower().StartsWith("https", StringComparison.OrdinalIgnoreCase))
                {
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
                    //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
                    request = WebRequest.Create(Url) as HttpWebRequest;
                    request.ProtocolVersion = HttpVersion.Version10;
                }
                else
                {
                    request = WebRequest.Create(Url) as HttpWebRequest;
                }

                request.Timeout = 3000;

                request.Method = "POST";

                if (strContentType.Equals(""))
                {
                    request.ContentType = "application/json;charset=UTF-8";
                }
                else
                {
                    request.ContentType = strContentType;
                }

                request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";
 
                string strtmp = DefaultToUTF8(postDataStr);
               
                Stream myRequestStream = request.GetRequestStream();
                
                myRequestStream.ReadTimeout = 3000;
               
                StreamWriter myStreamWriter = new StreamWriter(myRequestStream, Encoding.UTF8);
                myStreamWriter.Write(strtmp);               
                myStreamWriter.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                Stream myResponseStream = response.GetResponseStream();

                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));

                retString = myStreamReader.ReadToEnd();

                myStreamReader.Close();

                myResponseStream.Close();

                WriteLogs("log", "info", "Response--------" + Environment.NewLine + retString + Environment.NewLine);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            return retString;
        }

        public static void SetHeaderValue(WebHeaderCollection header, string name, string value)
        {
            var property = typeof(WebHeaderCollection).GetProperty("InnerCollection",
            System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            if (property != null)
            {
                var collection = property.GetValue(header, null) as NameValueCollection;
                collection[name] = value;
            }
        }

        static public string DefaultToUTF8(string str)
        {
            try
            {
                Encoding utf8 = Encoding.GetEncoding(65001);
                Encoding defaulte = Encoding.Default;
                byte[] temp = defaulte.GetBytes(str);
                byte[] temp1 = Encoding.Convert(defaulte, utf8, temp);
                string result = utf8.GetString(temp1);
                return result;
            }
            catch (Exception ex)//(UnsupportedEncodingException ex)
            {
                return str;
            }
        }
        
        static ReaderWriterLock LogWriteLock = new ReaderWriterLock();

        public static void WriteLogs(string fileName, string type, string content)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            if (!string.IsNullOrEmpty(path))
            {
                path = AppDomain.CurrentDomain.BaseDirectory + fileName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyyMMdd");
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                path = path + "\\" + DateTime.Now.ToString("yyyyMMdd") + ".txt";
                if (!File.Exists(path))
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                }
                if (File.Exists(path))
                {
                    try
                    {
                        LogWriteLock.AcquireWriterLock(1000);
                        StreamWriter sw = new StreamWriter(path, true, System.Text.Encoding.Default);
                        sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff") + type + "-->" + content);
                        sw.Close();
                    }
                    catch (Exception ex)
                    {                        
                    }
                    finally
                    {
                        LogWriteLock.ReleaseLock();
                    }
                }
            }
        }

        static public string ConvertJsonString(string str)
        {
            try
            {
                //格式化json字符串
                JsonSerializer serializer = new JsonSerializer();
                TextReader tr = new StringReader(str);
                JsonTextReader jtr = new JsonTextReader(tr);
                object obj = serializer.Deserialize(jtr);
                if (obj != null)
                {
                    StringWriter textWriter = new StringWriter();
                    JsonTextWriter jsonWriter = new JsonTextWriter(textWriter)
                    {
                        Formatting = Formatting.Indented,
                        Indentation = 4,
                        IndentChar = ' '
                    };
                    serializer.Serialize(jsonWriter, obj);
                    return textWriter.ToString();
                }
                else
                {
                    return str;
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return "";
        }
    }
}
