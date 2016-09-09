namespace QYWXLocalDebug
{
    partial class XmlAttributeThirdPartyCallback
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbInfoType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSuiteId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtSuiteTicket = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAuthCorpId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAuthCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSeq = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txtSeq)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_FromUserName
            // 
            this.txt_FromUserName.Text = "";
            // 
            // txt_MsgType
            // 
            this.txt_MsgType.Text = "default";
            // 
            // cmbInfoType
            // 
            this.cmbInfoType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInfoType.FormattingEnabled = true;
            this.cmbInfoType.Items.AddRange(new object[] {
            "suite_ticket",
            "change_auth",
            "cancel_auth",
            "create_auth",
            "contact_sync"});
            this.cmbInfoType.Location = new System.Drawing.Point(271, 21);
            this.cmbInfoType.Name = "cmbInfoType";
            this.cmbInfoType.Size = new System.Drawing.Size(177, 21);
            this.cmbInfoType.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "InfoType";
            // 
            // txtSuiteId
            // 
            this.txtSuiteId.Location = new System.Drawing.Point(271, 53);
            this.txtSuiteId.Name = "txtSuiteId";
            this.txtSuiteId.Size = new System.Drawing.Size(177, 20);
            this.txtSuiteId.TabIndex = 46;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(204, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 45;
            this.label17.Text = "SuiteId";
            // 
            // txtSuiteTicket
            // 
            this.txtSuiteTicket.Location = new System.Drawing.Point(271, 83);
            this.txtSuiteTicket.Name = "txtSuiteTicket";
            this.txtSuiteTicket.Size = new System.Drawing.Size(177, 20);
            this.txtSuiteTicket.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "SuiteTicket";
            // 
            // txtAuthCorpId
            // 
            this.txtAuthCorpId.Location = new System.Drawing.Point(271, 115);
            this.txtAuthCorpId.Name = "txtAuthCorpId";
            this.txtAuthCorpId.Size = new System.Drawing.Size(177, 20);
            this.txtAuthCorpId.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "AuthCorpId";
            // 
            // txtAuthCode
            // 
            this.txtAuthCode.Location = new System.Drawing.Point(271, 147);
            this.txtAuthCode.Name = "txtAuthCode";
            this.txtAuthCode.Size = new System.Drawing.Size(177, 20);
            this.txtAuthCode.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "AuthCode";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Seq";
            // 
            // txtSeq
            // 
            this.txtSeq.Location = new System.Drawing.Point(271, 176);
            this.txtSeq.Name = "txtSeq";
            this.txtSeq.Size = new System.Drawing.Size(177, 20);
            this.txtSeq.TabIndex = 55;
            // 
            // XmlAttributeThirdPartyCallback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtSeq);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAuthCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAuthCorpId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSuiteTicket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSuiteId);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInfoType);
            this.Name = "XmlAttributeThirdPartyCallback";
            this.Load += new System.EventHandler(this.XmlAttributeThirdPartyCallback_Load);
            this.Controls.SetChildIndex(this.txt_CreateTime, 0);
            this.Controls.SetChildIndex(this.txt_MsgType, 0);
            this.Controls.SetChildIndex(this.txt_FromUserName, 0);
            this.Controls.SetChildIndex(this.txt_ToUserName, 0);
            this.Controls.SetChildIndex(this.txt_AgentID, 0);
            this.Controls.SetChildIndex(this.cmbInfoType, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.Controls.SetChildIndex(this.txtSuiteId, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtSuiteTicket, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtAuthCorpId, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtAuthCode, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtSeq, 0);
            ((System.ComponentModel.ISupportInitialize)(this.txtSeq)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbInfoType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSuiteId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtSuiteTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAuthCorpId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAuthCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown txtSeq;
    }
}
