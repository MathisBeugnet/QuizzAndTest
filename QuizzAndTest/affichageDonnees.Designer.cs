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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).BeginInit();
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
            this.dgv_questions.Location = new System.Drawing.Point(63, 56);
            this.dgv_questions.Name = "dgv_questions";
            this.dgv_questions.ReadOnly = true;
            this.dgv_questions.Size = new System.Drawing.Size(571, 277);
            this.dgv_questions.TabIndex = 1;
            // 
            // affichageDonnees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.dgv_questions);
            this.Controls.Add(this.fermer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "affichageDonnees";
            this.Text = "affichageDonnees";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_questions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.DataGridView dgv_questions;
    }
}