namespace projekt12.alt2
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.Vastaus4RB = new System.Windows.Forms.RadioButton();
            this.Vastaus3RB = new System.Windows.Forms.RadioButton();
            this.Vastaus2RB = new System.Windows.Forms.RadioButton();
            this.Vastaus1RB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Location = new System.Drawing.Point(30, 33);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(104, 25);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Kysymys:";
            // 
            // Vastaus4RB
            // 
            this.Vastaus4RB.AutoSize = true;
            this.Vastaus4RB.Location = new System.Drawing.Point(317, 158);
            this.Vastaus4RB.Name = "Vastaus4RB";
            this.Vastaus4RB.Size = new System.Drawing.Size(45, 29);
            this.Vastaus4RB.TabIndex = 4;
            this.Vastaus4RB.TabStop = false;
            this.Vastaus4RB.Text = "D";
            this.Vastaus4RB.UseVisualStyleBackColor = true;
            // 
            // Vastaus3RB
            // 
            this.Vastaus3RB.AutoSize = true;
            this.Vastaus3RB.Location = new System.Drawing.Point(317, 123);
            this.Vastaus3RB.Name = "Vastaus3RB";
            this.Vastaus3RB.Size = new System.Drawing.Size(45, 29);
            this.Vastaus3RB.TabIndex = 3;
            this.Vastaus3RB.TabStop = false;
            this.Vastaus3RB.Text = "C";
            this.Vastaus3RB.UseVisualStyleBackColor = true;
            // 
            // Vastaus2RB
            // 
            this.Vastaus2RB.AutoSize = true;
            this.Vastaus2RB.Location = new System.Drawing.Point(318, 88);
            this.Vastaus2RB.Name = "Vastaus2RB";
            this.Vastaus2RB.Size = new System.Drawing.Size(44, 29);
            this.Vastaus2RB.TabIndex = 2;
            this.Vastaus2RB.TabStop = false;
            this.Vastaus2RB.Text = "B";
            this.Vastaus2RB.UseVisualStyleBackColor = true;
            // 
            // Vastaus1RB
            // 
            this.Vastaus1RB.AutoSize = true;
            this.Vastaus1RB.Location = new System.Drawing.Point(318, 53);
            this.Vastaus1RB.Name = "Vastaus1RB";
            this.Vastaus1RB.Size = new System.Drawing.Size(44, 29);
            this.Vastaus1RB.TabIndex = 1;
            this.Vastaus1RB.TabStop = false;
            this.Vastaus1RB.Text = "A";
            this.Vastaus1RB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(30, 188);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(90, 25);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 269);
            this.Controls.Add(this.Vastaus4RB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.Vastaus3RB);
            this.Controls.Add(this.Vastaus2RB);
            this.Controls.Add(this.KysymysLB);
            this.Controls.Add(this.Vastaus1RB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
            this.Vastaus1RB.Checked = false;
            this.Vastaus2RB.Checked = false;
            this.Vastaus3RB.Checked = false;
            this.Vastaus4RB.Checked = false;

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.RadioButton Vastaus1RB;
        private System.Windows.Forms.RadioButton Vastaus4RB;
        private System.Windows.Forms.RadioButton Vastaus3RB;
        private System.Windows.Forms.RadioButton Vastaus2RB;
        private System.Windows.Forms.Label VastausLB;
    }
}

