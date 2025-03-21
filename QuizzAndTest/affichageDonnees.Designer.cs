namespace QuizzAndTest
{
    partial class affichageDonnees
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
            this.fermer = new System.Windows.Forms.Button();
            this.dgv_questions = new System.Windows.Forms.DataGridView();
            this.gb_recherche = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_difficulte = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
            this.gb_recherche.SuspendLayout();
            this.SuspendLayout();
            // 
            // fermer
            // 
            this.fermer.Location = new System.Drawing.Point(740, 13);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(32, 23);
            this.fermer.TabIndex = 0;
            this.fermer.Text = "X";
            this.fermer.UseVisualStyleBackColor = true;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // dgv_questions
            // 
            this.dgv_questions.AllowUserToAddRows = false;
            this.dgv_questions.AllowUserToDeleteRows = false;
            this.dgv_questions.AllowUserToResizeRows = false;
            this.dgv_questions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_questions.Location = new System.Drawing.Point(63, 136);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(456, 197);
            this.dgv_questions.TabIndex = 1;
            // 
            // gb_recherche
            // 
            this.gb_recherche.Controls.Add(this.label2);
            this.gb_recherche.Controls.Add(this.label1);
            this.gb_recherche.Controls.Add(this.cbb_difficulte);
            this.gb_recherche.Controls.Add(this.textBox1);
            this.gb_recherche.Location = new System.Drawing.Point(410, 13);
            this.gb_recherche.Name = "gb_recherche";
            this.gb_recherche.Size = new System.Drawing.Size(276, 117);
            this.gb_recherche.TabIndex = 2;
            this.gb_recherche.TabStop = false;
            this.gb_recherche.Text = "Recherche";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Difficulté";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recherche de mots";
            // 
            // cbb_difficulte
            // 
            this.cbb_difficulte.FormattingEnabled = true;
            this.cbb_difficulte.Location = new System.Drawing.Point(123, 58);
            this.cbb_difficulte.Name = "cbb_difficulte";
            this.cbb_difficulte.Size = new System.Drawing.Size(121, 21);
            this.cbb_difficulte.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 0;
            // 
            // affichageDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.gb_recherche);
            this.Controls.Add(this.dgv_questions);
            this.Controls.Add(this.fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "affichageDonnees";
            this.Text = "affichageDonnees";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.gb_recherche.ResumeLayout(false);
            this.gb_recherche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.DataGridView dgv_questions;
        private System.Windows.Forms.GroupBox gb_recherche;
        private System.Windows.Forms.ComboBox cbb_difficulte;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}