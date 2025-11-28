namespace CH7EX5
{
    partial class FineForOverdueBooks
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblOverdue = new System.Windows.Forms.Label();
            this.btnEsc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(39, 35);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Enter Books";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(39, 84);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 13);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Enter Days";
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(110, 35);
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.Size = new System.Drawing.Size(84, 20);
            this.txtBooks.TabIndex = 2;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(110, 84);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(84, 20);
            this.txtDays.TabIndex = 3;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(42, 149);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 43);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Calculate ";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblOverdue
            // 
            this.lblOverdue.AutoSize = true;
            this.lblOverdue.Location = new System.Drawing.Point(159, 164);
            this.lblOverdue.Name = "lblOverdue";
            this.lblOverdue.Size = new System.Drawing.Size(0, 13);
            this.lblOverdue.TabIndex = 5;
            // 
            // btnEsc
            // 
            this.btnEsc.Location = new System.Drawing.Point(42, 207);
            this.btnEsc.Name = "btnEsc";
            this.btnEsc.Size = new System.Drawing.Size(75, 42);
            this.btnEsc.TabIndex = 6;
            this.btnEsc.Text = "Escape";
            this.btnEsc.UseVisualStyleBackColor = true;
            this.btnEsc.Click += new System.EventHandler(this.btnEsc_Click);
            // 
            // FineForOverdueBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 288);
            this.Controls.Add(this.btnEsc);
            this.Controls.Add(this.lblOverdue);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtBooks);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "FineForOverdueBooks";
            this.Text = "FineForOverdueBooks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblOverdue;
        private System.Windows.Forms.Button btnEsc;
    }
}

