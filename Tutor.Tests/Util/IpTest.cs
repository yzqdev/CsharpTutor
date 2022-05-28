using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Tutor.Tests.Util {
    internal class IpTest {
        [Test]
        /// <summary>
        /// 扫描局域网IP地址
        /// </summary>
        public void StartScan() { 
            string strScanIP = "192.168.0.103";
            //扫描的操作
            IPAddress myScanIP = IPAddress.Parse(strScanIP);
            //址获取DNS主机信息
            IPHostEntry myScanHost = Dns.GetHostEntry(myScanIP);
            //获取主机名
            string strHostName = myScanHost.HostName.ToString();
            Console.WriteLine(strHostName);
        }
        [Test]
        public void getIps() {
          

                //获取本地机器名 
                string _myHostName = Dns.GetHostName();
                //获取本机IP 
                string _myHostIP = Dns.GetHostEntry(Dns.GetHostName()).AddressList.FirstOrDefault<IPAddress>(a => a.AddressFamily.ToString().Equals("InterNetwork")).ToString();
                //MessageBox.Show(_myHostIP);
                //截取IP网段
                string ipDuan = _myHostIP.Remove(_myHostIP.LastIndexOf('.'));
                //MessageBox.Show(ipDuan);
                //枚举网段计算机
                Ping myPing = new Ping();
             List<string> ipList=new List<string>();
            string label3 = "";
                string data = "";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                for (int i = 1; i <= 255; i++) {
                    string pingIP = ipDuan + "." + i.ToString();
                    PingReply pingReply = myPing.Send(pingIP, 120, buffer);
                    if (pingReply.Status == IPStatus.Success) {
                        ipList.Add(pingIP);
                        label3 = "答复的主机地址：" + pingReply.Address.ToString() + "\n";
                        label3 += "往返时间：" + pingReply.RoundtripTime.ToString() + "\n";
                        label3 += "生存时间：" + pingReply.Options.Ttl.ToString() + "\n";
                        label3 += "是否控制数据包的分段：" + pingReply.Options.DontFragment.ToString() + "\n";
                        label3 += "缓冲区大小：" + pingReply.Buffer.Length.ToString() + "\n";
                       
                    } else {
                        label3  = pingIP + "不在线";
                       
                    }

                }
                Console.WriteLine(label3);
            
        }
    }
}
