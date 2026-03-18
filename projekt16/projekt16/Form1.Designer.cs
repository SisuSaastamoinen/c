namespace projekt16
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
            this.components = new System.ComponentModel.Container();
            this.MinutesLB = new System.Windows.Forms.Label();
            this.SecondsLB = new System.Windows.Forms.Label();
            this.MinutesCB = new System.Windows.Forms.ComboBox();
            this.SecondsCB = new System.Windows.Forms.ComboBox();
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinutesLB
            // 
            this.MinutesLB.AutoSize = true;
            this.MinutesLB.Location = new System.Drawing.Point(13, 13);
            this.MinutesLB.Name = "MinutesLB";
            this.MinutesLB.Size = new System.Drawing.Size(76, 24);
            this.MinutesLB.TabIndex = 0;
            this.MinutesLB.Text = "Minutes";
            // 
            // SecondsLB
            // 
            this.SecondsLB.AutoSize = true;
            this.SecondsLB.Location = new System.Drawing.Point(95, 14);
            this.SecondsLB.Name = "SecondsLB";
            this.SecondsLB.Size = new System.Drawing.Size(85, 24);
            this.SecondsLB.TabIndex = 1;
            this.SecondsLB.Text = "Seconds";
            // 
            // MinutesCB
            // 
            this.MinutesCB.FormattingEnabled = true;
            this.MinutesCB.Location = new System.Drawing.Point(12, 40);
            this.MinutesCB.Name = "MinutesCB";
            this.MinutesCB.Size = new System.Drawing.Size(72, 32);
            this.MinutesCB.TabIndex = 2;
            // 
            // SecondsCB
            // 
            this.SecondsCB.FormattingEnabled = true;
            this.SecondsCB.Location = new System.Drawing.Point(91, 40);
            this.SecondsCB.Name = "SecondsCB";
            this.SecondsCB.Size = new System.Drawing.Size(89, 32);
            this.SecondsCB.TabIndex = 3;
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.Location = new System.Drawing.Point(4, 75);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(194, 73);
            this.TimeLB.TabIndex = 4;
            this.TimeLB.Text = "00:00";
            // 
            // StartBT
            // 
            this.StartBT.Location = new System.Drawing.Point(17, 152);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(75, 32);
            this.StartBT.TabIndex = 5;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = true;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.Location = new System.Drawing.Point(99, 152);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(75, 31);
            this.StopBT.TabIndex = 6;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = true;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 208);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Controls.Add(this.SecondsCB);
            this.Controls.Add(this.MinutesCB);
            this.Controls.Add(this.SecondsLB);
            this.Controls.Add(this.MinutesLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MinutesLB;
        private System.Windows.Forms.Label SecondsLB;
        private System.Windows.Forms.ComboBox MinutesCB;
        private System.Windows.Forms.ComboBox SecondsCB;
        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

