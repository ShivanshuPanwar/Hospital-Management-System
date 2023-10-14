namespace HMS_By_Shiva
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnAddDiagnosis = new System.Windows.Forms.Button();
            this.btnFullHistory = new System.Windows.Forms.Button();
            this.btnHospital = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelIndecator1 = new System.Windows.Forms.Label();
            this.labelIndecator2 = new System.Windows.Forms.Label();
            this.labelIndecator3 = new System.Windows.Forms.Label();
            this.labelIndecator4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddPatient.Location = new System.Drawing.Point(44, 120);
            this.btnAddPatient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(221, 46);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add New Patient Record";
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnAddDiagnosis
            // 
            this.btnAddDiagnosis.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAddDiagnosis.Location = new System.Drawing.Point(44, 174);
            this.btnAddDiagnosis.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDiagnosis.Name = "btnAddDiagnosis";
            this.btnAddDiagnosis.Size = new System.Drawing.Size(221, 46);
            this.btnAddDiagnosis.TabIndex = 1;
            this.btnAddDiagnosis.Text = "Add Diagnosis Information";
            this.btnAddDiagnosis.UseVisualStyleBackColor = false;
            this.btnAddDiagnosis.Click += new System.EventHandler(this.btnAddDiagnosis_Click);
            // 
            // btnFullHistory
            // 
            this.btnFullHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFullHistory.Location = new System.Drawing.Point(44, 228);
            this.btnFullHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnFullHistory.Name = "btnFullHistory";
            this.btnFullHistory.Size = new System.Drawing.Size(221, 46);
            this.btnFullHistory.TabIndex = 2;
            this.btnFullHistory.Text = "Full History of the Patient";
            this.btnFullHistory.UseVisualStyleBackColor = false;
            this.btnFullHistory.Click += new System.EventHandler(this.btnFullHistory_Click);
            // 
            // btnHospital
            // 
            this.btnHospital.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnHospital.Location = new System.Drawing.Point(44, 281);
            this.btnHospital.Margin = new System.Windows.Forms.Padding(4);
            this.btnHospital.Name = "btnHospital";
            this.btnHospital.Size = new System.Drawing.Size(221, 46);
            this.btnHospital.TabIndex = 3;
            this.btnHospital.Text = "Hospital Information";
            this.btnHospital.UseVisualStyleBackColor = false;
            this.btnHospital.Click += new System.EventHandler(this.btnHospital_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Controler";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(300, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 421);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(511, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hospital Management System";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.Location = new System.Drawing.Point(78, 350);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 54);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelIndecator1
            // 
            this.labelIndecator1.AutoSize = true;
            this.labelIndecator1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator1.Location = new System.Drawing.Point(8, 129);
            this.labelIndecator1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIndecator1.Name = "labelIndecator1";
            this.labelIndecator1.Size = new System.Drawing.Size(28, 25);
            this.labelIndecator1.TabIndex = 8;
            this.labelIndecator1.Text = "🡺";
            // 
            // labelIndecator2
            // 
            this.labelIndecator2.AutoSize = true;
            this.labelIndecator2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator2.Location = new System.Drawing.Point(8, 183);
            this.labelIndecator2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIndecator2.Name = "labelIndecator2";
            this.labelIndecator2.Size = new System.Drawing.Size(28, 25);
            this.labelIndecator2.TabIndex = 9;
            this.labelIndecator2.Text = "🡺";
            // 
            // labelIndecator3
            // 
            this.labelIndecator3.AutoSize = true;
            this.labelIndecator3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator3.Location = new System.Drawing.Point(8, 237);
            this.labelIndecator3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIndecator3.Name = "labelIndecator3";
            this.labelIndecator3.Size = new System.Drawing.Size(28, 25);
            this.labelIndecator3.TabIndex = 10;
            this.labelIndecator3.Text = "🡺";
            // 
            // labelIndecator4
            // 
            this.labelIndecator4.AutoSize = true;
            this.labelIndecator4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndecator4.Location = new System.Drawing.Point(8, 290);
            this.labelIndecator4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIndecator4.Name = "labelIndecator4";
            this.labelIndecator4.Size = new System.Drawing.Size(28, 25);
            this.labelIndecator4.TabIndex = 11;
            this.labelIndecator4.Text = "🡺";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1104, 450);
            this.Controls.Add(this.labelIndecator4);
            this.Controls.Add(this.labelIndecator3);
            this.Controls.Add(this.labelIndecator2);
            this.Controls.Add(this.labelIndecator1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHospital);
            this.Controls.Add(this.btnFullHistory);
            this.Controls.Add(this.btnAddDiagnosis);
            this.Controls.Add(this.btnAddPatient);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnAddDiagnosis;
        private System.Windows.Forms.Button btnFullHistory;
        private System.Windows.Forms.Button btnHospital;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelIndecator1;
        private System.Windows.Forms.Label labelIndecator2;
        private System.Windows.Forms.Label labelIndecator3;
        private System.Windows.Forms.Label labelIndecator4;
    }
}