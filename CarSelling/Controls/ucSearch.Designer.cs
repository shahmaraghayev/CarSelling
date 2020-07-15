namespace CarSelling
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
            this.cbAllBrands = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.cbAllModels = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPrice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbManufactureYear = new System.Windows.Forms.ComboBox();
            this.ckbKredit = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ckbBarter = new System.Windows.Forms.CheckBox();
            this.cbAllCities = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMinPrice = new System.Windows.Forms.TextBox();
            this.ManufactureYearMin = new System.Windows.Forms.TextBox();
            this.txtMaksPrice = new System.Windows.Forms.TextBox();
            this.ManufactureYearMax = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAllBrands
            // 
            this.cbAllBrands.AccessibleDescription = "dfd";
            this.cbAllBrands.DisplayMember = "Name";
            this.cbAllBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllBrands.FormattingEnabled = true;
            this.cbAllBrands.Location = new System.Drawing.Point(29, 34);
            this.cbAllBrands.Name = "cbAllBrands";
            this.cbAllBrands.Size = new System.Drawing.Size(136, 26);
            this.cbAllBrands.TabIndex = 0;
            this.cbAllBrands.ValueMember = "Id";
            // 
            // cbAllModels
            // 
            this.cbAllModels.DisplayMember = "Name";
            this.cbAllModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllModels.FormattingEnabled = true;
            this.cbAllModels.Location = new System.Drawing.Point(29, 89);
            this.cbAllModels.Name = "cbAllModels";
            this.cbAllModels.Size = new System.Drawing.Size(136, 26);
            this.cbAllModels.TabIndex = 0;
            this.cbAllModels.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qiymət";
            // 
            // cbPrice
            // 
            this.cbPrice.BackColor = System.Drawing.SystemColors.Info;
            this.cbPrice.DisplayMember = "Name";
            this.cbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(297, 34);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(146, 26);
            this.cbPrice.TabIndex = 2;
            this.cbPrice.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(294, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buraxılış ili";
            // 
            // cbManufactureYear
            // 
            this.cbManufactureYear.DisplayMember = "Name";
            this.cbManufactureYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManufactureYear.FormattingEnabled = true;
            this.cbManufactureYear.Location = new System.Drawing.Point(297, 91);
            this.cbManufactureYear.Name = "cbManufactureYear";
            this.cbManufactureYear.Size = new System.Drawing.Size(146, 26);
            this.cbManufactureYear.TabIndex = 2;
            this.cbManufactureYear.ValueMember = "Id";
            // 
            // ckbKredit
            // 
            this.ckbKredit.AutoSize = true;
            this.ckbKredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKredit.Location = new System.Drawing.Point(941, 38);
            this.ckbKredit.Name = "ckbKredit";
            this.ckbKredit.Size = new System.Drawing.Size(71, 22);
            this.ckbKredit.TabIndex = 4;
            this.ckbKredit.Text = "Kredit";
            this.ckbKredit.UseVisualStyleBackColor = true;
            // 
            // ckbBarter
            // 
            this.ckbBarter.AutoSize = true;
            this.ckbBarter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBarter.Location = new System.Drawing.Point(941, 93);
            this.ckbBarter.Name = "ckbBarter";
            this.ckbBarter.Size = new System.Drawing.Size(73, 22);
            this.ckbBarter.TabIndex = 4;
            this.ckbBarter.Text = "Barter";
            this.ckbBarter.UseVisualStyleBackColor = true;
            // 
            // cbAllCities
            // 
            this.cbAllCities.DisplayMember = "Name";
            this.cbAllCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllCities.FormattingEnabled = true;
            this.cbAllCities.Location = new System.Drawing.Point(1079, 41);
            this.cbAllCities.Name = "cbAllCities";
            this.cbAllCities.Size = new System.Drawing.Size(186, 26);
            this.cbAllCities.TabIndex = 0;
            this.cbAllCities.ValueMember = "Id";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(1079, 93);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Bütün markalar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bütün modellər";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(492, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "min.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(492, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "min.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(714, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "maks.";
            // 
            // txtMinPrice
            // 
            this.txtMinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinPrice.Location = new System.Drawing.Point(495, 38);
            this.txtMinPrice.Name = "txtMinPrice";
            this.txtMinPrice.Size = new System.Drawing.Size(148, 24);
            this.txtMinPrice.TabIndex = 8;
            // 
            // ManufactureYearMin
            // 
            this.ManufactureYearMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufactureYearMin.Location = new System.Drawing.Point(495, 93);
            this.ManufactureYearMin.Name = "ManufactureYearMin";
            this.ManufactureYearMin.Size = new System.Drawing.Size(148, 24);
            this.ManufactureYearMin.TabIndex = 8;
            // 
            // txtMaksPrice
            // 
            this.txtMaksPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaksPrice.Location = new System.Drawing.Point(717, 38);
            this.txtMaksPrice.Name = "txtMaksPrice";
            this.txtMaksPrice.Size = new System.Drawing.Size(166, 24);
            this.txtMaksPrice.TabIndex = 8;
            // 
            // ManufactureYearMax
            // 
            this.ManufactureYearMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManufactureYearMax.Location = new System.Drawing.Point(717, 93);
            this.ManufactureYearMax.Name = "ManufactureYearMax";
            this.ManufactureYearMax.Size = new System.Drawing.Size(166, 24);
            this.ManufactureYearMax.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1076, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bütün şəhərlər";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(714, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "maks.";
            // 
            // ucSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ManufactureYearMax);
            this.Controls.Add(this.txtMaksPrice);
            this.Controls.Add(this.ManufactureYearMin);
            this.Controls.Add(this.txtMinPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ckbBarter);
            this.Controls.Add(this.ckbKredit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbManufactureYear);
            this.Controls.Add(this.cbPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbAllModels);
            this.Controls.Add(this.cbAllCities);
            this.Controls.Add(this.cbAllBrands);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "ucSearch";
            this.Size = new System.Drawing.Size(1268, 171);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAllBrands;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox cbAllModels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbManufactureYear;
        private System.Windows.Forms.CheckBox ckbKredit;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox ckbBarter;
        private System.Windows.Forms.ComboBox cbAllCities;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.TextBox ManufactureYearMin;
        private System.Windows.Forms.TextBox txtMaksPrice;
        private System.Windows.Forms.TextBox ManufactureYearMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
