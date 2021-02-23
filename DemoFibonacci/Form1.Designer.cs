namespace DemoFibonacci
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBrClanova = new System.Windows.Forms.TextBox();
            this.btnGenerisi = new System.Windows.Forms.Button();
            this.txtRichPrikazi = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj clanova niza:";
            // 
            // txtBrClanova
            // 
            this.txtBrClanova.Location = new System.Drawing.Point(154, 61);
            this.txtBrClanova.Name = "txtBrClanova";
            this.txtBrClanova.Size = new System.Drawing.Size(76, 20);
            this.txtBrClanova.TabIndex = 1;
            this.txtBrClanova.TextChanged += new System.EventHandler(this.txtBrClanova_TextChanged);
            // 
            // btnGenerisi
            // 
            this.btnGenerisi.Location = new System.Drawing.Point(50, 123);
            this.btnGenerisi.Name = "btnGenerisi";
            this.btnGenerisi.Size = new System.Drawing.Size(168, 36);
            this.btnGenerisi.TabIndex = 2;
            this.btnGenerisi.Text = "Generisi Fib. niz";
            this.btnGenerisi.UseVisualStyleBackColor = true;
            this.btnGenerisi.Click += new System.EventHandler(this.btnGenerisi_Click);
            // 
            // txtRichPrikazi
            // 
            this.txtRichPrikazi.Location = new System.Drawing.Point(393, 52);
            this.txtRichPrikazi.Name = "txtRichPrikazi";
            this.txtRichPrikazi.Size = new System.Drawing.Size(252, 329);
            this.txtRichPrikazi.TabIndex = 3;
            this.txtRichPrikazi.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.txtRichPrikazi);
            this.Controls.Add(this.btnGenerisi);
            this.Controls.Add(this.txtBrClanova);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBrClanova;
        private System.Windows.Forms.Button btnGenerisi;
        private System.Windows.Forms.RichTextBox txtRichPrikazi;
    }
}

