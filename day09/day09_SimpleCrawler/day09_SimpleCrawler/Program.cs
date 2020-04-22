using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace day09_SimpleCrawler
{
    /**
     *  （1）只爬取起始网站上的网页 
     *  （2）只有当爬取的是html文本时，才解析并爬取下一级URL。
     *  （3）相对地址转成绝对地址进行爬取。
     *  （4）尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。
     */
    class SimpleCrawler
    {
        private Hashtable urls = new Hashtable();
        private int count = 0;
        public static string startUrl = "https://www.cnblogs.com/dstang2000/";
        static void Main(string[] args)
        {
            SimpleCrawler myCrawler = new SimpleCrawler();
           
            if (args.Length >= 1) startUrl = args[0];
            myCrawler.urls.Add(startUrl, false);//加入初始页面
            new Thread(myCrawler.Crawl).Start();
        }

        private void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null ||count>10) break;
                Console.WriteLine("爬行" + current + "页面!");
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                bool match = Regex.IsMatch(html, "<a.*>(.*)</a>");
                string fileName = count.ToString();
               if (match){
                    File.WriteAllText(fileName, html, Encoding.UTF8);
                    return html;
                }
                else
                {
                    return "";
                }

                /**
               WebClient wc = new WebClient();
               wc.Encoding = Encoding.UTF8;
               //以字符串的形式返回数据
               string html = wc.DownloadString(url);

               //以正则表达式的形式匹配到字符串网页中想要的数据
               MatchCollection matches = Regex.Matches(html, "<a.*>(.*)</a>");
               //依次取得匹配到的数据
               foreach (Match item in matches)
                  return item.Groups[1].Value;
             */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        private void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+(.htm|.html)[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
              //  if (strRef.Contains(startUrl) && (strRef.Contains(".html")))
             
                    if (urls[strRef] == null)
                      urls[strRef] = false;
        
             
            }
        }
    }
}


