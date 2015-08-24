namespace QYWXLocalDebug
{
    partial class XmlAttributeSubscribe
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
            this.txt_Event = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Event
            // 
            this.txt_Event.Location = new System.Drawing.Point(260, 18);
            this.txt_Event.Name = "txt_Event";
            this.txt_Event.ReadOnly = true;
            this.txt_Event.Size = new System.Drawing.Size(195, 21);
            this.txt_Event.TabIndex = 29;
            this.txt_Event.Text = "CLICK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(225, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 12);
            this.label17.TabIndex = 25;
            this.label17.Text = "Event";
            // 
            // XmlAttributeSubscribe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txt_Event);
            this.Controls.Add(this.label17);
            this.Name = "XmlAttributeSubscribe";
            this.Size = new System.Drawing.Size(584, 169);
            this.Load += new System.EventHandler(this.XmlAttributeSubscribe_Load);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txt_Event, 0);
            this.Controls.SetChildIndex(this.txt_CreateTime, 0);
            this.Controls.SetChildIndex(this.txt_MsgType, 0);
            this.Controls.SetChildIndex(this.txt_FromUserName, 0);
            this.Controls.SetChildIndex(this.txt_ToUserName, 0);
            this.Controls.SetChildIndex(this.txt_AgentID, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Event;
        private System.Windows.Forms.Label label17;
    }
}
