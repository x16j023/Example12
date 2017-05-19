namespace Example12
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblresult = new System.Windows.Forms.Label();
            this.tbxMonth = new System.Windows.Forms.TextBox();
            this.btnjudge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "月";
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(24, 128);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(35, 12);
            this.lblresult.TabIndex = 1;
            this.lblresult.Text = "-----";
            // 
            // tbxMonth
            // 
            this.tbxMonth.Location = new System.Drawing.Point(12, 48);
            this.tbxMonth.Name = "tbxMonth";
            this.tbxMonth.Size = new System.Drawing.Size(100, 19);
            this.tbxMonth.TabIndex = 2;
            // 
            // btnjudge
            // 
            this.btnjudge.Location = new System.Drawing.Point(248, 50);
            this.btnjudge.Name = "btnjudge";
            this.btnjudge.Size = new System.Drawing.Size(75, 23);
            this.btnjudge.TabIndex = 3;
            this.btnjudge.Text = "判定";
            this.btnjudge.UseVisualStyleBackColor = true;
            this.btnjudge.Click += new System.EventHandler(this.btnjudge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 261);
            this.Controls.Add(this.btnjudge);
            this.Controls.Add(this.tbxMonth);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "月判定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblresult;
        private System.Windows.Forms.TextBox tbxMonth;
        private System.Windows.Forms.Button btnjudge;
    }
}

