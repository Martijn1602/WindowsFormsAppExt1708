namespace WindowsFormsAppExt1708
{
    partial class Werknemer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtGeboortedatum = new System.Windows.Forms.DateTimePicker();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.btnCreateEmpl = new System.Windows.Forms.Button();
            this.gbGeslacht = new System.Windows.Forms.GroupBox();
            this.gbGeslacht.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Geboortedatum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Geslacht";
            // 
            // dtGeboortedatum
            // 
            this.dtGeboortedatum.Location = new System.Drawing.Point(122, 57);
            this.dtGeboortedatum.Name = "dtGeboortedatum";
            this.dtGeboortedatum.Size = new System.Drawing.Size(200, 20);
            this.dtGeboortedatum.TabIndex = 3;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(121, 33);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(200, 20);
            this.txtNaam.TabIndex = 4;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Man";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(128, 19);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Vrouw";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // btnCreateEmpl
            // 
            this.btnCreateEmpl.Location = new System.Drawing.Point(121, 148);
            this.btnCreateEmpl.Name = "btnCreateEmpl";
            this.btnCreateEmpl.Size = new System.Drawing.Size(197, 23);
            this.btnCreateEmpl.TabIndex = 7;
            this.btnCreateEmpl.Text = "Toevoegen";
            this.btnCreateEmpl.UseVisualStyleBackColor = true;
            this.btnCreateEmpl.Click += new System.EventHandler(this.btnCreateEmpl_Click);
            // 
            // gbGeslacht
            // 
            this.gbGeslacht.Controls.Add(this.radioButton1);
            this.gbGeslacht.Controls.Add(this.radioButton2);
            this.gbGeslacht.Location = new System.Drawing.Point(121, 86);
            this.gbGeslacht.Name = "gbGeslacht";
            this.gbGeslacht.Size = new System.Drawing.Size(200, 45);
            this.gbGeslacht.TabIndex = 8;
            this.gbGeslacht.TabStop = false;
            // 
            // Werknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 193);
            this.Controls.Add(this.gbGeslacht);
            this.Controls.Add(this.btnCreateEmpl);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.dtGeboortedatum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Werknemer";
            this.Text = "Werknemer";
            this.gbGeslacht.ResumeLayout(false);
            this.gbGeslacht.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtGeboortedatum;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button btnCreateEmpl;
        private System.Windows.Forms.GroupBox gbGeslacht;
    }
}