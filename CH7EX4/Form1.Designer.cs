namespace CH7EX4
{
    partial class FortuneTeller
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
            this.btnFortune = new System.Windows.Forms.Button();
            this.lblfortune = new System.Windows.Forms.Label();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFortune
            // 
            this.btnFortune.Location = new System.Drawing.Point(12, 35);
            this.btnFortune.Name = "btnFortune";
            this.btnFortune.Size = new System.Drawing.Size(88, 50);
            this.btnFortune.TabIndex = 0;
            this.btnFortune.Text = "Fortune";
            this.btnFortune.UseVisualStyleBackColor = true;
            this.btnFortune.Click += new System.EventHandler(this.btnFortune_Click);
            // 
            // lblfortune
            // 
            this.lblfortune.AutoSize = true;
            this.lblfortune.Location = new System.Drawing.Point(175, 54);
            this.lblfortune.Name = "lblfortune";
            this.lblfortune.Size = new System.Drawing.Size(0, 13);
            this.lblfortune.TabIndex = 1;
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(12, 91);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(88, 50);
            this.btnEsc.TabIndex = 2;
            this.btnEsc.Text = "Escape";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // FortuneTeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.lblfortune);
            this.Controls.Add(this.btnFortune);
            this.Name = "FortuneTeller";
            this.Text = "FortuneTeller";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFortune;
        private System.Windows.Forms.Label lblfortune;
        private System.Windows.Forms.Button btnEsc;
    }
}

