namespace projekt4
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
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.LaskeIkaBT = new System.Windows.Forms.Button();
            this.VuosinaLB = new System.Windows.Forms.Label();
            this.KuukausinaLB = new System.Windows.Forms.Label();
            this.PaivinaLB = new System.Windows.Forms.Label();
            this.SekuntteinaLB = new System.Windows.Forms.Label();
            this.MinuutteinaLB = new System.Windows.Forms.Label();
            this.TunteinaLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Location = new System.Drawing.Point(49, 45);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(351, 31);
            this.SyntymaAikaDT.TabIndex = 0;
            // 
            // LaskeIkaBT
            // 
            this.LaskeIkaBT.Location = new System.Drawing.Point(426, 47);
            this.LaskeIkaBT.Name = "LaskeIkaBT";
            this.LaskeIkaBT.Size = new System.Drawing.Size(124, 30);
            this.LaskeIkaBT.TabIndex = 1;
            this.LaskeIkaBT.Text = "Laske ikä";
            this.LaskeIkaBT.UseVisualStyleBackColor = true;
            this.LaskeIkaBT.Click += new System.EventHandler(this.LaskeIkaBT_Click);
            // 
            // VuosinaLB
            // 
            this.VuosinaLB.AutoSize = true;
            this.VuosinaLB.Location = new System.Drawing.Point(49, 129);
            this.VuosinaLB.Name = "VuosinaLB";
            this.VuosinaLB.Size = new System.Drawing.Size(90, 25);
            this.VuosinaLB.TabIndex = 2;
            this.VuosinaLB.Text = "Vuosina";
            this.VuosinaLB.Visible = false;
            // 
            // KuukausinaLB
            // 
            this.KuukausinaLB.AutoSize = true;
            this.KuukausinaLB.Location = new System.Drawing.Point(49, 154);
            this.KuukausinaLB.Name = "KuukausinaLB";
            this.KuukausinaLB.Size = new System.Drawing.Size(125, 25);
            this.KuukausinaLB.TabIndex = 3;
            this.KuukausinaLB.Text = "Kuukausina";
            this.KuukausinaLB.Visible = false;
            // 
            // PaivinaLB
            // 
            this.PaivinaLB.AutoSize = true;
            this.PaivinaLB.Location = new System.Drawing.Point(49, 179);
            this.PaivinaLB.Name = "PaivinaLB";
            this.PaivinaLB.Size = new System.Drawing.Size(83, 25);
            this.PaivinaLB.TabIndex = 4;
            this.PaivinaLB.Text = "Päivinä";
            this.PaivinaLB.Visible = false;
            // 
            // SekuntteinaLB
            // 
            this.SekuntteinaLB.AutoSize = true;
            this.SekuntteinaLB.Location = new System.Drawing.Point(275, 179);
            this.SekuntteinaLB.Name = "SekuntteinaLB";
            this.SekuntteinaLB.Size = new System.Drawing.Size(126, 25);
            this.SekuntteinaLB.TabIndex = 7;
            this.SekuntteinaLB.Text = "Sekuntteina";
            this.SekuntteinaLB.Visible = false;
            // 
            // MinuutteinaLB
            // 
            this.MinuutteinaLB.AutoSize = true;
            this.MinuutteinaLB.Location = new System.Drawing.Point(275, 154);
            this.MinuutteinaLB.Name = "MinuutteinaLB";
            this.MinuutteinaLB.Size = new System.Drawing.Size(124, 25);
            this.MinuutteinaLB.TabIndex = 6;
            this.MinuutteinaLB.Text = "Minuutteina";
            this.MinuutteinaLB.Visible = false;
            // 
            // TunteinaLB
            // 
            this.TunteinaLB.AutoSize = true;
            this.TunteinaLB.Location = new System.Drawing.Point(275, 129);
            this.TunteinaLB.Name = "TunteinaLB";
            this.TunteinaLB.Size = new System.Drawing.Size(96, 25);
            this.TunteinaLB.TabIndex = 5;
            this.TunteinaLB.Text = "Tunteina";
            this.TunteinaLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 280);
            this.Controls.Add(this.SekuntteinaLB);
            this.Controls.Add(this.MinuutteinaLB);
            this.Controls.Add(this.TunteinaLB);
            this.Controls.Add(this.PaivinaLB);
            this.Controls.Add(this.KuukausinaLB);
            this.Controls.Add(this.VuosinaLB);
            this.Controls.Add(this.LaskeIkaBT);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker SyntymaAikaDT;
        private System.Windows.Forms.Button LaskeIkaBT;
        private System.Windows.Forms.Label VuosinaLB;
        private System.Windows.Forms.Label KuukausinaLB;
        private System.Windows.Forms.Label PaivinaLB;
        private System.Windows.Forms.Label SekuntteinaLB;
        private System.Windows.Forms.Label MinuutteinaLB;
        private System.Windows.Forms.Label TunteinaLB;
    }
}

