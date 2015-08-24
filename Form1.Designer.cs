namespace QYWXLocalDebug
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_echostr = new System.Windows.Forms.TextBox();
            this.txt_Msg = new System.Windows.Forms.TextBox();
            this.txt_ValidBackData = new System.Windows.Forms.TextBox();
            this.btn_msg_signature = new System.Windows.Forms.Button();
            this.txt_ValidURL = new System.Windows.Forms.TextBox();
            this.btn_CallBackValidate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TextResult = new System.Windows.Forms.TextBox();
            this.btn_SendText = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txt_EnyXMLText = new System.Windows.Forms.TextBox();
            this.txt_XMLText = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.xmlAttributeText1 = new QYWXLocalDebug.XmlAttributeText();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.xmlAttributeEventKey1 = new QYWXLocalDebug.XmlAttributeEventKey();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_msg_signature = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_nonce = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_timestamp = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_CorpToken = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_URL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_EncodingAESKey = new System.Windows.Forms.TextBox();
            this.txt_CorpID = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1248, 611);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.txt_echostr);
            this.tabPage2.Controls.Add(this.txt_Msg);
            this.tabPage2.Controls.Add(this.txt_ValidBackData);
            this.tabPage2.Controls.Add(this.btn_msg_signature);
            this.tabPage2.Controls.Add(this.txt_ValidURL);
            this.tabPage2.Controls.Add(this.btn_CallBackValidate);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1240, 585);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "回调认证";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(160, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(293, 12);
            this.label20.TabIndex = 13;
            this.label20.Text = "随机明文，如果返回结果跟这个相同，则表示验证成功";
            // 
            // txt_echostr
            // 
            this.txt_echostr.Location = new System.Drawing.Point(130, 6);
            this.txt_echostr.Name = "txt_echostr";
            this.txt_echostr.ReadOnly = true;
            this.txt_echostr.Size = new System.Drawing.Size(623, 21);
            this.txt_echostr.TabIndex = 6;
            // 
            // txt_Msg
            // 
            this.txt_Msg.Location = new System.Drawing.Point(162, 167);
            this.txt_Msg.Name = "txt_Msg";
            this.txt_Msg.ReadOnly = true;
            this.txt_Msg.Size = new System.Drawing.Size(260, 21);
            this.txt_Msg.TabIndex = 12;
            // 
            // txt_ValidBackData
            // 
            this.txt_ValidBackData.Location = new System.Drawing.Point(46, 233);
            this.txt_ValidBackData.Multiline = true;
            this.txt_ValidBackData.Name = "txt_ValidBackData";
            this.txt_ValidBackData.ReadOnly = true;
            this.txt_ValidBackData.Size = new System.Drawing.Size(712, 110);
            this.txt_ValidBackData.TabIndex = 6;
            // 
            // btn_msg_signature
            // 
            this.btn_msg_signature.Location = new System.Drawing.Point(44, 138);
            this.btn_msg_signature.Name = "btn_msg_signature";
            this.btn_msg_signature.Size = new System.Drawing.Size(103, 69);
            this.btn_msg_signature.TabIndex = 11;
            this.btn_msg_signature.Text = "1.生成回调参数";
            this.btn_msg_signature.UseVisualStyleBackColor = true;
            this.btn_msg_signature.Click += new System.EventHandler(this.btn_msg_signature_Click);
            // 
            // txt_ValidURL
            // 
            this.txt_ValidURL.Location = new System.Drawing.Point(46, 52);
            this.txt_ValidURL.Multiline = true;
            this.txt_ValidURL.Name = "txt_ValidURL";
            this.txt_ValidURL.ReadOnly = true;
            this.txt_ValidURL.Size = new System.Drawing.Size(712, 80);
            this.txt_ValidURL.TabIndex = 6;
            // 
            // btn_CallBackValidate
            // 
            this.btn_CallBackValidate.Location = new System.Drawing.Point(476, 138);
            this.btn_CallBackValidate.Name = "btn_CallBackValidate";
            this.btn_CallBackValidate.Size = new System.Drawing.Size(282, 69);
            this.btn_CallBackValidate.TabIndex = 0;
            this.btn_CallBackValidate.Text = "2.本地回调，请在本地断点调试";
            this.btn_CallBackValidate.UseVisualStyleBackColor = true;
            this.btn_CallBackValidate.Click += new System.EventHandler(this.btn_CallBackValidate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "回调结果";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "回调URL全地址";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "echostr(自动生成)";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1240, 585);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "被动响应消息";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txt_TextResult);
            this.panel3.Controls.Add(this.btn_SendText);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txt_EnyXMLText);
            this.panel3.Controls.Add(this.txt_XMLText);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 211);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1234, 371);
            this.panel3.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(874, 240);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(335, 48);
            this.label11.TabIndex = 9;
            this.label11.Text = "如果第一行出现：\r\n<?xml version=\"1.0\" encoding=\"utf-8\" standalone=\"yes\"?>\r\n需要修改程序去掉这一行，因为" +
    "如果第一行是这一句的话，\r\n微信服务器会处理错误";
            // 
            // txt_TextResult
            // 
            this.txt_TextResult.Location = new System.Drawing.Point(876, 32);
            this.txt_TextResult.Multiline = true;
            this.txt_TextResult.Name = "txt_TextResult";
            this.txt_TextResult.ReadOnly = true;
            this.txt_TextResult.Size = new System.Drawing.Size(333, 195);
            this.txt_TextResult.TabIndex = 8;
            // 
            // btn_SendText
            // 
            this.btn_SendText.Location = new System.Drawing.Point(387, 32);
            this.btn_SendText.Name = "btn_SendText";
            this.btn_SendText.Size = new System.Drawing.Size(100, 56);
            this.btn_SendText.TabIndex = 6;
            this.btn_SendText.Text = "模拟发送";
            this.btn_SendText.UseVisualStyleBackColor = true;
            this.btn_SendText.Click += new System.EventHandler(this.btn_SendText_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Red;
            this.label22.Location = new System.Drawing.Point(25, 17);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 12);
            this.label22.TabIndex = 7;
            this.label22.Text = "XML明文";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(500, 17);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(53, 12);
            this.label21.TabIndex = 7;
            this.label21.Text = "加密结果";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(874, 17);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "回调结果";
            // 
            // txt_EnyXMLText
            // 
            this.txt_EnyXMLText.Location = new System.Drawing.Point(502, 32);
            this.txt_EnyXMLText.Multiline = true;
            this.txt_EnyXMLText.Name = "txt_EnyXMLText";
            this.txt_EnyXMLText.ReadOnly = true;
            this.txt_EnyXMLText.Size = new System.Drawing.Size(341, 195);
            this.txt_EnyXMLText.TabIndex = 4;
            // 
            // txt_XMLText
            // 
            this.txt_XMLText.Location = new System.Drawing.Point(27, 32);
            this.txt_XMLText.Multiline = true;
            this.txt_XMLText.Name = "txt_XMLText";
            this.txt_XMLText.ReadOnly = true;
            this.txt_XMLText.Size = new System.Drawing.Size(341, 195);
            this.txt_XMLText.TabIndex = 4;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl2.Location = new System.Drawing.Point(3, 19);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1234, 192);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.xmlAttributeText1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1226, 166);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "发送消息";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // xmlAttributeText1
            // 
            this.xmlAttributeText1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlAttributeText1.Location = new System.Drawing.Point(3, 3);
            this.xmlAttributeText1.Name = "xmlAttributeText1";
            this.xmlAttributeText1.Size = new System.Drawing.Size(1220, 160);
            this.xmlAttributeText1.TabIndex = 0;
            this.xmlAttributeText1.XMLTextBox = null;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.xmlAttributeEventKey1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1226, 166);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "模拟点击菜单发送Key";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // xmlAttributeEventKey1
            // 
            this.xmlAttributeEventKey1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlAttributeEventKey1.Location = new System.Drawing.Point(3, 3);
            this.xmlAttributeEventKey1.Name = "xmlAttributeEventKey1";
            this.xmlAttributeEventKey1.Size = new System.Drawing.Size(1220, 160);
            this.xmlAttributeEventKey1.TabIndex = 0;
            this.xmlAttributeEventKey1.XMLTextBox = null;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1234, 16);
            this.panel2.TabIndex = 1;
            this.panel2.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1240, 585);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "主动发送消息";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_msg_signature);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_nonce);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_timestamp);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(523, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 113);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "模拟微信回调参数(系统自动生成)";
            // 
            // txt_msg_signature
            // 
            this.txt_msg_signature.Location = new System.Drawing.Point(99, 23);
            this.txt_msg_signature.Name = "txt_msg_signature";
            this.txt_msg_signature.ReadOnly = true;
            this.txt_msg_signature.Size = new System.Drawing.Size(453, 21);
            this.txt_msg_signature.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "nonce";
            // 
            // txt_nonce
            // 
            this.txt_nonce.Location = new System.Drawing.Point(99, 81);
            this.txt_nonce.Name = "txt_nonce";
            this.txt_nonce.ReadOnly = true;
            this.txt_nonce.Size = new System.Drawing.Size(453, 21);
            this.txt_nonce.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 0;
            this.label7.Text = "msg_signature";
            // 
            // txt_timestamp
            // 
            this.txt_timestamp.Location = new System.Drawing.Point(99, 52);
            this.txt_timestamp.Name = "txt_timestamp";
            this.txt_timestamp.ReadOnly = true;
            this.txt_timestamp.Size = new System.Drawing.Size(453, 21);
            this.txt_timestamp.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 0;
            this.label8.Text = "timestamp";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_CorpToken);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_URL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_EncodingAESKey);
            this.groupBox1.Controls.Add(this.txt_CorpID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 132);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基础资料";
            // 
            // txt_CorpToken
            // 
            this.txt_CorpToken.Location = new System.Drawing.Point(99, 19);
            this.txt_CorpToken.Name = "txt_CorpToken";
            this.txt_CorpToken.Size = new System.Drawing.Size(392, 21);
            this.txt_CorpToken.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 12);
            this.label10.TabIndex = 0;
            this.label10.Text = "URL";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "CorpToken";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "CorpID";
            // 
            // txt_URL
            // 
            this.txt_URL.Location = new System.Drawing.Point(99, 104);
            this.txt_URL.Name = "txt_URL";
            this.txt_URL.Size = new System.Drawing.Size(392, 21);
            this.txt_URL.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "EncodingAESKey";
            // 
            // txt_EncodingAESKey
            // 
            this.txt_EncodingAESKey.Location = new System.Drawing.Point(99, 77);
            this.txt_EncodingAESKey.Name = "txt_EncodingAESKey";
            this.txt_EncodingAESKey.Size = new System.Drawing.Size(392, 21);
            this.txt_EncodingAESKey.TabIndex = 6;
            // 
            // txt_CorpID
            // 
            this.txt_CorpID.Location = new System.Drawing.Point(99, 48);
            this.txt_CorpID.Name = "txt_CorpID";
            this.txt_CorpID.Size = new System.Drawing.Size(392, 21);
            this.txt_CorpID.TabIndex = 7;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer1.Panel1MinSize = 140;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Panel2MinSize = 350;
            this.splitContainer1.Size = new System.Drawing.Size(1248, 761);
            this.splitContainer1.SplitterDistance = 146;
            this.splitContainer1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 761);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "微信企业号本地调试";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_echostr;
        private System.Windows.Forms.TextBox txt_ValidBackData;
        private System.Windows.Forms.TextBox txt_ValidURL;
        private System.Windows.Forms.Button btn_CallBackValidate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_msg_signature;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_nonce;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_timestamp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_CorpToken;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_URL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_EncodingAESKey;
        private System.Windows.Forms.TextBox txt_CorpID;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox txt_XMLText;
        private System.Windows.Forms.Button btn_SendText;
        private System.Windows.Forms.TextBox txt_TextResult;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button btn_msg_signature;
        private System.Windows.Forms.TextBox txt_Msg;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_EnyXMLText;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private XmlAttributeText xmlAttributeText1;
        private XmlAttributeEventKey xmlAttributeEventKey1;
        private System.Windows.Forms.Label label11;

    }
}

