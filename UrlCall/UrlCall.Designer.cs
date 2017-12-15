namespace UrlCall
{
    partial class UrlCall
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
            this.txtUrl = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.btnTrigger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUrl
            // 
            this.txtUrl.Location = new System.Drawing.Point(52, 18);
            this.txtUrl.Name = "txtUrl";
            this.txtUrl.Size = new System.Drawing.Size(234, 22);
            this.txtUrl.TabIndex = 0;
            this.txtUrl.Text = "http://";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(52, 46);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(56, 22);
            this.txtQty.TabIndex = 2;
            this.txtQty.Text = "2";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(13, 21);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(20, 12);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Url";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(13, 50);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(33, 12);
            this.lblQty.TabIndex = 4;
            this.lblQty.Text = "Times";
            // 
            // btnTrigger
            // 
            this.btnTrigger.Location = new System.Drawing.Point(15, 80);
            this.btnTrigger.Name = "btnTrigger";
            this.btnTrigger.Size = new System.Drawing.Size(271, 41);
            this.btnTrigger.TabIndex = 5;
            this.btnTrigger.Text = "Run";
            this.btnTrigger.UseVisualStyleBackColor = true;
            this.btnTrigger.Click += new System.EventHandler(this.btnTrigger_Click);
            // 
            // UrlCall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 133);
            this.Controls.Add(this.btnTrigger);
            this.Controls.Add(this.lblQty);
            this.Controls.Add(this.lblUrl);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtUrl);
            this.Name = "UrlCall";
            this.Text = "UrlCall";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUrl;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.Button btnTrigger;
    }
}