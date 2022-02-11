namespace hit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tmrT = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.lblMiss = new System.Windows.Forms.Label();
            this.lblHit = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.pic2 = new System.Windows.Forms.PictureBox();
            this.pic3 = new System.Windows.Forms.PictureBox();
            this.pic4 = new System.Windows.Forms.PictureBox();
            this.pic5 = new System.Windows.Forms.PictureBox();
            this.pic6 = new System.Windows.Forms.PictureBox();
            this.pic7 = new System.Windows.Forms.PictureBox();
            this.pic8 = new System.Windows.Forms.PictureBox();
            this.pic9 = new System.Windows.Forms.PictureBox();
            this.imgPic = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).BeginInit();
            this.SuspendLayout();
            // 
            // tmrT
            // 
            this.tmrT.Tick += new System.EventHandler(this.tmrT_Tick);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblTime.Location = new System.Drawing.Point(215, 134);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(52, 16);
            this.lblTime.TabIndex = 17;
            this.lblTime.Text = "30.0秒";
            // 
            // lblMiss
            // 
            this.lblMiss.AutoSize = true;
            this.lblMiss.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblMiss.Location = new System.Drawing.Point(215, 191);
            this.lblMiss.Name = "lblMiss";
            this.lblMiss.Size = new System.Drawing.Size(88, 16);
            this.lblMiss.TabIndex = 16;
            this.lblMiss.Text = "失誤： 0 次";
            // 
            // lblHit
            // 
            this.lblHit.AutoSize = true;
            this.lblHit.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblHit.Location = new System.Drawing.Point(215, 163);
            this.lblHit.Name = "lblHit";
            this.lblHit.Size = new System.Drawing.Size(88, 16);
            this.lblHit.TabIndex = 15;
            this.lblHit.Text = "擊中： 0 次";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(215, 99);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 14;
            this.btnStart.Text = "開始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(16, 14);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(60, 60);
            this.pic1.TabIndex = 18;
            this.pic1.TabStop = false;
            this.pic1.Click += new System.EventHandler(this.pic1_Click);
            // 
            // pic2
            // 
            this.pic2.Location = new System.Drawing.Point(82, 14);
            this.pic2.Name = "pic2";
            this.pic2.Size = new System.Drawing.Size(60, 60);
            this.pic2.TabIndex = 18;
            this.pic2.TabStop = false;
            // 
            // pic3
            // 
            this.pic3.Location = new System.Drawing.Point(148, 14);
            this.pic3.Name = "pic3";
            this.pic3.Size = new System.Drawing.Size(60, 60);
            this.pic3.TabIndex = 18;
            this.pic3.TabStop = false;
            // 
            // pic4
            // 
            this.pic4.Location = new System.Drawing.Point(17, 80);
            this.pic4.Name = "pic4";
            this.pic4.Size = new System.Drawing.Size(60, 60);
            this.pic4.TabIndex = 18;
            this.pic4.TabStop = false;
            // 
            // pic5
            // 
            this.pic5.Location = new System.Drawing.Point(83, 80);
            this.pic5.Name = "pic5";
            this.pic5.Size = new System.Drawing.Size(60, 60);
            this.pic5.TabIndex = 18;
            this.pic5.TabStop = false;
            // 
            // pic6
            // 
            this.pic6.Location = new System.Drawing.Point(149, 80);
            this.pic6.Name = "pic6";
            this.pic6.Size = new System.Drawing.Size(60, 60);
            this.pic6.TabIndex = 18;
            this.pic6.TabStop = false;
            // 
            // pic7
            // 
            this.pic7.Location = new System.Drawing.Point(17, 147);
            this.pic7.Name = "pic7";
            this.pic7.Size = new System.Drawing.Size(60, 60);
            this.pic7.TabIndex = 18;
            this.pic7.TabStop = false;
            // 
            // pic8
            // 
            this.pic8.Location = new System.Drawing.Point(83, 147);
            this.pic8.Name = "pic8";
            this.pic8.Size = new System.Drawing.Size(60, 60);
            this.pic8.TabIndex = 18;
            this.pic8.TabStop = false;
            // 
            // pic9
            // 
            this.pic9.Location = new System.Drawing.Point(149, 147);
            this.pic9.Name = "pic9";
            this.pic9.Size = new System.Drawing.Size(60, 60);
            this.pic9.TabIndex = 18;
            this.pic9.TabStop = false;
            // 
            // imgPic
            // 
            this.imgPic.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgPic.ImageStream")));
            this.imgPic.TransparentColor = System.Drawing.Color.Transparent;
            this.imgPic.Images.SetKeyName(0, "hit1.gif");
            this.imgPic.Images.SetKeyName(1, "hit2.gif");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 230);
            this.Controls.Add(this.pic9);
            this.Controls.Add(this.pic6);
            this.Controls.Add(this.pic3);
            this.Controls.Add(this.pic8);
            this.Controls.Add(this.pic5);
            this.Controls.Add(this.pic2);
            this.Controls.Add(this.pic7);
            this.Controls.Add(this.pic4);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblMiss);
            this.Controls.Add(this.lblHit);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "打地鼠";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrT;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblMiss;
        private System.Windows.Forms.Label lblHit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.PictureBox pic2;
        private System.Windows.Forms.PictureBox pic3;
        private System.Windows.Forms.PictureBox pic4;
        private System.Windows.Forms.PictureBox pic5;
        private System.Windows.Forms.PictureBox pic6;
        private System.Windows.Forms.PictureBox pic7;
        private System.Windows.Forms.PictureBox pic8;
        private System.Windows.Forms.PictureBox pic9;
        private System.Windows.Forms.ImageList imgPic;
    }
}

