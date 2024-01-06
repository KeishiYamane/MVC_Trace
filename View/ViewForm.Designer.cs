
namespace View
{
    partial class ViewForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
            this._textBoxLog = new System.Windows.Forms.TextBox();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this._panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // _textBoxLog
            // 
            this._textBoxLog.Location = new System.Drawing.Point(12, 52);
            this._textBoxLog.Multiline = true;
            this._textBoxLog.Name = "_textBoxLog";
            this._textBoxLog.ReadOnly = true;
            this._textBoxLog.Size = new System.Drawing.Size(312, 386);
            this._textBoxLog.TabIndex = 5;
            // 
            // SendBtn
            // 
            this.SendBtn.Location = new System.Drawing.Point(88, 12);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(70, 34);
            this.SendBtn.TabIndex = 3;
            this.SendBtn.Text = "送信";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(12, 12);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(70, 34);
            this.ConnectBtn.TabIndex = 4;
            this.ConnectBtn.Text = "接続";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // _panel1
            // 
            this._panel1.BackColor = System.Drawing.Color.Black;
            this._panel1.Location = new System.Drawing.Point(341, 12);
            this._panel1.Name = "_panel1";
            this._panel1.Size = new System.Drawing.Size(100, 100);
            this._panel1.TabIndex = 8;
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._panel1);
            this.Controls.Add(this._textBoxLog);
            this.Controls.Add(this.SendBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Name = "ViewForm";
            this.Text = "View";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxLog;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.Button ConnectBtn;
        private System.Windows.Forms.Panel _panel1;
    }
}

