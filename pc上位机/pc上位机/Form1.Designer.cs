namespace pc上位机
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FSclear = new System.Windows.Forms.Button();
            this.DATA = new System.Windows.Forms.RichTextBox();
            this.FSbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CKbutton = new System.Windows.Forms.Button();
            this.BTL = new System.Windows.Forms.ComboBox();
            this.CKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbRevShowHex = new System.Windows.Forms.CheckBox();
            this.JSclear = new System.Windows.Forms.Button();
            this.Received = new System.Windows.Forms.RichTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.FSclear);
            this.groupBox1.Controls.Add(this.DATA);
            this.groupBox1.Controls.Add(this.FSbutton);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(166, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "通用发送";
            // 
            // FSclear
            // 
            this.FSclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FSclear.BackColor = System.Drawing.Color.Lime;
            this.FSclear.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FSclear.ForeColor = System.Drawing.Color.MediumBlue;
            this.FSclear.Location = new System.Drawing.Point(6, 72);
            this.FSclear.Name = "FSclear";
            this.FSclear.Size = new System.Drawing.Size(92, 33);
            this.FSclear.TabIndex = 4;
            this.FSclear.Text = "清空发送区";
            this.FSclear.UseVisualStyleBackColor = false;
            this.FSclear.Click += new System.EventHandler(this.FSclear_Click);
            // 
            // DATA
            // 
            this.DATA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DATA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.DATA.Location = new System.Drawing.Point(104, 13);
            this.DATA.Name = "DATA";
            this.DATA.Size = new System.Drawing.Size(325, 92);
            this.DATA.TabIndex = 3;
            this.DATA.Text = "";
            // 
            // FSbutton
            // 
            this.FSbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FSbutton.BackColor = System.Drawing.Color.Lime;
            this.FSbutton.ForeColor = System.Drawing.Color.MediumBlue;
            this.FSbutton.Location = new System.Drawing.Point(6, 38);
            this.FSbutton.Name = "FSbutton";
            this.FSbutton.Size = new System.Drawing.Size(92, 28);
            this.FSbutton.TabIndex = 2;
            this.FSbutton.Text = "发送";
            this.FSbutton.UseVisualStyleBackColor = false;
            this.FSbutton.Click += new System.EventHandler(this.FSbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.CKbutton);
            this.groupBox2.Controls.Add(this.BTL);
            this.groupBox2.Controls.Add(this.CKH);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(148, 307);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "串口设置";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(6, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "and never give up!!";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(6, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Follow your heart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 12);
            this.label5.TabIndex = 5;
            // 
            // CKbutton
            // 
            this.CKbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CKbutton.BackColor = System.Drawing.Color.Lime;
            this.CKbutton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CKbutton.Location = new System.Drawing.Point(8, 169);
            this.CKbutton.Name = "CKbutton";
            this.CKbutton.Size = new System.Drawing.Size(130, 51);
            this.CKbutton.TabIndex = 4;
            this.CKbutton.Text = "打开串口";
            this.CKbutton.UseVisualStyleBackColor = false;
            this.CKbutton.Click += new System.EventHandler(this.CKbutton_Click);
            // 
            // BTL
            // 
            this.BTL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BTL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BTL.FormattingEnabled = true;
            this.BTL.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600",
            "19200",
            "115200"});
            this.BTL.Location = new System.Drawing.Point(67, 113);
            this.BTL.Name = "BTL";
            this.BTL.Size = new System.Drawing.Size(75, 20);
            this.BTL.TabIndex = 3;
            this.BTL.Text = "9600";
            // 
            // CKH
            // 
            this.CKH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CKH.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CKH.FormattingEnabled = true;
            this.CKH.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4"});
            this.CKH.Location = new System.Drawing.Point(67, 35);
            this.CKH.Name = "CKH";
            this.CKH.Size = new System.Drawing.Size(75, 20);
            this.CKH.TabIndex = 2;
            this.CKH.Text = "COM1";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "波特率";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "串口号";
            // 
            // serialPort
            // 
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.cbRevShowHex);
            this.groupBox3.Controls.Add(this.JSclear);
            this.groupBox3.Controls.Add(this.Received);
            this.groupBox3.Location = new System.Drawing.Point(166, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(435, 211);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "通用接收";
            // 
            // cbRevShowHex
            // 
            this.cbRevShowHex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbRevShowHex.AutoSize = true;
            this.cbRevShowHex.Location = new System.Drawing.Point(6, 190);
            this.cbRevShowHex.Name = "cbRevShowHex";
            this.cbRevShowHex.Size = new System.Drawing.Size(96, 16);
            this.cbRevShowHex.TabIndex = 6;
            this.cbRevShowHex.Text = "十六进制显示";
            this.cbRevShowHex.UseVisualStyleBackColor = true;
            this.cbRevShowHex.CheckedChanged += new System.EventHandler(this.cbRevShowHex_CheckedChanged);
            // 
            // JSclear
            // 
            this.JSclear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.JSclear.BackColor = System.Drawing.Color.Lime;
            this.JSclear.ForeColor = System.Drawing.Color.MediumBlue;
            this.JSclear.Location = new System.Drawing.Point(331, 187);
            this.JSclear.Name = "JSclear";
            this.JSclear.Size = new System.Drawing.Size(75, 23);
            this.JSclear.TabIndex = 5;
            this.JSclear.Text = "清空接收区";
            this.JSclear.UseVisualStyleBackColor = false;
            this.JSclear.Click += new System.EventHandler(this.JSclear_Click);
            // 
            // Received
            // 
            this.Received.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Received.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Received.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Received.Location = new System.Drawing.Point(6, 12);
            this.Received.Name = "Received";
            this.Received.Size = new System.Drawing.Size(423, 172);
            this.Received.TabIndex = 0;
            this.Received.Text = "";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.InactiveBorder;
            this.dateTimePicker1.Location = new System.Drawing.Point(11, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(149, 21);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(612, 352);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "pc上位机by LiangHui";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox BTL;
        private System.Windows.Forms.ComboBox CKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FSbutton;
        private System.Windows.Forms.Button CKbutton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.RichTextBox DATA;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox Received;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button FSclear;
        private System.Windows.Forms.Button JSclear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbRevShowHex;
    }
}

