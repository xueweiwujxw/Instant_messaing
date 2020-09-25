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

namespace client
{
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    
        private String NickName = "";             //用户的昵称，用来标记不同的用户，在数据报中还是使用IP地址来识别用户
        private String SenIPaddress = "";         //需要连接的服务器

        private void Log_in_btn_Click(object sender, EventArgs e)
        {        
            if (Nickname.Text == "" || IP_address.Text == "")   //昵称或者地址为空，则不允许登录，这里不考虑数据库，所以不用密码验证登录
                MessageBox.Show("No NickName or IP_address");
            else
            {
                NickName = Nickname.Text;
                SenIPaddress = IP_address.Text;
                this.Close();               //在主窗口中已经调用了登录窗口，这个窗口直接关闭
            }
        }
        public String ReturnNick()
        {
            return NickName;
        }
        public String ReturnIP()
        {
            return SenIPaddress;
        }
        public bool YoN_close()
        {
            if (NickName == "" || SenIPaddress == "")
                return false;
            else
                return true;
        }
    }
}
