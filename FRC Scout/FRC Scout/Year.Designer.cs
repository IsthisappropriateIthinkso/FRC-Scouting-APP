namespace FRC_Scout
{
    partial class frmYear
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
            this.btnYear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnFilm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtYourYear = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(144, 162);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(75, 23);
            this.btnYear.TabIndex = 0;
            this.btnYear.Text = "Go";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "What year?";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(130, 113);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 2;
            // 
            // btnFilm
            // 
            this.btnFilm.Location = new System.Drawing.Point(291, 162);
            this.btnFilm.Name = "btnFilm";
            this.btnFilm.Size = new System.Drawing.Size(75, 23);
            this.btnFilm.TabIndex = 3;
            this.btnFilm.Text = "Your Film";
            this.btnFilm.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "What year for your film?";
            // 
            // txtYourYear
            // 
            this.txtYourYear.Location = new System.Drawing.Point(291, 113);
            this.txtYourYear.Name = "txtYourYear";
            this.txtYourYear.Size = new System.Drawing.Size(100, 20);
            this.txtYourYear.TabIndex = 5;
            // 
            // frmYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtYourYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFilm);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnYear);
            this.Name = "frmYear";
            this.Text = "Year";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnFilm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYourYear;
    }
}