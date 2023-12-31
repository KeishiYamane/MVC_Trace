
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
            this._buttonSend = new System.Windows.Forms.Button();
            this._buttonConnect = new System.Windows.Forms.Button();
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
            // _buttonSend
            // 
            this._buttonSend.Location = new System.Drawing.Point(88, 12);
            this._buttonSend.Name = "_buttonSend";
            this._buttonSend.Size = new System.Drawing.Size(70, 34);
            this._buttonSend.TabIndex = 3;
            this._buttonSend.Text = "送信";
            this._buttonSend.UseVisualStyleBackColor = true;
            // 
            // _buttonConnect
            // 
            this._buttonConnect.Location = new System.Drawing.Point(12, 12);
            this._buttonConnect.Name = "_buttonConnect";
            this._buttonConnect.Size = new System.Drawing.Size(70, 34);
            this._buttonConnect.TabIndex = 4;
            this._buttonConnect.Text = "接続";
            this._buttonConnect.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._textBoxLog);
            this.Controls.Add(this._buttonSend);
            this.Controls.Add(this._buttonConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxLog;
        private System.Windows.Forms.Button _buttonSend;
        private System.Windows.Forms.Button _buttonConnect;
    }
}

