namespace EersteFormsApp
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
            this.btnToonNaam = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnToonNaam
            // 
            this.btnToonNaam.Location = new System.Drawing.Point(351, 358);
            this.btnToonNaam.Name = "btnToonNaam";
            this.btnToonNaam.Size = new System.Drawing.Size(75, 23);
            this.btnToonNaam.TabIndex = 0;
            this.btnToonNaam.Text = "Toon naam";
            this.btnToonNaam.UseVisualStyleBackColor = true;
            this.btnToonNaam.Click += new System.EventHandler(this.btnToonNaam_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(351, 332);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(100, 20);
            this.txtNaam.TabIndex = 1;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(254, 335);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(91, 13);
            this.lblNaam.TabIndex = 3;
            this.lblNaam.Text = "Geef je naam op: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnToonNaam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToonNaam;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.Label lblNaam;
    }
}

