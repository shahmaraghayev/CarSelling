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
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtMin2 = new System.Windows.Forms.TextBox();
            this.txtMaks = new System.Windows.Forms.TextBox();
            this.txtMaks2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAllBrands
            // 
            this.cbAllBrands.AccessibleDescription = "dfd";
            this.cbAllBrands.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllBrands.FormattingEnabled = true;
            this.cbAllBrands.Location = new System.Drawing.Point(29, 41);
            this.cbAllBrands.Name = "cbAllBrands";
            this.cbAllBrands.Size = new System.Drawing.Size(136, 26);
            this.cbAllBrands.TabIndex = 0;
            this.cbAllBrands.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbAllModels
            // 
            this.cbAllModels.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllModels.FormattingEnabled = true;
            this.cbAllModels.Location = new System.Drawing.Point(29, 89);
            this.cbAllModels.Name = "cbAllModels";
            this.cbAllModels.Size = new System.Drawing.Size(136, 26);
            this.cbAllModels.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Qiymət";
            // 
            // cbPrice
            // 
            this.cbPrice.BackColor = System.Drawing.SystemColors.Info;
            this.cbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPrice.FormattingEnabled = true;
            this.cbPrice.Location = new System.Drawing.Point(295, 41);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(146, 26);
            this.cbPrice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buraxılış ili";
            // 
            // cbManufactureYear
            // 
            this.cbManufactureYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbManufactureYear.FormattingEnabled = true;
            this.cbManufactureYear.Location = new System.Drawing.Point(297, 86);
            this.cbManufactureYear.Name = "cbManufactureYear";
            this.cbManufactureYear.Size = new System.Drawing.Size(146, 26);
            this.cbManufactureYear.TabIndex = 2;
            // 
            // ckbKredit
            // 
            this.ckbKredit.AutoSize = true;
            this.ckbKredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbKredit.Location = new System.Drawing.Point(901, 43);
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
            this.ckbBarter.Location = new System.Drawing.Point(901, 83);
            this.ckbBarter.Name = "ckbBarter";
            this.ckbBarter.Size = new System.Drawing.Size(73, 22);
            this.ckbBarter.TabIndex = 4;
            this.ckbBarter.Text = "Barter";
            this.ckbBarter.UseVisualStyleBackColor = true;
            // 
            // cbAllCities
            // 
            this.cbAllCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAllCities.FormattingEnabled = true;
            this.cbAllCities.Location = new System.Drawing.Point(1007, 39);
            this.cbAllCities.Name = "cbAllCities";
            this.cbAllCities.Size = new System.Drawing.Size(186, 26);
            this.cbAllCities.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(16)))), ((int)(((byte)(22)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(1007, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(186, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Axtar";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 15);
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
            this.label5.Location = new System.Drawing.Point(457, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "min.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "min.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(658, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 7;
            this.label7.Text = "maks.";
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin.Location = new System.Drawing.Point(495, 39);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(148, 24);
            this.txtMin.TabIndex = 8;
            // 
            // txtMin2
            // 
            this.txtMin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMin2.Location = new System.Drawing.Point(504, 86);
            this.txtMin2.Name = "txtMin2";
            this.txtMin2.Size = new System.Drawing.Size(148, 24);
            this.txtMin2.TabIndex = 8;
            // 
            // txtMaks
            // 
            this.txtMaks.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaks.Location = new System.Drawing.Point(717, 39);
            this.txtMaks.Name = "txtMaks";
            this.txtMaks.Size = new System.Drawing.Size(166, 24);
            this.txtMaks.TabIndex = 8;
            // 
            // txtMaks2
            // 
            this.txtMaks2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaks2.Location = new System.Drawing.Point(717, 86);
            this.txtMaks2.Name = "txtMaks2";
            this.txtMaks2.Size = new System.Drawing.Size(166, 24);
            this.txtMaks2.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1004, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 18);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bütün şəhərlər";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(658, 46);
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
            this.Controls.Add(this.txtMaks2);
            this.Controls.Add(this.txtMaks);
            this.Controls.Add(this.txtMin2);
            this.Controls.Add(this.txtMin);
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
            this.Size = new System.Drawing.Size(1244, 171);
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
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtMin2;
        private System.Windows.Forms.TextBox txtMaks;
        private System.Windows.Forms.TextBox txtMaks2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
