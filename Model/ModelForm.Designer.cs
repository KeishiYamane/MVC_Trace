
namespace MVC_Trace
{
    partial class ModelForm
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
            this.StartListenBtn = new System.Windows.Forms.Button();
            this._ModelPanel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this._colorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // _textBoxLog
            // 
            this._textBoxLog.Location = new System.Drawing.Point(12, 54);
            this._textBoxLog.Multiline = true;
            this._textBoxLog.Name = "_textBoxLog";
            this._textBoxLog.ReadOnly = true;
            this._textBoxLog.Size = new System.Drawing.Size(312, 384);
            this._textBoxLog.TabIndex = 3;
            // 
            // StartListenBtn
            // 
            this.StartListenBtn.Location = new System.Drawing.Point(12, 12);
            this.StartListenBtn.Name = "StartListenBtn";
            this.StartListenBtn.Size = new System.Drawing.Size(115, 36);
            this.StartListenBtn.TabIndex = 2;
            this.StartListenBtn.Text = "待ち受け開始";
            this.StartListenBtn.UseVisualStyleBackColor = true;
            this.StartListenBtn.Click += new System.EventHandler(this.StartListenBtn_Click);
            // 
            // _ModelPanel1
            // 
            this._ModelPanel1.BackColor = System.Drawing.Color.Black;
            this._ModelPanel1.Location = new System.Drawing.Point(358, 54);
            this._ModelPanel1.Name = "_ModelPanel1";
            this._ModelPanel1.Size = new System.Drawing.Size(100, 100);
            this._ModelPanel1.TabIndex = 4;
            this._ModelPanel1.BackColorChanged += new System.EventHandler(this._ModelPanel1_BackColorChanged);
            this._ModelPanel1.Click += new System.EventHandler(this._ModelPanel1_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(381, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "↑クリック";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ModelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._ModelPanel1);
            this.Controls.Add(this._textBoxLog);
            this.Controls.Add(this.StartListenBtn);
            this.Name = "ModelForm";
            this.Text = "Model";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxLog;
        private System.Windows.Forms.Button StartListenBtn;
        private System.Windows.Forms.Panel _ModelPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog _colorDialog;
    }
}

