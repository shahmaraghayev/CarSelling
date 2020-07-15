namespace CarSelling
{
    partial class frmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPostAd = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.ucSearchResult1 = new CarSelling.ucSearchResult();
            this.panel1.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(78)))));
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnPostAd);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1169, 37);
            this.panel1.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnUser.Location = new System.Drawing.Point(780, 0);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(184, 37);
            this.btnUser.TabIndex = 3;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnPostAd
            // 
            this.btnPostAd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(233)))), ((int)(((byte)(146)))));
            this.btnPostAd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnPostAd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostAd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPostAd.Location = new System.Drawing.Point(964, 0);
            this.btnPostAd.Name = "btnPostAd";
            this.btnPostAd.Size = new System.Drawing.Size(146, 37);
            this.btnPostAd.TabIndex = 2;
            this.btnPostAd.Text = "Elan yerləşdir";
            this.btnPostAd.UseVisualStyleBackColor = false;
            this.btnPostAd.Click += new System.EventHandler(this.btnPostAd_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Gray;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(1110, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(59, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Giriş";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // pnlSearch
            // 
            
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 37);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1169, 131);
            this.pnlSearch.TabIndex = 1;
            // 
            // ucSearchResult1
            // 
            this.ucSearchResult1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ucSearchResult1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucSearchResult1.Location = new System.Drawing.Point(0, 168);
            this.ucSearchResult1.Name = "ucSearchResult1";
            this.ucSearchResult1.Size = new System.Drawing.Size(1169, 318);
            this.ucSearchResult1.TabIndex = 2;
          
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1169, 486);
            this.Controls.Add(this.ucSearchResult1);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.panel1);
            this.Name = "frmMain";
            this.Text = "MAŞIN ALQI SATQISI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPostAd;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel pnlSearch;
      
        private ucSearchResult ucSearchResult1;
        private System.Windows.Forms.Button btnUser;
    }
}

