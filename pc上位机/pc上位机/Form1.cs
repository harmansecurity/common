using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace pc上位机
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       // string datain="";
        private void CKbutton_Click(object sender, EventArgs e)//"打开关闭串口"按钮
        {
            string CommNum = this.CKH.Text;
            int IntBdr = Convert.ToInt32(this.BTL.Text);//将串口号和波特率存起来
            if (!serialPort.IsOpen)                     //如果串口是关闭的
            {
                serialPort.PortName= CommNum;
                serialPort.BaudRate = IntBdr;          //设定串口号和波特率
                try    //try:尝试下面的代码，如果错误就跳出来执行catch里面的代码
                {
                    serialPort.Open();         //打开串口
                    CKbutton.Text = "关闭串口";//改变按钮上的字符
                    CKH.Enabled = false;
                    BTL.Enabled = false;       //将串口号和波特率选择空间关闭
                }
                catch
                {
                    MessageBox.Show("串口打开失败了！\n\n可能是串口已被占用.");
                }
            }
            else//如果串口是打开的
            {
                serialPort.Close();         //关闭串口
                CKbutton.Text = "打开串口";//改变按钮上的字符
                CKH.Enabled = true;
                BTL.Enabled = true;       //将串口号和波特率选择空间打开 
            }
        }

        private void FSbutton_Click(object sender, EventArgs e)//”发送“数据按钮
        {
            if (serialPort.IsOpen)
            {
                if (DATA.Text != "")//如果数据不为空
                {
                    serialPort.Write(DATA.Text);
                }
                else
                {
                    MessageBox.Show("发送失败了！\n\n请确认已输入数据");
                }
            }
            else
            {
                MessageBox.Show("发送失败了！\n\n请打开串口");
            }
        }
       /* private void DisplayText(object sender, EventArgs e)
        {


            Received.Text = datain;

        }*/
        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            byte[] buf = new byte[100];
            int readcount = 0;
            while (serialPort.BytesToRead > 0)
            {
                readcount = serialPort.Read(buf, 0, buf.Length);
                if (!cbRevShowHex.Checked)
                    RevAppend(System.Text.Encoding.GetEncoding("gb2312").GetString(buf, 0, readcount));
                else
                    for (int i = 0; i < readcount; i++)
                        RevAppend(buf[i].ToString("X").PadLeft(2, '0') + " ");
            }
        }

        private void FSclear_Click(object sender, EventArgs e)
        {
            DATA.Clear();
        }

        private void JSclear_Click(object sender, EventArgs e)
        {
            Received.Clear();
        }

        private void cbRevShowHex_CheckedChanged(object sender, EventArgs e)//十六进制的转化
        {
            if (cbRevShowHex.Checked)
            {
                byte[] buf = System.Text.Encoding.GetEncoding("gb2312").GetBytes(Received.Text);
                Received.Clear();
                for (int i = 0; i < buf.Length; i++)
                    RevAppend(buf[i].ToString("X").PadLeft(2, '0') + " ");
            }
            else
            {
                string str = Received.Text;
                Received.Clear();
                string[] arr = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in arr)
                    RevAppend(Convert.ToChar(Convert.ToByte(s, 16)).ToString());
            }
        }
        void RevAppend(string str)
        {
            if (Received.InvokeRequired)
                this.Invoke(new MethodInvoker(delegate
                {
                    Received.AppendText(str);
                    Received.SelectionStart = int.MaxValue;
                    Received.SelectionLength = 1;
                    Received.ScrollToCaret();
                }));
            else
            {
                Received.AppendText(str);
                Received.SelectionStart = int.MaxValue;
                Received.SelectionLength = 1;
                Received.ScrollToCaret();
            }
        }
    }
}
