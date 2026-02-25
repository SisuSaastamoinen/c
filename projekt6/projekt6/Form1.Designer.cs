namespace projekt6
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.ErrorLB = new System.Windows.Forms.Label();
            this.WelcomePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.WelcomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SalasanaPanel.Controls.Add(this.ErrorLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaBT);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.label2);
            this.SalasanaPanel.Controls.Add(this.label1);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(547, 198);
            this.SalasanaPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(324, 32);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(181, 31);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(271, 72);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(188, 31);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.Location = new System.Drawing.Point(271, 109);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(103, 42);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // ErrorLB
            // 
            this.ErrorLB.AutoSize = true;
            this.ErrorLB.Location = new System.Drawing.Point(380, 118);
            this.ErrorLB.Name = "ErrorLB";
            this.ErrorLB.Size = new System.Drawing.Size(59, 25);
            this.ErrorLB.TabIndex = 5;
            this.ErrorLB.Text = "Error";
            this.ErrorLB.Visible = false;
            // 
            // WelcomePanel
            // 
            this.WelcomePanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.WelcomePanel.Controls.Add(this.label3);
            this.WelcomePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WelcomePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomePanel.Location = new System.Drawing.Point(0, 0);
            this.WelcomePanel.Name = "WelcomePanel";
            this.WelcomePanel.Size = new System.Drawing.Size(547, 198);
            this.WelcomePanel.TabIndex = 1;
            this.WelcomePanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 55);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tervetuloa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 198);
            this.Controls.Add(this.WelcomePanel);
            this.Controls.Add(this.SalasanaPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.WelcomePanel.ResumeLayout(false);
            this.WelcomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ErrorLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel WelcomePanel;
        private System.Windows.Forms.Label label3;
    }
}

