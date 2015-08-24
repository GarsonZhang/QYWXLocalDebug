namespace QYWXLocalDebug
{
    partial class XmlAttributeText
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
            this.txt_MsgId = new System.Windows.Forms.TextBox();
            this.txt_Content = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_MsgId
            // 
            this.txt_MsgId.Location = new System.Drawing.Point(264, 48);
            this.txt_MsgId.Name = "txt_MsgId";
            this.txt_MsgId.Size = new System.Drawing.Size(195, 21);
            this.txt_MsgId.TabIndex = 14;
            // 
            // txt_Content
            // 
            this.txt_Content.Location = new System.Drawing.Point(264, 19);
            this.txt_Content.Name = "txt_Content";
            this.txt_Content.Size = new System.Drawing.Size(195, 21);
            this.txt_Content.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(227, 52);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 12);
            this.label16.TabIndex = 10;
            this.label16.Text = "MsgId";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(215, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 11;
            this.label17.Text = "Content";
            // 
            // XmlAttributeText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_MsgId);
            this.Controls.Add(this.txt_Content);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Name = "XmlAttributeText";
            this.Size = new System.Drawing.Size(481, 179);
            this.Load += new System.EventHandler(this.TextAttribute_Load);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.txt_Content, 0);
            this.Controls.SetChildIndex(this.txt_MsgId, 0);
            this.Controls.SetChildIndex(this.txt_CreateTime, 0);
            this.Controls.SetChildIndex(this.txt_MsgType, 0);
            this.Controls.SetChildIndex(this.txt_FromUserName, 0);
            this.Controls.SetChildIndex(this.txt_ToUserName, 0);
            this.Controls.SetChildIndex(this.txt_AgentID, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_MsgId;
        private System.Windows.Forms.TextBox txt_Content;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}
