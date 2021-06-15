using MyControlLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//www.srcfans.com
namespace WindowsFormsApplication1
{
    class JokeDataAdapter
    {
        const string qsbkMainUrl = "http://www.qiushibaike.com";


        /// <summary>
        /// 获取笑话列表
        /// </summary>
        /// <param name="htmlContent"></param>
        public static  List<JokeItem> GetJokeList(int pageIndex)
        {
            string htmlContent=GetUrlContent(GetWBJokeUrl(pageIndex));
            List<JokeItem> jokeList = new List<JokeItem>();
            Regex rg = new Regex(@"<img src=""([^""]*"")\s*alt=""([^""]*)""/>\s</a>\s<a href=""([^""]*)""[^>]*>\s<h2>[^>]*>\s</a>\s</div>\s*<div class=""content"">\s*((.*|<br/>)*)", RegexOptions.IgnoreCase);
            JokeItem joke;
            MatchCollection matchResults = rg.Matches(htmlContent);

            foreach (Match result in matchResults)
            {
                joke = new JokeItem();
                joke.HeadImage = GetWebImage(result.Groups[1].Value);
                joke.HeadImage = joke.HeadImage != null ? new Bitmap(GetWebImage(result.Groups[1].Value), 50, 50) : null;
                joke.NickName = result.Groups[2].Value;
                joke.JokeUrl = qsbkMainUrl + "/" + result.Groups[3].Value; ;
                joke.JokeContent = result.Groups[4].Value.Replace("<br/>", "\r\n").Replace("<br>", "\r\n");
                joke.JokeContent = Regex.Replace(joke.JokeContent, @"(\r\n)+", "\r\n");//去掉多余的空行
                jokeList.Add(joke);
            }
            //匹配匿名用户
            rg = new Regex(@"<h2>匿名用户</h2>\s*</span>\s*</div>\s*<div class=""content"">\s*(.*)", RegexOptions.IgnoreCase);
            matchResults = rg.Matches(htmlContent);

            foreach (Match result in matchResults)
            {
                joke = new JokeItem();
                joke.HeadImage = null;
                joke.NickName = "匿名用户";
                joke.JokeContent = result.Groups[1].Value.Replace("<br/>", "\r\n").Replace("<br>", "\r\n");
                joke.JokeContent = Regex.Replace(joke.JokeContent, @"(\r\n)+", "\r\n");//去掉多余的空行
                jokeList.Add(joke);
            }
            return jokeList;
        }

        /// <summary>
        /// 根据糗事百科笑话页面索引获取笑话页的html源码
        /// </summary>
        /// <param name="pageIndex">页面索引</param>
        /// <returns></returns>
        private static string GetWBJokeUrl(int pageIndex)
        {
            StringBuilder url = new StringBuilder();
            url.Append(qsbkMainUrl);
            url.Append ("/textnew/page/");
            url.Append(pageIndex.ToString ());
            url.Append("/?s=4869039");
            return url.ToString();
        }
        /// <summary>
        /// 根据网页的url获取网页的html源码
        /// </summary>
        /// <param name="url">网页链接</param>
        /// <returns></returns>
        private static string  GetUrlContent(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Maxthon/4.4.8.1000 Chrome/30.0.1599.101 Safari/537.36";
                request.Method = "GET";
                request.ContentType = "text/html;charset=UTF-8";
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                Stream myResponseStream = response.GetResponseStream();
                StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
                string retString = myStreamReader.ReadToEnd();
                myStreamReader.Close();
                myResponseStream.Close();
                return retString;
            }
            catch { return null; }
        }

        private static Image GetWebImage(string webUrl)
        {
            try
            {
                Encoding encode = Encoding.GetEncoding("utf-8");//网页编码==Encoding.UTF8  
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(new Uri(webUrl));
                HttpWebResponse ress = (HttpWebResponse)req.GetResponse();
                Stream sstreamRes = ress.GetResponseStream();
                return System.Drawing.Image.FromStream(sstreamRes); 
            }
            catch { return null; }
        }

    }
}
