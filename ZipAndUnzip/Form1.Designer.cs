namespace ZipAndUnzip
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Zip = new System.Windows.Forms.Button();
            this.mkTBox = new System.Windows.Forms.MaskedTextBox();
            this.Unzip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Zip
            // 
            this.Zip.Location = new System.Drawing.Point(44, 201);
            this.Zip.Name = "Zip";
            this.Zip.Size = new System.Drawing.Size(80, 28);
            this.Zip.TabIndex = 0;
            this.Zip.Text = "压缩";
            this.Zip.UseVisualStyleBackColor = true;
            this.Zip.Click += new System.EventHandler(this.Zip_Click);
            // 
            // mkTBox
            // 
            this.mkTBox.Location = new System.Drawing.Point(91, 91);
            this.mkTBox.Name = "mkTBox";
            this.mkTBox.Size = new System.Drawing.Size(140, 21);
            this.mkTBox.TabIndex = 1;
            // 
            // Unzip
            // 
            this.Unzip.Location = new System.Drawing.Point(197, 204);
            this.Unzip.Name = "Unzip";
            this.Unzip.Size = new System.Drawing.Size(80, 25);
            this.Unzip.TabIndex = 2;
            this.Unzip.Text = "解压";
            this.Unzip.UseVisualStyleBackColor = true;
            this.Unzip.Click += new System.EventHandler(this.Unzip_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(321, 300);
            this.Controls.Add(this.Unzip);
            this.Controls.Add(this.mkTBox);
            this.Controls.Add(this.Zip);
            this.Name = "Form1";
            this.Text = "ZipAndUnzip";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Zip;
        private System.Windows.Forms.MaskedTextBox mkTBox;
        private System.Windows.Forms.Button Unzip;
    }
}

