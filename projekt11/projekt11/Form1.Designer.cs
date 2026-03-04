namespace projekt11
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
            this.Noppa1 = new System.Windows.Forms.PictureBox();
            this.Noppa2 = new System.Windows.Forms.PictureBox();
            this.HeitäBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nopan heitto";
            // 
            // Noppa1
            // 
            this.Noppa1.Image = global::projekt11.Properties.Resources.dice01;
            this.Noppa1.Location = new System.Drawing.Point(30, 93);
            this.Noppa1.Name = "Noppa1";
            this.Noppa1.Size = new System.Drawing.Size(100, 100);
            this.Noppa1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa1.TabIndex = 1;
            this.Noppa1.TabStop = false;
            // 
            // Noppa2
            // 
            this.Noppa2.Image = global::projekt11.Properties.Resources.dice01;
            this.Noppa2.Location = new System.Drawing.Point(154, 93);
            this.Noppa2.Name = "Noppa2";
            this.Noppa2.Size = new System.Drawing.Size(100, 100);
            this.Noppa2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa2.TabIndex = 2;
            this.Noppa2.TabStop = false;
            // 
            // HeitäBT
            // 
            this.HeitäBT.Location = new System.Drawing.Point(30, 199);
            this.HeitäBT.Name = "HeitäBT";
            this.HeitäBT.Size = new System.Drawing.Size(224, 47);
            this.HeitäBT.TabIndex = 3;
            this.HeitäBT.Text = "Heitä";
            this.HeitäBT.UseVisualStyleBackColor = true;
            this.HeitäBT.Click += new System.EventHandler(this.HeitäBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 304);
            this.Controls.Add(this.HeitäBT);
            this.Controls.Add(this.Noppa2);
            this.Controls.Add(this.Noppa1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Noppa1;
        private System.Windows.Forms.PictureBox Noppa2;
        private System.Windows.Forms.Button HeitäBT;
    }
}

