
namespace WindowsCOMselfApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkcomboBox = new System.Windows.Forms.ComboBox();
            this.datacomboBox = new System.Windows.Forms.ComboBox();
            this.stopcomboBox = new System.Windows.Forms.ComboBox();
            this.baudcomboBox = new System.Windows.Forms.ComboBox();
            this.portcomboBox = new System.Windows.Forms.ComboBox();
            this.opencombutton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.showtextBox = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.sendtextBox = new System.Windows.Forms.TextBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.clearsendbutton = new System.Windows.Forms.Button();
            this.sendcheckBox = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.gyrodatabutton = new System.Windows.Forms.Button();
            this.stopgyrobutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkcomboBox);
            this.groupBox1.Controls.Add(this.datacomboBox);
            this.groupBox1.Controls.Add(this.stopcomboBox);
            this.groupBox1.Controls.Add(this.baudcomboBox);
            this.groupBox1.Controls.Add(this.portcomboBox);
            this.groupBox1.Controls.Add(this.opencombutton);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(585, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 209);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口配置";
            // 
            // checkcomboBox
            // 
            this.checkcomboBox.FormattingEnabled = true;
            this.checkcomboBox.Items.AddRange(new object[] {
            "无",
            "奇校验",
            "偶校验"});
            this.checkcomboBox.Location = new System.Drawing.Point(74, 147);
            this.checkcomboBox.Name = "checkcomboBox";
            this.checkcomboBox.Size = new System.Drawing.Size(121, 20);
            this.checkcomboBox.TabIndex = 11;
            // 
            // datacomboBox
            // 
            this.datacomboBox.FormattingEnabled = true;
            this.datacomboBox.Items.AddRange(new object[] {
            "8",
            "7",
            "6",
            "5"});
            this.datacomboBox.Location = new System.Drawing.Point(74, 117);
            this.datacomboBox.Name = "datacomboBox";
            this.datacomboBox.Size = new System.Drawing.Size(121, 20);
            this.datacomboBox.TabIndex = 10;
            // 
            // stopcomboBox
            // 
            this.stopcomboBox.FormattingEnabled = true;
            this.stopcomboBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopcomboBox.Location = new System.Drawing.Point(74, 85);
            this.stopcomboBox.Name = "stopcomboBox";
            this.stopcomboBox.Size = new System.Drawing.Size(121, 20);
            this.stopcomboBox.TabIndex = 9;
            // 
            // baudcomboBox
            // 
            this.baudcomboBox.FormattingEnabled = true;
            this.baudcomboBox.Items.AddRange(new object[] {
            "1382400",
            "921600",
            "460800",
            "256000",
            "230400",
            "128000",
            "115200",
            "76800",
            "57600",
            "43000",
            "38400",
            "19200",
            "14400",
            "9600",
            "4800",
            "1200"});
            this.baudcomboBox.Location = new System.Drawing.Point(74, 55);
            this.baudcomboBox.Name = "baudcomboBox";
            this.baudcomboBox.Size = new System.Drawing.Size(121, 20);
            this.baudcomboBox.TabIndex = 8;
            // 
            // portcomboBox
            // 
            this.portcomboBox.FormattingEnabled = true;
            this.portcomboBox.Location = new System.Drawing.Point(74, 23);
            this.portcomboBox.Name = "portcomboBox";
            this.portcomboBox.Size = new System.Drawing.Size(121, 20);
            this.portcomboBox.TabIndex = 7;
            // 
            // opencombutton
            // 
            this.opencombutton.Location = new System.Drawing.Point(74, 175);
            this.opencombutton.Name = "opencombutton";
            this.opencombutton.Size = new System.Drawing.Size(121, 25);
            this.opencombutton.TabIndex = 6;
            this.opencombutton.Text = "打开串口";
            this.opencombutton.UseVisualStyleBackColor = true;
            this.opencombutton.Click += new System.EventHandler(this.opencombutton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "操  作:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "校验位:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "数据位:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "停止位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "波特率:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口号:";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // showtextBox
            // 
            this.showtextBox.Location = new System.Drawing.Point(12, 12);
            this.showtextBox.Multiline = true;
            this.showtextBox.Name = "showtextBox";
            this.showtextBox.Size = new System.Drawing.Size(567, 299);
            this.showtextBox.TabIndex = 1;
            this.showtextBox.TextChanged += new System.EventHandler(this.showtextBox_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(586, 228);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(78, 16);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "16进制HEX";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(670, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "清除数据";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendtextBox
            // 
            this.sendtextBox.Location = new System.Drawing.Point(12, 317);
            this.sendtextBox.Multiline = true;
            this.sendtextBox.Name = "sendtextBox";
            this.sendtextBox.Size = new System.Drawing.Size(567, 121);
            this.sendtextBox.TabIndex = 4;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(586, 377);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(84, 23);
            this.sendbutton.TabIndex = 5;
            this.sendbutton.Text = "发  送";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.sendbutton_Click);
            // 
            // clearsendbutton
            // 
            this.clearsendbutton.Location = new System.Drawing.Point(692, 377);
            this.clearsendbutton.Name = "clearsendbutton";
            this.clearsendbutton.Size = new System.Drawing.Size(84, 23);
            this.clearsendbutton.TabIndex = 6;
            this.clearsendbutton.Text = "清空发送";
            this.clearsendbutton.UseVisualStyleBackColor = true;
            this.clearsendbutton.Click += new System.EventHandler(this.clearsendbutton_Click);
            // 
            // sendcheckBox
            // 
            this.sendcheckBox.AutoSize = true;
            this.sendcheckBox.Location = new System.Drawing.Point(586, 418);
            this.sendcheckBox.Name = "sendcheckBox";
            this.sendcheckBox.Size = new System.Drawing.Size(84, 16);
            this.sendcheckBox.TabIndex = 7;
            this.sendcheckBox.Text = "16进制发送";
            this.sendcheckBox.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(586, 266);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(120, 16);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "是否发送陀螺数据";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // gyrodatabutton
            // 
            this.gyrodatabutton.Location = new System.Drawing.Point(586, 288);
            this.gyrodatabutton.Name = "gyrodatabutton";
            this.gyrodatabutton.Size = new System.Drawing.Size(96, 23);
            this.gyrodatabutton.TabIndex = 9;
            this.gyrodatabutton.Text = "陀螺数据发送";
            this.gyrodatabutton.UseVisualStyleBackColor = true;
            this.gyrodatabutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // stopgyrobutton
            // 
            this.stopgyrobutton.Location = new System.Drawing.Point(692, 288);
            this.stopgyrobutton.Name = "stopgyrobutton";
            this.stopgyrobutton.Size = new System.Drawing.Size(96, 23);
            this.stopgyrobutton.TabIndex = 10;
            this.stopgyrobutton.Text = "停止陀螺数据";
            this.stopgyrobutton.UseVisualStyleBackColor = true;
            this.stopgyrobutton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.stopgyrobutton);
            this.Controls.Add(this.gyrodatabutton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.sendcheckBox);
            this.Controls.Add(this.clearsendbutton);
            this.Controls.Add(this.sendbutton);
            this.Controls.Add(this.sendtextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.showtextBox);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "模拟陀螺测试工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox checkcomboBox;
        private System.Windows.Forms.ComboBox datacomboBox;
        private System.Windows.Forms.ComboBox stopcomboBox;
        private System.Windows.Forms.ComboBox baudcomboBox;
        private System.Windows.Forms.ComboBox portcomboBox;
        private System.Windows.Forms.Button opencombutton;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox showtextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sendtextBox;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.Button clearsendbutton;
        private System.Windows.Forms.CheckBox sendcheckBox;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button gyrodatabutton;
        private System.Windows.Forms.Button stopgyrobutton;
    }
}

