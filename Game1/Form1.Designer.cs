namespace Game1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Start = new System.Windows.Forms.Button();
            this.gamestartsin = new System.Windows.Forms.Label();
            this.countdown3 = new System.Windows.Forms.Label();
            this.countdown2_ = new System.Windows.Forms.Label();
            this.countdown1 = new System.Windows.Forms.Label();
            this.Begin = new System.Windows.Forms.Label();
            this.loadingscreen = new System.Windows.Forms.PictureBox();
            this.dot1 = new System.Windows.Forms.Label();
            this.dot2 = new System.Windows.Forms.Label();
            this.dot3 = new System.Windows.Forms.Label();
            this.beginscreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loadingscreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginscreen)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Goldenrod;
            this.Start.Font = new System.Drawing.Font("Cooper Black", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Start.Location = new System.Drawing.Point(257, 454);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(477, 75);
            this.Start.TabIndex = 1;
            this.Start.Text = "START";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // gamestartsin
            // 
            this.gamestartsin.BackColor = System.Drawing.Color.Transparent;
            this.gamestartsin.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gamestartsin.Location = new System.Drawing.Point(259, 458);
            this.gamestartsin.Name = "gamestartsin";
            this.gamestartsin.Size = new System.Drawing.Size(258, 67);
            this.gamestartsin.TabIndex = 2;
            this.gamestartsin.Text = "Game Starts In";
            this.gamestartsin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gamestartsin.Click += new System.EventHandler(this.gamestarts_Click);
            // 
            // countdown3
            // 
            this.countdown3.BackColor = System.Drawing.Color.Transparent;
            this.countdown3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown3.Location = new System.Drawing.Point(574, 458);
            this.countdown3.Name = "countdown3";
            this.countdown3.Size = new System.Drawing.Size(50, 67);
            this.countdown3.TabIndex = 3;
            this.countdown3.Text = "3";
            this.countdown3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown3.Click += new System.EventHandler(this.countdown3_Click);
            // 
            // countdown2_
            // 
            this.countdown2_.BackColor = System.Drawing.Color.Transparent;
            this.countdown2_.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown2_.Location = new System.Drawing.Point(574, 458);
            this.countdown2_.Name = "countdown2_";
            this.countdown2_.Size = new System.Drawing.Size(50, 67);
            this.countdown2_.TabIndex = 4;
            this.countdown2_.Text = "2";
            this.countdown2_.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown2_.Click += new System.EventHandler(this.countdown2_Click);
            // 
            // countdown1
            // 
            this.countdown1.BackColor = System.Drawing.Color.Transparent;
            this.countdown1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdown1.Location = new System.Drawing.Point(574, 458);
            this.countdown1.Name = "countdown1";
            this.countdown1.Size = new System.Drawing.Size(50, 67);
            this.countdown1.TabIndex = 5;
            this.countdown1.Text = "1";
            this.countdown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdown1.Click += new System.EventHandler(this.countdown1_Click);
            // 
            // Begin
            // 
            this.Begin.BackColor = System.Drawing.Color.Transparent;
            this.Begin.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Begin.Location = new System.Drawing.Point(320, 225);
            this.Begin.Name = "Begin";
            this.Begin.Size = new System.Drawing.Size(373, 67);
            this.Begin.TabIndex = 6;
            this.Begin.Text = "Begin!";
            this.Begin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loadingscreen
            // 
            this.loadingscreen.BackColor = System.Drawing.Color.Transparent;
            this.loadingscreen.Image = ((System.Drawing.Image)(resources.GetObject("loadingscreen.Image")));
            this.loadingscreen.Location = new System.Drawing.Point(1, -12);
            this.loadingscreen.Name = "loadingscreen";
            this.loadingscreen.Size = new System.Drawing.Size(1031, 603);
            this.loadingscreen.TabIndex = 7;
            this.loadingscreen.TabStop = false;
            this.loadingscreen.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dot1
            // 
            this.dot1.BackColor = System.Drawing.Color.Transparent;
            this.dot1.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.dot1.Location = new System.Drawing.Point(514, 471);
            this.dot1.Name = "dot1";
            this.dot1.Size = new System.Drawing.Size(23, 67);
            this.dot1.TabIndex = 8;
            this.dot1.Text = ".";
            this.dot1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dot2
            // 
            this.dot2.BackColor = System.Drawing.Color.Transparent;
            this.dot2.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot2.Location = new System.Drawing.Point(533, 471);
            this.dot2.Name = "dot2";
            this.dot2.Size = new System.Drawing.Size(24, 67);
            this.dot2.TabIndex = 9;
            this.dot2.Text = ".";
            this.dot2.Click += new System.EventHandler(this.dot2_Click);
            // 
            // dot3
            // 
            this.dot3.BackColor = System.Drawing.Color.Transparent;
            this.dot3.Font = new System.Drawing.Font("Georgia", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dot3.Location = new System.Drawing.Point(552, 471);
            this.dot3.Name = "dot3";
            this.dot3.Size = new System.Drawing.Size(25, 67);
            this.dot3.TabIndex = 10;
            this.dot3.Text = ".";
            this.dot3.Click += new System.EventHandler(this.dot3_Click);
            // 
            // beginscreen
            // 
            this.beginscreen.BackColor = System.Drawing.Color.Transparent;
            this.beginscreen.Image = ((System.Drawing.Image)(resources.GetObject("beginscreen.Image")));
            this.beginscreen.Location = new System.Drawing.Point(-11, -12);
            this.beginscreen.Name = "beginscreen";
            this.beginscreen.Size = new System.Drawing.Size(1223, 653);
            this.beginscreen.TabIndex = 13;
            this.beginscreen.TabStop = false;
            this.beginscreen.Click += new System.EventHandler(this.beginscreen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 583);
            this.Controls.Add(this.countdown1);
            this.Controls.Add(this.dot2);
            this.Controls.Add(this.dot3);
            this.Controls.Add(this.gamestartsin);
            this.Controls.Add(this.dot1);
            this.Controls.Add(this.Begin);
            this.Controls.Add(this.countdown2_);
            this.Controls.Add(this.countdown3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.beginscreen);
            this.Controls.Add(this.loadingscreen);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingscreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beginscreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label gamestartsin;
        private System.Windows.Forms.Label countdown3;
        private System.Windows.Forms.Label countdown2_;
        private System.Windows.Forms.Label countdown1;
        private System.Windows.Forms.Label Begin;
        private System.Windows.Forms.PictureBox loadingscreen;
        private System.Windows.Forms.Label dot1;
        private System.Windows.Forms.Label dot2;
        private System.Windows.Forms.Label dot3;
        private System.Windows.Forms.PictureBox beginscreen;
    }
}

