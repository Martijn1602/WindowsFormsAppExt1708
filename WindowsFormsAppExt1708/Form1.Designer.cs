namespace WindowsFormsAppExt1708
{
    partial class Form1
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
            this.lbWerknemers = new System.Windows.Forms.ListBox();
            this.buttonWNAdd = new System.Windows.Forms.Button();
            this.buttonWNRem = new System.Windows.Forms.Button();
            this.buttonWNShow = new System.Windows.Forms.Button();
            this.buttonAttShow = new System.Windows.Forms.Button();
            this.buttonAttRem = new System.Windows.Forms.Button();
            this.buttonAttAdd = new System.Windows.Forms.Button();
            this.lbAttracties = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbWerknemers
            // 
            this.lbWerknemers.FormattingEnabled = true;
            this.lbWerknemers.Location = new System.Drawing.Point(42, 72);
            this.lbWerknemers.Name = "lbWerknemers";
            this.lbWerknemers.Size = new System.Drawing.Size(128, 173);
            this.lbWerknemers.TabIndex = 0;
            // 
            // buttonWNAdd
            // 
            this.buttonWNAdd.Location = new System.Drawing.Point(42, 261);
            this.buttonWNAdd.Name = "buttonWNAdd";
            this.buttonWNAdd.Size = new System.Drawing.Size(128, 36);
            this.buttonWNAdd.TabIndex = 1;
            this.buttonWNAdd.Text = "Toevoegen";
            this.buttonWNAdd.UseVisualStyleBackColor = true;
            this.buttonWNAdd.Click += new System.EventHandler(this.buttonWNAdd_Click);
            // 
            // buttonWNRem
            // 
            this.buttonWNRem.Location = new System.Drawing.Point(42, 303);
            this.buttonWNRem.Name = "buttonWNRem";
            this.buttonWNRem.Size = new System.Drawing.Size(128, 36);
            this.buttonWNRem.TabIndex = 2;
            this.buttonWNRem.Text = "Verwijderen";
            this.buttonWNRem.UseVisualStyleBackColor = true;
            // 
            // buttonWNShow
            // 
            this.buttonWNShow.Location = new System.Drawing.Point(42, 345);
            this.buttonWNShow.Name = "buttonWNShow";
            this.buttonWNShow.Size = new System.Drawing.Size(128, 36);
            this.buttonWNShow.TabIndex = 3;
            this.buttonWNShow.Text = "Bekijken";
            this.buttonWNShow.UseVisualStyleBackColor = true;
            // 
            // buttonAttShow
            // 
            this.buttonAttShow.Location = new System.Drawing.Point(221, 345);
            this.buttonAttShow.Name = "buttonAttShow";
            this.buttonAttShow.Size = new System.Drawing.Size(128, 36);
            this.buttonAttShow.TabIndex = 7;
            this.buttonAttShow.Text = "Bekijken";
            this.buttonAttShow.UseVisualStyleBackColor = true;
            // 
            // buttonAttRem
            // 
            this.buttonAttRem.Location = new System.Drawing.Point(221, 303);
            this.buttonAttRem.Name = "buttonAttRem";
            this.buttonAttRem.Size = new System.Drawing.Size(128, 36);
            this.buttonAttRem.TabIndex = 6;
            this.buttonAttRem.Text = "Verwijderen";
            this.buttonAttRem.UseVisualStyleBackColor = true;
            // 
            // buttonAttAdd
            // 
            this.buttonAttAdd.Location = new System.Drawing.Point(221, 261);
            this.buttonAttAdd.Name = "buttonAttAdd";
            this.buttonAttAdd.Size = new System.Drawing.Size(128, 36);
            this.buttonAttAdd.TabIndex = 5;
            this.buttonAttAdd.Text = "Toevoegen";
            this.buttonAttAdd.UseVisualStyleBackColor = true;
            // 
            // lbAttracties
            // 
            this.lbAttracties.FormattingEnabled = true;
            this.lbAttracties.Location = new System.Drawing.Point(221, 72);
            this.lbAttracties.Name = "lbAttracties";
            this.lbAttracties.Size = new System.Drawing.Size(128, 173);
            this.lbAttracties.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = " - - -";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = " - - - ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAttShow);
            this.Controls.Add(this.buttonAttRem);
            this.Controls.Add(this.buttonAttAdd);
            this.Controls.Add(this.lbAttracties);
            this.Controls.Add(this.buttonWNShow);
            this.Controls.Add(this.buttonWNRem);
            this.Controls.Add(this.buttonWNAdd);
            this.Controls.Add(this.lbWerknemers);
            this.Name = "Form1";
            this.Text = "Toevoegen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbWerknemers;
        private System.Windows.Forms.Button buttonWNAdd;
        private System.Windows.Forms.Button buttonWNRem;
        private System.Windows.Forms.Button buttonWNShow;
        private System.Windows.Forms.Button buttonAttShow;
        private System.Windows.Forms.Button buttonAttRem;
        private System.Windows.Forms.Button buttonAttAdd;
        private System.Windows.Forms.ListBox lbAttracties;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

