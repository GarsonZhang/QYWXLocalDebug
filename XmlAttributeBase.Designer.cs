namespace QYWXLocalDebug
{
    partial class XmlAttributeBase
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label11 = new System.Windows.Forms.Label();
            this.txt_AgentID = new System.Windows.Forms.TextBox();
            this.txt_ToUserName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_FromUserName = new System.Windows.Forms.TextBox();
            this.txt_MsgType = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_CreateTime = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(25, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 33;
            this.label11.Text = "ToUserName";
            // 
            // txt_AgentID
            // 
            this.txt_AgentID.Location = new System.Drawing.Point(92, 132);
            this.txt_AgentID.Name = "txt_AgentID";
            this.txt_AgentID.Size = new System.Drawing.Size(100, 21);
            this.txt_AgentID.TabIndex = 38;
            this.txt_AgentID.Text = "1";
            // 
            // txt_ToUserName
            // 
            this.txt_ToUserName.Location = new System.Drawing.Point(92, 18);
            this.txt_ToUserName.Name = "txt_ToUserName";
            this.txt_ToUserName.Size = new System.Drawing.Size(100, 21);
            this.txt_ToUserName.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(43, 136);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 37;
            this.label15.Text = "AgentID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 12);
            this.label12.TabIndex = 34;
            this.label12.Text = "FromUserName";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 35;
            this.label13.Text = "CreateTime";
            // 
            // txt_FromUserName
            // 
            this.txt_FromUserName.Location = new System.Drawing.Point(92, 49);
            this.txt_FromUserName.Name = "txt_FromUserName";
            this.txt_FromUserName.Size = new System.Drawing.Size(100, 21);
            this.txt_FromUserName.TabIndex = 40;
            this.txt_FromUserName.Text = "GarsonZhang";
            // 
            // txt_MsgType
            // 
            this.txt_MsgType.Location = new System.Drawing.Point(92, 105);
            this.txt_MsgType.Name = "txt_MsgType";
            this.txt_MsgType.ReadOnly = true;
            this.txt_MsgType.Size = new System.Drawing.Size(100, 21);
            this.txt_MsgType.TabIndex = 41;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(43, 109);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 12);
            this.label14.TabIndex = 36;
            this.label14.Text = "MsgType";
            // 
            // txt_CreateTime
            // 
            this.txt_CreateTime.Location = new System.Drawing.Point(92, 76);
            this.txt_CreateTime.Name = "txt_CreateTime";
            this.txt_CreateTime.Size = new System.Drawing.Size(100, 21);
            this.txt_CreateTime.TabIndex = 42;
            this.txt_CreateTime.Text = "382237285";
            // 
            // XmlAttributeBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_AgentID);
            this.Controls.Add(this.txt_ToUserName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_FromUserName);
            this.Controls.Add(this.txt_MsgType);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_CreateTime);
            this.Name = "XmlAttributeBase";
            this.Size = new System.Drawing.Size(709, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        protected System.Windows.Forms.TextBox txt_AgentID;
        protected System.Windows.Forms.TextBox txt_ToUserName;
        protected System.Windows.Forms.TextBox txt_FromUserName;
        protected System.Windows.Forms.TextBox txt_MsgType;
        protected System.Windows.Forms.TextBox txt_CreateTime;
    }
}
