namespace CH6EX1
{
    partial class SalesLetter
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnesc = new System.Windows.Forms.Button();
            this.lblLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 12);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(97, 46);
            this.btnDisplay.TabIndex = 0;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnesc
            // 
            this.btnesc.Location = new System.Drawing.Point(12, 64);
            this.btnesc.Name = "btnesc";
            this.btnesc.Size = new System.Drawing.Size(97, 46);
            this.btnesc.TabIndex = 1;
            this.btnesc.Text = "Escape";
            this.btnesc.UseVisualStyleBackColor = true;
            this.btnesc.Click += new System.EventHandler(this.btnesc_Click);
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(179, 12);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(0, 13);
            this.lblLetter.TabIndex = 2;
            // 
            // SalesLetter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 877);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.btnesc);
            this.Controls.Add(this.btnDisplay);
            this.Name = "SalesLetter";
            this.Text = "SalesLetter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnesc;
        private System.Windows.Forms.Label lblLetter;
    }
}

