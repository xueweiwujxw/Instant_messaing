using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.Net.NetworkInformation;

namespace server
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
                
        private String dataTimeNow;                          //当前的系统时间
        
        private void Server_Load(object sender, EventArgs e)
        {

        }

        private IPAddress GetIp()
        {
            String Hostname = Dns.GetHostName();        //获取主机名称
            IPAddress[] ips = Dns.GetHostAddresses(Hostname);   //通过主机名称获得IP列表
            IPAddress returnIP = IPAddress.Parse("127.0.0.1");  //默认IP为127.0.0.1，防止找不到合适的IP地址
            foreach (IPAddress ip in ips)               //遍历获得的所有的IP地址，找出其中符合条件的IPV4的IP地址
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    returnIP = ip;
            }
            return returnIP;

        }
      
        private Dictionary<String, Socket> ClientConnection = new Dictionary<string, Socket>();
        private Dictionary<String, String> ClinetNick = new Dictionary<string, string>();
        private Socket SocketWatch = null;
        private Socket SocketConnection;
        private Thread threadWatch;
        private bool Enable = true;

        private void Start_Click(object sender, EventArgs e)
        {
            if (Enable)
            {
                Enable = false;
                dataTimeNow = System.DateTime.Now.ToString();
                Connection.AppendText(dataTimeNow + "服务开启\r\n" + "等待连接...\r\n");
                /*开始建立套接字*/
                /*IPV4寻址，流式连接，TCP协议*/
                SocketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                /*获取本机IP*/
                IPAddress Ip = GetIp();         //获取本机IP地址
                IPEndPoint Point = new IPEndPoint(Ip, 62455);      //获取可用网口
                SocketWatch.Bind(Point);        //绑定网口
                SocketWatch.Listen(20);         //设置监听列表

                threadWatch = new Thread(WatchConnect);          //创建监听的进程
                threadWatch.IsBackground = true;
                threadWatch.Start();
                dataTimeNow = System.DateTime.Now.ToString();       //获取当前时间
                Connection.AppendText(dataTimeNow + "\r\n" + Point.ToString() + "正在监听...\r\n");
            }
            
        }   

        //监听客户端的请求
        private void WatchConnect()
        {
            //SocketConnection = null;
            while (true)
            {
                try
                {
                    SocketConnection = SocketWatch.Accept();        //接受来自客户端的连接
                    

                }
                catch (Exception)
                {
                    //MessageBox.Show(ex.Message);
                    return;
                }
                byte[] arrNickMsg = new byte[1024];
                int length = SocketConnection.Receive(arrNickMsg);
                String NickMsg = Encoding.UTF8.GetString(arrNickMsg, 0, length);        //客户端的昵称
                String remoteEndPoint = SocketConnection.RemoteEndPoint.ToString();     //客户端的网口信息
                ClientConnection.Add(remoteEndPoint, SocketConnection);                 //添加连接信息
                ClinetNick.Add(remoteEndPoint, NickMsg);
                ClinetNick.TryGetValue(SocketConnection.RemoteEndPoint.ToString(), out string nickName);
                dataTimeNow = System.DateTime.Now.ToString();
                Connection.AppendText("\r\n" + dataTimeNow + "\r\n" + "客户端：" + remoteEndPoint + ": " + nickName + "连接成功，客户端总数：" + ClientConnection.Count() + "\r\n"); //连接状态信息
                IPAddress clientIP = (SocketConnection.RemoteEndPoint as IPEndPoint).Address;       //客户端IP
                int clientPort = (SocketConnection.RemoteEndPoint as IPEndPoint).Port;              //客户端端口                              

                //发送在线情况
                
                if (ClientConnection.Count > 0)
                {
                    foreach (var clientN in ClientConnection)
                    {
                        String Online = "aghiruleghuieg在线\r\n";     //乱码标识信息种类
                        if (ClinetNick.Count > 0)
                        {
                            foreach (var client in ClinetNick)
                            {
                                Online += client.Value + "\r\n";
                            }
                        }
                        byte[] arrOnline = Encoding.UTF8.GetBytes(Online);
                        clientN.Value.Send(arrOnline);
                    }

                }
                Thread threadMess = new Thread(Recv)
                {
                    IsBackground = true
                };       //建立新的通信进程
                threadMess.Start(SocketConnection);

            }
        }

        private void Recv(object socketClientPara)
        {
            Socket socketServer = socketClientPara as Socket;       //建立接收客户端信息的套接字
            while (true)
            {
                byte[] arrServerMsg = new byte[1024 * 1024];        //用于存储客户端信息的比特数组
                try
                {
                    int length = socketServer.Receive(arrServerMsg);    //获取客户端发送信息的长度
                    String recMsg = Encoding.UTF8.GetString(arrServerMsg, 0, length);   //转化为string
                    dataTimeNow = System.DateTime.Now.ToString();       //获取当前时间
                    if (ClientConnection.Count > 0) 
                    {
                        foreach (var clientTemp in ClientConnection)    //向所有的客户端发送信息，除去消息来源的客户端
                        {
                            if (clientTemp.Value.RemoteEndPoint == socketServer.RemoteEndPoint)
                                continue;
                            ClinetNick.TryGetValue(socketServer.RemoteEndPoint.ToString(), out string nickTemp);
                            clientTemp.Value.Send(Encoding.UTF8.GetBytes(dataTimeNow + "\r\n" + nickTemp + "说：" + recMsg + "\r\n"));
                        }
                    }
                }
                catch(Exception)        //连接失败，说明客户端下线了
                {
                    ClientConnection.Remove(socketServer.RemoteEndPoint.ToString());
                    ClinetNick.TryGetValue(socketServer.RemoteEndPoint.ToString(), out string nickName);
                    dataTimeNow = System.DateTime.Now.ToString();
                    Connection.AppendText("\r\n" + dataTimeNow + "\r\n" + "客户端：" + socketServer.RemoteEndPoint + ": " + nickName + "断开连接，客户端总数：" + ClientConnection.Count() + "\r\n");
                    dataTimeNow = System.DateTime.Now.ToString();       //获取当前时间
                    if (ClientConnection.Count > 0)
                    {
                        foreach (var clientTemp in ClientConnection)    //向所有的客户端发送信息，除去消息来源的客户端
                        {
                            if (clientTemp.Value.RemoteEndPoint == socketServer.RemoteEndPoint)
                                continue;
                            ClinetNick.TryGetValue(socketServer.RemoteEndPoint.ToString(), out string nickTemp);
                            clientTemp.Value.Send(Encoding.UTF8.GetBytes(dataTimeNow + "\r\n" + nickTemp + "ahfkjebhgkuwkgj下线\r\n"));
                        }
                    }
                    ClinetNick.Remove(socketServer.RemoteEndPoint.ToString());
                    socketServer.Close();
                    break;
                }
            }
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            
            if (SocketWatch != null)
            {
                Connection.AppendText("注销连接中...\r\n");
                SocketWatch.Close();
                MessageBox.Show("注销成功！！！感谢您的使用\r\n");
                Enable = true;
            }
            this.Close();
        }
    }
}
