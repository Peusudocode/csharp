namespace cs_File
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.lblFileInfoName = new System.Windows.Forms.Label();
            this.lblFileInfoDirectoryName = new System.Windows.Forms.Label();
            this.lblFileInfoSize = new System.Windows.Forms.Label();
            this.lblFileInfoCreationTime = new System.Windows.Forms.Label();
            this.lblFileInfoLastAccessTime = new System.Windows.Forms.Label();
            this.lblFileInfoLastWriteTime = new System.Windows.Forms.Label();
            this.lblFileAttributeHidden = new System.Windows.Forms.Label();
            this.lblFileAttributeReadOnly = new System.Windows.Forms.Label();
            this.lblFileAttributeSystem = new System.Windows.Forms.Label();
            this.lblFileAttributeOffline = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnFileInfo = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(342, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 67;
            this.btnSave.Text = "存檔";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Panel1
            // 
            this.Panel1.AutoScroll = true;
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panel1.Controls.Add(this.lblFileInfoName);
            this.Panel1.Controls.Add(this.lblFileInfoDirectoryName);
            this.Panel1.Controls.Add(this.lblFileInfoSize);
            this.Panel1.Controls.Add(this.lblFileInfoCreationTime);
            this.Panel1.Controls.Add(this.lblFileInfoLastAccessTime);
            this.Panel1.Controls.Add(this.lblFileInfoLastWriteTime);
            this.Panel1.Controls.Add(this.lblFileAttributeHidden);
            this.Panel1.Controls.Add(this.lblFileAttributeReadOnly);
            this.Panel1.Controls.Add(this.lblFileAttributeSystem);
            this.Panel1.Controls.Add(this.lblFileAttributeOffline);
            this.Panel1.Location = new System.Drawing.Point(30, 66);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(296, 254);
            this.Panel1.TabIndex = 66;
            // 
            // lblFileInfoName
            // 
            this.lblFileInfoName.Location = new System.Drawing.Point(8, 8);
            this.lblFileInfoName.Name = "lblFileInfoName";
            this.lblFileInfoName.Size = new System.Drawing.Size(264, 16);
            this.lblFileInfoName.TabIndex = 13;
            this.lblFileInfoName.Text = "lblFileInfoName";
            // 
            // lblFileInfoDirectoryName
            // 
            this.lblFileInfoDirectoryName.Location = new System.Drawing.Point(8, 32);
            this.lblFileInfoDirectoryName.Name = "lblFileInfoDirectoryName";
            this.lblFileInfoDirectoryName.Size = new System.Drawing.Size(264, 16);
            this.lblFileInfoDirectoryName.TabIndex = 14;
            this.lblFileInfoDirectoryName.Text = "lblFileInfoDirectoryName";
            // 
            // lblFileInfoSize
            // 
            this.lblFileInfoSize.Location = new System.Drawing.Point(8, 56);
            this.lblFileInfoSize.Name = "lblFileInfoSize";
            this.lblFileInfoSize.Size = new System.Drawing.Size(264, 16);
            this.lblFileInfoSize.TabIndex = 15;
            this.lblFileInfoSize.Text = "lblFileInfoSize";
            // 
            // lblFileInfoCreationTime
            // 
            this.lblFileInfoCreationTime.Location = new System.Drawing.Point(8, 80);
            this.lblFileInfoCreationTime.Name = "lblFileInfoCreationTime";
            this.lblFileInfoCreationTime.Size = new System.Drawing.Size(264, 16);
            this.lblFileInfoCreationTime.TabIndex = 17;
            this.lblFileInfoCreationTime.Text = "lblFileInfoCreationTime";
            // 
            // lblFileInfoLastAccessTime
            // 
            this.lblFileInfoLastAccessTime.Location = new System.Drawing.Point(8, 104);
            this.lblFileInfoLastAccessTime.Name = "lblFileInfoLastAccessTime";
            this.lblFileInfoLastAccessTime.Size = new System.Drawing.Size(264, 16);
            this.lblFileInfoLastAccessTime.TabIndex = 19;
            this.lblFileInfoLastAccessTime.Text = "lblFileInfoLastAccessTime";
            // 
            // lblFileInfoLastWriteTime
            // 
            this.lblFileInfoLastWriteTime.Location = new System.Drawing.Point(8, 128);
            this.lblFileInfoLastWriteTime.Name = "lblFileInfoLastWriteTime";
            this.lblFileInfoLastWriteTime.Size = new System.Drawing.Size(264, 16);
            this.lblFileInfoLastWriteTime.TabIndex = 20;
            this.lblFileInfoLastWriteTime.Text = "lblFileInfoLastWriteTime";
            // 
            // lblFileAttributeHidden
            // 
            this.lblFileAttributeHidden.Location = new System.Drawing.Point(8, 152);
            this.lblFileAttributeHidden.Name = "lblFileAttributeHidden";
            this.lblFileAttributeHidden.Size = new System.Drawing.Size(264, 16);
            this.lblFileAttributeHidden.TabIndex = 21;
            this.lblFileAttributeHidden.Text = "lblFileAttributeHidden";
            // 
            // lblFileAttributeReadOnly
            // 
            this.lblFileAttributeReadOnly.Location = new System.Drawing.Point(8, 176);
            this.lblFileAttributeReadOnly.Name = "lblFileAttributeReadOnly";
            this.lblFileAttributeReadOnly.Size = new System.Drawing.Size(264, 16);
            this.lblFileAttributeReadOnly.TabIndex = 24;
            this.lblFileAttributeReadOnly.Text = "lblFileAttributeReadOnly";
            // 
            // lblFileAttributeSystem
            // 
            this.lblFileAttributeSystem.Location = new System.Drawing.Point(8, 200);
            this.lblFileAttributeSystem.Name = "lblFileAttributeSystem";
            this.lblFileAttributeSystem.Size = new System.Drawing.Size(264, 16);
            this.lblFileAttributeSystem.TabIndex = 25;
            this.lblFileAttributeSystem.Text = "lblFileAttributeSystem";
            // 
            // lblFileAttributeOffline
            // 
            this.lblFileAttributeOffline.Location = new System.Drawing.Point(8, 224);
            this.lblFileAttributeOffline.Name = "lblFileAttributeOffline";
            this.lblFileAttributeOffline.Size = new System.Drawing.Size(264, 16);
            this.lblFileAttributeOffline.TabIndex = 26;
            this.lblFileAttributeOffline.Text = "lblFileAttributeOffline";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(342, 27);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(56, 24);
            this.btnOpen.TabIndex = 65;
            this.btnOpen.Text = "開檔";
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(342, 146);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(56, 24);
            this.btnEnd.TabIndex = 64;
            this.btnEnd.Text = "結束";
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnFileInfo
            // 
            this.btnFileInfo.Location = new System.Drawing.Point(342, 105);
            this.btnFileInfo.Name = "btnFileInfo";
            this.btnFileInfo.Size = new System.Drawing.Size(56, 24);
            this.btnFileInfo.TabIndex = 63;
            this.btnFileInfo.Text = "屬性";
            this.btnFileInfo.Click += new System.EventHandler(this.btnFileInfo_Click);
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Label1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Label1.Location = new System.Drawing.Point(30, 31);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 20);
            this.Label1.TabIndex = 62;
            this.Label1.Text = "檔名:";
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtSource.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSource.Location = new System.Drawing.Point(110, 27);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(216, 27);
            this.txtSource.TabIndex = 61;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 347);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnFileInfo);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtSource);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnSave;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblFileInfoName;
        internal System.Windows.Forms.Label lblFileInfoDirectoryName;
        internal System.Windows.Forms.Label lblFileInfoSize;
        internal System.Windows.Forms.Label lblFileInfoCreationTime;
        internal System.Windows.Forms.Label lblFileInfoLastAccessTime;
        internal System.Windows.Forms.Label lblFileInfoLastWriteTime;
        internal System.Windows.Forms.Label lblFileAttributeHidden;
        internal System.Windows.Forms.Label lblFileAttributeReadOnly;
        internal System.Windows.Forms.Label lblFileAttributeSystem;
        internal System.Windows.Forms.Label lblFileAttributeOffline;
        internal System.Windows.Forms.Button btnOpen;
        internal System.Windows.Forms.Button btnEnd;
        internal System.Windows.Forms.Button btnFileInfo;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

