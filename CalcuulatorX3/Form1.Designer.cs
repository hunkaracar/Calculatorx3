namespace CalcuulatorX3
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
            this.ekranLabel = new System.Windows.Forms.Label();
            this.rakam1button = new System.Windows.Forms.Button();
            this.rakam3button = new System.Windows.Forms.Button();
            this.rakam2button = new System.Windows.Forms.Button();
            this.rakam5button = new System.Windows.Forms.Button();
            this.rakam6button = new System.Windows.Forms.Button();
            this.rakam4button = new System.Windows.Forms.Button();
            this.rakam0button = new System.Windows.Forms.Button();
            this.esittirbutton = new System.Windows.Forms.Button();
            this.temizlebutton = new System.Windows.Forms.Button();
            this.rakam8button = new System.Windows.Forms.Button();
            this.rakam9button = new System.Windows.Forms.Button();
            this.rakam7button = new System.Windows.Forms.Button();
            this.bolmebutton = new System.Windows.Forms.Button();
            this.carpmabutton = new System.Windows.Forms.Button();
            this.cıkarmabutton = new System.Windows.Forms.Button();
            this.toplamabutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekranLabel
            // 
            this.ekranLabel.BackColor = System.Drawing.Color.White;
            this.ekranLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekranLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekranLabel.Location = new System.Drawing.Point(4, 9);
            this.ekranLabel.Name = "ekranLabel";
            this.ekranLabel.Size = new System.Drawing.Size(277, 50);
            this.ekranLabel.TabIndex = 0;
            this.ekranLabel.Text = "0";
            this.ekranLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ekranLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // rakam1button
            // 
            this.rakam1button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam1button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam1button.Location = new System.Drawing.Point(12, 81);
            this.rakam1button.Name = "rakam1button";
            this.rakam1button.Size = new System.Drawing.Size(50, 50);
            this.rakam1button.TabIndex = 1;
            this.rakam1button.Text = "1";
            this.rakam1button.UseVisualStyleBackColor = false;
            this.rakam1button.Click += new System.EventHandler(this.rakam1button_Click);
            // 
            // rakam3button
            // 
            this.rakam3button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam3button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam3button.Location = new System.Drawing.Point(124, 81);
            this.rakam3button.Name = "rakam3button";
            this.rakam3button.Size = new System.Drawing.Size(50, 50);
            this.rakam3button.TabIndex = 4;
            this.rakam3button.Text = "3";
            this.rakam3button.UseVisualStyleBackColor = false;
            this.rakam3button.Click += new System.EventHandler(this.rakam3button_Click);
            // 
            // rakam2button
            // 
            this.rakam2button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam2button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam2button.Location = new System.Drawing.Point(68, 81);
            this.rakam2button.Name = "rakam2button";
            this.rakam2button.Size = new System.Drawing.Size(50, 50);
            this.rakam2button.TabIndex = 5;
            this.rakam2button.Text = "2";
            this.rakam2button.UseVisualStyleBackColor = false;
            this.rakam2button.Click += new System.EventHandler(this.rakam2button_Click);
            // 
            // rakam5button
            // 
            this.rakam5button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam5button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam5button.Location = new System.Drawing.Point(68, 137);
            this.rakam5button.Name = "rakam5button";
            this.rakam5button.Size = new System.Drawing.Size(50, 50);
            this.rakam5button.TabIndex = 8;
            this.rakam5button.Text = "5";
            this.rakam5button.UseVisualStyleBackColor = false;
            this.rakam5button.Click += new System.EventHandler(this.rakam5button_Click);
            // 
            // rakam6button
            // 
            this.rakam6button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam6button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam6button.Location = new System.Drawing.Point(124, 137);
            this.rakam6button.Name = "rakam6button";
            this.rakam6button.Size = new System.Drawing.Size(50, 50);
            this.rakam6button.TabIndex = 7;
            this.rakam6button.Text = "6";
            this.rakam6button.UseVisualStyleBackColor = false;
            this.rakam6button.Click += new System.EventHandler(this.rakam6button_Click);
            // 
            // rakam4button
            // 
            this.rakam4button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam4button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam4button.Location = new System.Drawing.Point(12, 137);
            this.rakam4button.Name = "rakam4button";
            this.rakam4button.Size = new System.Drawing.Size(50, 50);
            this.rakam4button.TabIndex = 6;
            this.rakam4button.Text = "4";
            this.rakam4button.UseVisualStyleBackColor = false;
            this.rakam4button.Click += new System.EventHandler(this.rakam4button_Click);
            // 
            // rakam0button
            // 
            this.rakam0button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam0button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam0button.Location = new System.Drawing.Point(68, 248);
            this.rakam0button.Name = "rakam0button";
            this.rakam0button.Size = new System.Drawing.Size(50, 50);
            this.rakam0button.TabIndex = 14;
            this.rakam0button.Text = "0";
            this.rakam0button.UseVisualStyleBackColor = false;
            this.rakam0button.Click += new System.EventHandler(this.rakam0button_Click);
            // 
            // esittirbutton
            // 
            this.esittirbutton.BackColor = System.Drawing.Color.Orange;
            this.esittirbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.esittirbutton.Location = new System.Drawing.Point(124, 248);
            this.esittirbutton.Name = "esittirbutton";
            this.esittirbutton.Size = new System.Drawing.Size(50, 50);
            this.esittirbutton.TabIndex = 13;
            this.esittirbutton.Text = "=";
            this.esittirbutton.UseVisualStyleBackColor = false;
            this.esittirbutton.Click += new System.EventHandler(this.esittirbutton_Click);
            // 
            // temizlebutton
            // 
            this.temizlebutton.BackColor = System.Drawing.Color.Black;
            this.temizlebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.temizlebutton.ForeColor = System.Drawing.Color.White;
            this.temizlebutton.Location = new System.Drawing.Point(12, 248);
            this.temizlebutton.Name = "temizlebutton";
            this.temizlebutton.Size = new System.Drawing.Size(50, 50);
            this.temizlebutton.TabIndex = 12;
            this.temizlebutton.Text = "C";
            this.temizlebutton.UseVisualStyleBackColor = false;
            this.temizlebutton.Click += new System.EventHandler(this.temizlebutton_Click);
            // 
            // rakam8button
            // 
            this.rakam8button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam8button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam8button.Location = new System.Drawing.Point(68, 192);
            this.rakam8button.Name = "rakam8button";
            this.rakam8button.Size = new System.Drawing.Size(50, 50);
            this.rakam8button.TabIndex = 11;
            this.rakam8button.Text = "8";
            this.rakam8button.UseVisualStyleBackColor = false;
            this.rakam8button.Click += new System.EventHandler(this.rakam8button_Click);
            // 
            // rakam9button
            // 
            this.rakam9button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam9button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam9button.Location = new System.Drawing.Point(124, 192);
            this.rakam9button.Name = "rakam9button";
            this.rakam9button.Size = new System.Drawing.Size(50, 50);
            this.rakam9button.TabIndex = 10;
            this.rakam9button.Text = "9";
            this.rakam9button.UseVisualStyleBackColor = false;
            this.rakam9button.Click += new System.EventHandler(this.rakam9button_Click);
            // 
            // rakam7button
            // 
            this.rakam7button.BackColor = System.Drawing.Color.DarkGray;
            this.rakam7button.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rakam7button.Location = new System.Drawing.Point(12, 192);
            this.rakam7button.Name = "rakam7button";
            this.rakam7button.Size = new System.Drawing.Size(50, 50);
            this.rakam7button.TabIndex = 9;
            this.rakam7button.Text = "7";
            this.rakam7button.UseVisualStyleBackColor = false;
            this.rakam7button.Click += new System.EventHandler(this.rakam7button_Click);
            // 
            // bolmebutton
            // 
            this.bolmebutton.BackColor = System.Drawing.Color.Red;
            this.bolmebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolmebutton.Location = new System.Drawing.Point(220, 248);
            this.bolmebutton.Name = "bolmebutton";
            this.bolmebutton.Size = new System.Drawing.Size(50, 50);
            this.bolmebutton.TabIndex = 18;
            this.bolmebutton.Text = "/";
            this.bolmebutton.UseVisualStyleBackColor = false;
            this.bolmebutton.Click += new System.EventHandler(this.bolmebutton_Click);
            // 
            // carpmabutton
            // 
            this.carpmabutton.BackColor = System.Drawing.Color.Red;
            this.carpmabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpmabutton.Location = new System.Drawing.Point(220, 192);
            this.carpmabutton.Name = "carpmabutton";
            this.carpmabutton.Size = new System.Drawing.Size(50, 50);
            this.carpmabutton.TabIndex = 17;
            this.carpmabutton.Text = "X";
            this.carpmabutton.UseVisualStyleBackColor = false;
            this.carpmabutton.Click += new System.EventHandler(this.carpmabutton_Click);
            // 
            // cıkarmabutton
            // 
            this.cıkarmabutton.BackColor = System.Drawing.Color.Red;
            this.cıkarmabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cıkarmabutton.Location = new System.Drawing.Point(220, 137);
            this.cıkarmabutton.Name = "cıkarmabutton";
            this.cıkarmabutton.Size = new System.Drawing.Size(50, 50);
            this.cıkarmabutton.TabIndex = 16;
            this.cıkarmabutton.Text = "-";
            this.cıkarmabutton.UseVisualStyleBackColor = false;
            this.cıkarmabutton.Click += new System.EventHandler(this.cıkarmabutton_Click);
            // 
            // toplamabutton
            // 
            this.toplamabutton.BackColor = System.Drawing.Color.Red;
            this.toplamabutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplamabutton.Location = new System.Drawing.Point(220, 81);
            this.toplamabutton.Name = "toplamabutton";
            this.toplamabutton.Size = new System.Drawing.Size(50, 50);
            this.toplamabutton.TabIndex = 15;
            this.toplamabutton.Text = "+";
            this.toplamabutton.UseVisualStyleBackColor = false;
            this.toplamabutton.Click += new System.EventHandler(this.toplamabutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 338);
            this.Controls.Add(this.bolmebutton);
            this.Controls.Add(this.carpmabutton);
            this.Controls.Add(this.cıkarmabutton);
            this.Controls.Add(this.toplamabutton);
            this.Controls.Add(this.rakam0button);
            this.Controls.Add(this.esittirbutton);
            this.Controls.Add(this.temizlebutton);
            this.Controls.Add(this.rakam8button);
            this.Controls.Add(this.rakam9button);
            this.Controls.Add(this.rakam7button);
            this.Controls.Add(this.rakam5button);
            this.Controls.Add(this.rakam6button);
            this.Controls.Add(this.rakam4button);
            this.Controls.Add(this.rakam2button);
            this.Controls.Add(this.rakam3button);
            this.Controls.Add(this.rakam1button);
            this.Controls.Add(this.ekranLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorX3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekranLabel;
        private System.Windows.Forms.Button rakam1button;
        private System.Windows.Forms.Button rakam3button;
        private System.Windows.Forms.Button rakam2button;
        private System.Windows.Forms.Button rakam5button;
        private System.Windows.Forms.Button rakam6button;
        private System.Windows.Forms.Button rakam4button;
        private System.Windows.Forms.Button rakam0button;
        private System.Windows.Forms.Button esittirbutton;
        private System.Windows.Forms.Button temizlebutton;
        private System.Windows.Forms.Button rakam8button;
        private System.Windows.Forms.Button rakam9button;
        private System.Windows.Forms.Button rakam7button;
        private System.Windows.Forms.Button bolmebutton;
        private System.Windows.Forms.Button carpmabutton;
        private System.Windows.Forms.Button cıkarmabutton;
        private System.Windows.Forms.Button toplamabutton;
    }
}

