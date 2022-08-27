using DotNet.Utilities;
using Newtonsoft.Json;
using SufeiNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp88
{
    class Program
    {
        static void Main(string[] args)
        {
            del();
            go();
            go2();
            post2();
        }

        public static string pua = @"GG/1.md";
        public static Dictionary<string, string> txtid;

        public static Dictionary<string, string> filedouyin()
        {
            Dictionary<string, string> dicc = new Dictionary<string, string>();
            if (!Directory.Exists("GG"))
            {
                Directory.CreateDirectory("GG");
            }
            if (!File.Exists(pua))
            {
                FileStream fs1 = new FileStream(pua, FileMode.Create, FileAccess.Write);
            }
            else
            {
                using (StreamReader sr = new StreamReader(pua))
                {
                    string line = sr.ReadLine();
                    while (line != null)
                    {
                        if (line != "")
                        {
                            string[] a = line.Split('|');
                            if (!dicc.ContainsKey(a[0]))
                            {
                                dicc.Add(a[0], a[1]);
                            }
                        }
                        line = sr.ReadLine();
                    }
                }
            }
            return dicc;
        }

        public static string  post()
        {
            Console.WriteLine("获取关键字");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = "https://raw.githubusercontent.com/wzz1190/ConsoleApp8/master/acc/"+ DateTime.Now.ToString("yyyyMMdd") + ".md";
            hi.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
            hi.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.0.0 Safari/537.36";
            return  hh.GetHtml(hi);
             
        }

        public static void go()
        {
            txtid = filedouyin();
            string html = post();
            if (html == "string error")
            {
                return;
            }
            string[] a = html.Split(new string[] { "\n\n" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in a)
            {
                string[] b = item.Split('|');
                if (!txtid.ContainsKey(b[0]))
                {
                    txtid.Add(b[0], "F");
                }
            }
        }

        public static void go2()
        {
            List<string> li = new List<string>();
            li.AddRange(txtid.Keys);
            foreach (var item in li)
            {
                if (txtid[item]=="F")
                {
                    txtid[item] = "T";
                    string posttxt = postdouyin(item);
                    if (posttxt == "string error")
                    {
                        continue;
                    }
                    Test tc = new Test();
                    tc= josnruku(posttxt, item);
                    if (tc!=null)
                    {
                        write(tc.name);
                        downAsync(tc.url).Wait();
                        break ;
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(pua, false))
            {
                foreach (var item in txtid)
                {
                    if (item.Value=="T")
                    {
                        sw.WriteLine(item.Key + "|" + "T");
                    }
                    
                }
            }


        }

        public static string postdouyin(string wordname)
        {
            Console.WriteLine("获取链接~");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = "https://aweme.snssdk.com/aweme/v1/hot/search/video/list/?hotword=" + wordname;
            hi.Allowautoredirect = true;
            hi.Accept = "application/json; charset=utf-8";
            hi.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.4951.67 Safari/537.36";
            return hh.GetHtml(hi);
        }

        public static Test josnruku(string josns , string wordnames)
        {
            SufeiNet_Test rb = JsonConvert.DeserializeObject<SufeiNet_Test>(josns);
            if (rb.aweme_list.Count != 0)
            {
                Test t2 = zhengli1(rb.aweme_list[0]);
                if (t2 != null)
                {
                    return t2;
                }
                else
                {
                    Console.WriteLine(wordnames + ":采集失败");
                    return null;
                }
            }
            else
            {
                Console.WriteLine(wordnames + ":没关键字");
                return null;
            }
        }

        public static Test zhengli1(AwemeList al)
        {
            Test t1 = new Test();
            if (al.video != null)
            {
                if (al.video.bit_rate.Count != 0)
                {
                    if (al.video.bit_rate[0].play_addr != null)
                    {
                        if (al.video.bit_rate[0].play_addr.url_list.Count != 0)
                        {
                            t1.url = al.video.bit_rate[0].play_addr.url_list[0];
                        }
                    }
                }
            }
            if (al.desc != null)
            {
                t1.name = nametxt(al.desc);
            }
            if (al.aweme_id != null)
            {
                t1.ID = al.aweme_id;
            }

            if (t1.ID != null && t1.name != null && t1.url != null)
            {
                return t1;
            }
            else
            {
                return null;
            }
        }

        public static string nametxt(string txt)
        {
            Regex zhonwen = new Regex(@"[\u4e00-\u9fa5]");
            Regex da = new Regex(@"[\u0041-\u007a]");
            Regex shu = new Regex(@"[\u0030-\u0039]");
            string acd = "";
            foreach (var item in txt)
            {
                if (item == 32)
                {
                    acd += item;
                }
                else
                if (item == 35)
                {
                    acd += item;
                }
                else
                if (zhonwen.IsMatch(item.ToString()))
                {
                    acd += item;
                }
                else
                if (da.IsMatch(item.ToString()))
                {
                    acd += item;
                }
                else
                if (shu.IsMatch(item.ToString()))
                {
                    acd += item;
                }
                else
                {
                    acd += " ";
                }


            }
            return acd;

        }

        public static void write(string txts)
        {
            Console.WriteLine("写入标题");
            string lu = "GG/void";
            if (!Directory.Exists(lu))
            {
                Directory.CreateDirectory(lu);
            }

                using (StreamWriter sw = new StreamWriter("GG/void/txt.md", false))
                {
                    sw.WriteLine(txts);

                }
        }

        public static async Task downAsync(string urls)
        {
            var url = urls;
            var save = "GG/void/lula.mp4";
            if (!File.Exists(save))
            {
                Console.WriteLine("文件不存在，开始下载...");
                //先下载到临时文件
                var tmp = save + ".tmp";
                using (var web = new WebClient())
                {
                    await web.DownloadFileTaskAsync(url, tmp);
                }
                File.Move(tmp, save, true);
                Console.WriteLine("文件下载成功");
            }
            Console.WriteLine("开始处理文件");


        }

        public static void del()
        {
            Console.WriteLine("删除文件");
            if (Directory.Exists("GG/void"))
            {
                DirectoryInfo di = new DirectoryInfo("GG/void");
                di.Delete(true);
            }

        }

        public static void post2()
        {
            Console.WriteLine("ye指令");
            HttpHelper hh = new HttpHelper();
            HttpItem hi = new HttpItem();
            hi.URL = "https://eob4vzrz7a48fik.m.pipedream.net";
            hi.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/avif,image/webp,image/apng,*/*;q=0.8,application/signed-exchange;v=b3;q=0.9";
            hi.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/101.0.0.0 Safari/537.36";
            hh.GetHtml(hi);

        }
    }

    public class Test

    {

        public string ID { get; set; }

        public string name { get; set; }

        public string url { get; set; }

    }
}
