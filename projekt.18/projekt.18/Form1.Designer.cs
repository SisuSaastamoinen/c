namespace projekt._18
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
            this.label2 = new System.Windows.Forms.Label();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.HenkilöCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostiLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhLB = new System.Windows.Forms.Label();
            this.SähköpostiLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(27, 99);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(150, 32);
            this.OppilaitosCB.TabIndex = 2;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // HenkilöCB
            // 
            this.HenkilöCB.FormattingEnabled = true;
            this.HenkilöCB.Location = new System.Drawing.Point(187, 99);
            this.HenkilöCB.Name = "HenkilöCB";
            this.HenkilöCB.Size = new System.Drawing.Size(186, 32);
            this.HenkilöCB.TabIndex = 4;
            this.HenkilöCB.TextChanged += new System.EventHandler(this.HenkilöCB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(183, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(27, 151);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(64, 24);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(27, 175);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(116, 24);
            this.PostinumeroLB.TabIndex = 6;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostiLB
            // 
            this.PostiLB.AutoSize = true;
            this.PostiLB.Location = new System.Drawing.Point(27, 199);
            this.PostiLB.Name = "PostiLB";
            this.PostiLB.Size = new System.Drawing.Size(142, 24);
            this.PostiLB.TabIndex = 7;
            this.PostiLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Location = new System.Drawing.Point(27, 223);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(74, 24);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhLB
            // 
            this.PuhLB.AutoSize = true;
            this.PuhLB.Location = new System.Drawing.Point(183, 223);
            this.PuhLB.Name = "PuhLB";
            this.PuhLB.Size = new System.Drawing.Size(74, 24);
            this.PuhLB.TabIndex = 12;
            this.PuhLB.Text = "Puhelin";
            // 
            // SähköpostiLB
            // 
            this.SähköpostiLB.AutoSize = true;
            this.SähköpostiLB.Location = new System.Drawing.Point(183, 199);
            this.SähköpostiLB.Name = "SähköpostiLB";
            this.SähköpostiLB.Size = new System.Drawing.Size(102, 24);
            this.SähköpostiLB.TabIndex = 11;
            this.SähköpostiLB.Text = "Sähköposti";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(183, 175);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(68, 24);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Location = new System.Drawing.Point(183, 151);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(53, 24);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "Titteli";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 291);
            this.Controls.Add(this.PuhLB);
            this.Controls.Add(this.SähköpostiLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostiLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.HenkilöCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox OppilaitosCB;
        private System.Windows.Forms.ComboBox HenkilöCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.Label PostiLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label PuhLB;
        private System.Windows.Forms.Label SähköpostiLB;
        private System.Windows.Forms.Label OsastoLB;
        private System.Windows.Forms.Label TitteliLB;
    }
}

