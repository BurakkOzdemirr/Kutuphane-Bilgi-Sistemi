namespace database_proje
{
    partial class pgiriscs
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
            this.button1 = new System.Windows.Forms.Button();
            this.bi = new System.Windows.Forms.Button();
            this.bg = new System.Windows.Forms.Button();
            this.tbs = new System.Windows.Forms.TextBox();
            this.tbka = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Şifremi Unuttum";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bi
            // 
            this.bi.Location = new System.Drawing.Point(171, 86);
            this.bi.Name = "bi";
            this.bi.Size = new System.Drawing.Size(75, 23);
            this.bi.TabIndex = 20;
            this.bi.Text = "İPTAL";
            this.bi.UseVisualStyleBackColor = true;
            this.bi.Click += new System.EventHandler(this.bi_Click);
            // 
            // bg
            // 
            this.bg.Location = new System.Drawing.Point(28, 86);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(75, 23);
            this.bg.TabIndex = 19;
            this.bg.Text = "GİRİŞ";
            this.bg.UseVisualStyleBackColor = true;
            this.bg.Click += new System.EventHandler(this.bg_Click);
            // 
            // tbs
            // 
            this.tbs.Location = new System.Drawing.Point(125, 39);
            this.tbs.Name = "tbs";
            this.tbs.PasswordChar = '*';
            this.tbs.Size = new System.Drawing.Size(121, 20);
            this.tbs.TabIndex = 18;
            // 
            // tbka
            // 
            this.tbka.Location = new System.Drawing.Point(125, 9);
            this.tbka.Name = "tbka";
            this.tbka.Size = new System.Drawing.Size(121, 20);
            this.tbka.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(67, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şifre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // pgiriscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(266, 180);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bi);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.tbs);
            this.Controls.Add(this.tbka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "pgiriscs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel Giriş";
            this.Activated += new System.EventHandler(this.pgiriscs_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bi;
        private System.Windows.Forms.Button bg;
        private System.Windows.Forms.TextBox tbs;
        private System.Windows.Forms.TextBox tbka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;

    }
}