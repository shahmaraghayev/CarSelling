namespace CarSelling.Controls
{
    partial class ucSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbModel = new System.Windows.Forms.ComboBox();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.ckbKredit = new System.Windows.Forms.CheckBox();
            this.ckbBarter = new System.Windows.Forms.CheckBox();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numercMinPrice = new System.Windows.Forms.NumericUpDown();
            this.numericMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.dtpMinYear = new System.Windows.Forms.DateTimePicker();
            this.dtpMaxYear = new System.Windows.Forms.DateTimePicker();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numercMinPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPrice)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbModel
            // 
            this.cbModel.DisplayMember = "Name";
            this.cbModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbModel.FormattingEnabled = true;
            this.cbModel.Location = new System.Drawing.Point(35, 113);
            this.cbModel.Name = "cbModel";
            this.cbModel.Size = new System.Drawing.Size(148, 26);
            this.cbModel.TabIndex = 1;
            this.cbModel.ValueMember = "Id";
            // 
            // cbMarka
            // 
            this.cbMarka.DisplayMember = "Name";
            this.cbMarka.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(35, 44);
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(148, 26);
            this.cbMarka.TabIndex = 0;
            this.cbMarka.ValueMember = "Id";
            // 
            // ckbKredit
            // 
            this.ckbKredit.AutoSize = true;
            this.ckbKredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKredit.Location = new System.Drawing.Point(703, 46);
            this.ckbKredit.Name = "ckbKredit";
            this.ckbKredit.Size = new System.Drawing.Size(71, 22);
            this.ckbKredit.TabIndex = 9;
            this.ckbKredit.Text = "Kredit";
            this.ckbKredit.UseVisualStyleBackColor = true;
            // 
            // ckbBarter
            // 
            this.ckbBarter.AutoSize = true;
            this.ckbBarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBarter.Location = new System.Drawing.Point(701, 111);
            this.ckbBarter.Name = "ckbBarter";
            this.ckbBarter.Size = new System.Drawing.Size(73, 22);
            this.ckbBarter.TabIndex = 10;
            this.ckbBarter.Text = "Barter";
            this.ckbBarter.UseVisualStyleBackColor = true;
            // 
            // cmbCity
            // 
            this.cmbCity.DisplayMember = "Name";
            this.cmbCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(947, 50);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(119, 26);
            this.cmbCity.TabIndex = 11;
            this.cmbCity.ValueMember = "Id";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(27)))), ((int)(((byte)(37)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(947, 91);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(119, 35);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bütün markalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bütün modellər";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Qiymət";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(250, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 18);
            this.label4.TabIndex = 16;
            this.label4.Text = "Büraxılış ili";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(358, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 18;
            this.label6.Text = "min.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(358, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 18);
            this.label7.TabIndex = 19;
            this.label7.Text = "min.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(513, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 20;
            this.label8.Text = "maks.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(824, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bütün şəhərlər";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(513, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 22;
            this.label10.Text = "maks.";
            // 
            // numercMinPrice
            // 
            this.numercMinPrice.Location = new System.Drawing.Point(404, 42);
            this.numercMinPrice.Name = "numercMinPrice";
            this.numercMinPrice.Size = new System.Drawing.Size(74, 20);
            this.numercMinPrice.TabIndex = 23;
            // 
            // numericMaxPrice
            // 
            this.numericMaxPrice.Location = new System.Drawing.Point(579, 42);
            this.numericMaxPrice.Name = "numericMaxPrice";
            this.numericMaxPrice.Size = new System.Drawing.Size(74, 20);
            this.numericMaxPrice.TabIndex = 23;
            // 
            // dtpMinYear
            // 
            this.dtpMinYear.Location = new System.Drawing.Point(404, 108);
            this.dtpMinYear.Name = "dtpMinYear";
            this.dtpMinYear.Size = new System.Drawing.Size(74, 20);
            this.dtpMinYear.TabIndex = 24;
            // 
            // dtpMaxYear
            // 
            this.dtpMaxYear.Location = new System.Drawing.Point(579, 108);
            this.dtpMaxYear.Name = "dtpMaxYear";
            this.dtpMaxYear.Size = new System.Drawing.Size(74, 20);
            this.dtpMaxYear.TabIndex = 24;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.btnSearch);
            this.pnlTop.Controls.Add(this.cbMarka);
            this.pnlTop.Controls.Add(this.dtpMaxYear);
            this.pnlTop.Controls.Add(this.cbModel);
            this.pnlTop.Controls.Add(this.dtpMinYear);
            this.pnlTop.Controls.Add(this.ckbKredit);
            this.pnlTop.Controls.Add(this.numericMaxPrice);
            this.pnlTop.Controls.Add(this.ckbBarter);
            this.pnlTop.Controls.Add(this.numercMinPrice);
            this.pnlTop.Controls.Add(this.cmbCity);
            this.pnlTop.Controls.Add(this.label10);
            this.pnlTop.Controls.Add(this.label1);
            this.pnlTop.Controls.Add(this.label9);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.label8);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label7);
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label6);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1170, 181);
            this.pnlTop.TabIndex = 25;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 181);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1170, 326);
            this.pnlMain.TabIndex = 26;
            // 
            // pnlFooter
            // 
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 471);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1170, 36);
            this.pnlFooter.TabIndex = 27;
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(1170, 507);
            this.Load += new System.EventHandler(this.ucSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numercMinPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxPrice)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbModel;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.CheckBox ckbKredit;
        private System.Windows.Forms.CheckBox ckbBarter;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numercMinPrice;
        private System.Windows.Forms.NumericUpDown numericMaxPrice;
        private System.Windows.Forms.DateTimePicker dtpMinYear;
        private System.Windows.Forms.DateTimePicker dtpMaxYear;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlFooter;
    }
}
