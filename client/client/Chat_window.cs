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
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }
        private String Client_name; //客户昵称
        private String Rec_IP;      //需要连接的服务器IP地址
        private String dataTimeNow; //当前系统的时间       

        private Socket socketClient;                //客户端用于和服务端连接的套接字
        private Thread ThreadClient;                //客户端监听服务端信息的进程

        private void Client_Load(object sender, EventArgs e)
        {
            Log_in Log = new Log_in();
            Log.ShowDialog();
            if (!Log.YoN_close())
            {
                this.Close();
                return;
            }
            Client_name = Log.ReturnNick();
            Rec_IP = Log.ReturnIP();
            IPAddress IP = System.Net.IPAddress.Parse(Rec_IP);            
            Client_na.Text = Client_name;
            int Port = 62455;
            IPEndPoint Point = new IPEndPoint(IP, Port);
            socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);     //创建套接字
            try
            {
                socketClient.Connect(Point);        //连接至服务器
                Byte[] NickMsg = Encoding.UTF8.GetBytes(Client_name);
                socketClient.Send(NickMsg);         //发送昵称信息
                MessageBox.Show("欢迎您，" + Client_name + "\r\n");
            }
            catch (Exception)
            {
                MessageBox.Show("！连接失败");
                this.Close();
            }
            ThreadClient = new Thread(Recv);        //创建接受通信的进程
            ThreadClient.IsBackground = true;
            ThreadClient.Start();
        }
        private void Recv()
        {
            while (true)
            {
                try
                {
                    byte[] arrRecvMsg = new byte[1024 * 1024];
                    int length = socketClient.Receive(arrRecvMsg);
                    String RecvMsg = Encoding.UTF8.GetString(arrRecvMsg, 0, length);
                    /*处理信息的三种方式*/
                    if (RecvMsg.Contains("aghiruleghuieg在线\r\n"))
                    {
                        RecvMsg = RecvMsg.Replace("aghiruleghuieg", "");
                        Connect_collect_text.Text = RecvMsg;
                    }
                    else if (RecvMsg.Contains("ahfkjebhgkuwkgj下线\r\n"))
                    {
                        RecvMsg = RecvMsg.Replace("ahfkjebhgkuwkgj", "");
                        Content_chat.AppendText(RecvMsg);
                        RecvMsg = RecvMsg.Replace("下线\r\n", "");
                        int count = System.DateTime.Now.ToString().Length;
                        RecvMsg = RecvMsg.Remove(0, count);
                        RecvMsg = RecvMsg.Replace("\r\n", "");
                        RecvMsg += "\r\n";
                        Connect_collect_text.Text = Connect_collect_text.Text.Replace(RecvMsg, "");                        ;
                    }
                    else
                    {                        
                        Content_chat.AppendText(RecvMsg);
                    }
                    
                }
                catch (Exception)       //当连接失败后，就说明服务器断开连接
                {
                    dataTimeNow = System.DateTime.Now.ToString();
                    Content_chat.AppendText(dataTimeNow + "\r\n" + "远程服务端已断开连接\r\n");
                    Connect_collect_text.Text = "远程服务端断开连接，无法获取在线列表";
                    break;
                }
            }

        }

        private void Send_message_Click(object sender, EventArgs e)
        {
            dataTimeNow = System.DateTime.Now.ToString();
            Content_chat.AppendText(dataTimeNow + "\r\n" + "你说: " + Message.Text + "\r\n");
            byte[] arrSendMsg = Encoding.UTF8.GetBytes(Message.Text);   
            socketClient.Send(arrSendMsg);      //发送信息
            Message.Clear();
            
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("退出成功！！！感谢您的使用！\r\n");
            this.Close();
        }
    }
}