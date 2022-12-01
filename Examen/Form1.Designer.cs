namespace Examen
{
    partial class Evaluation
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ChBox_QCM = new System.Windows.Forms.CheckBox();
            this.ChBox_Exercice = new System.Windows.Forms.CheckBox();
            this.btn_confirmer = new System.Windows.Forms.Button();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.Font = new System.Drawing.Font("Broadway", 26.14286F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_titre.Location = new System.Drawing.Point(265, 21);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(412, 71);
            this.lbl_titre.TabIndex = 0;
            this.lbl_titre.Text = "Evaluation";
            this.lbl_titre.Click += new System.EventHandler(this.lbl_titre_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Maroon;
            this.textBox1.Location = new System.Drawing.Point(73, 135);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(820, 43);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "* Veuillez choisir le type de l\'evaluation:";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ChBox_QCM
            // 
            this.ChBox_QCM.AutoSize = true;
            this.ChBox_QCM.Font = new System.Drawing.Font("Comic Sans MS", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBox_QCM.Location = new System.Drawing.Point(221, 239);
            this.ChBox_QCM.Name = "ChBox_QCM";
            this.ChBox_QCM.Size = new System.Drawing.Size(397, 42);
            this.ChBox_QCM.TabIndex = 2;
            this.ChBox_QCM.Text = "Examen sous forme de QCM";
            this.ChBox_QCM.UseVisualStyleBackColor = true;
            this.ChBox_QCM.CheckedChanged += new System.EventHandler(this.ChBox_QCM_CheckedChanged);
            // 
            // ChBox_Exercice
            // 
            this.ChBox_Exercice.AutoSize = true;
            this.ChBox_Exercice.Font = new System.Drawing.Font("Comic Sans MS", 11.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChBox_Exercice.Location = new System.Drawing.Point(221, 298);
            this.ChBox_Exercice.Name = "ChBox_Exercice";
            this.ChBox_Exercice.Size = new System.Drawing.Size(443, 42);
            this.ChBox_Exercice.TabIndex = 3;
            this.ChBox_Exercice.Text = "Examen sous forme d\'exercices";
            this.ChBox_Exercice.UseVisualStyleBackColor = true;
            this.ChBox_Exercice.CheckedChanged += new System.EventHandler(this.ChBox_Exercice_CheckedChanged);
            // 
            // btn_confirmer
            // 
            this.btn_confirmer.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_confirmer.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_confirmer.Location = new System.Drawing.Point(236, 490);
            this.btn_confirmer.Name = "btn_confirmer";
            this.btn_confirmer.Size = new System.Drawing.Size(110, 57);
            this.btn_confirmer.TabIndex = 4;
            this.btn_confirmer.Text = "Confirmer";
            this.btn_confirmer.UseVisualStyleBackColor = false;
            this.btn_confirmer.Click += new System.EventHandler(this.btn_confirmer_Click);
            // 
            // btn_annuler
            // 
            this.btn_annuler.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_annuler.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_annuler.Location = new System.Drawing.Point(73, 490);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(111, 53);
            this.btn_annuler.TabIndex = 5;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = false;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 555);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_confirmer);
            this.Controls.Add(this.ChBox_Exercice);
            this.Controls.Add(this.ChBox_QCM);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Evaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox ChBox_QCM;
        private System.Windows.Forms.CheckBox ChBox_Exercice;
        private System.Windows.Forms.Button btn_confirmer;
        private System.Windows.Forms.Button btn_annuler;
    }
}