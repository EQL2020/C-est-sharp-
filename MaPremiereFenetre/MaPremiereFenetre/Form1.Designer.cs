
namespace MaPremiereFenetre
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maListeDeroulante = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "gtgt";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(233, 65);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(94, 29);
            this.buttonValider.TabIndex = 1;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            this.buttonValider.MouseCaptureChanged += new System.EventHandler(this.buttonValider_MouseCaptureChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(233, 150);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(151, 27);
            this.textBox1.TabIndex = 2;
            // 
            // maListeDeroulante
            // 
            this.maListeDeroulante.FormattingEnabled = true;
            this.maListeDeroulante.Location = new System.Drawing.Point(442, 65);
            this.maListeDeroulante.Name = "maListeDeroulante";
            this.maListeDeroulante.Size = new System.Drawing.Size(151, 28);
            this.maListeDeroulante.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maListeDeroulante);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox maListeDeroulante;
    }
}

