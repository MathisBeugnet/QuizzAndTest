﻿namespace QuizzAndTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_valider = new System.Windows.Forms.Button();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.txt_nom = new System.Windows.Forms.TextBox();
            this.txt_prenom = new System.Windows.Forms.TextBox();
            this.lbl_difficulté = new System.Windows.Forms.Label();
            this.cb_difficulte = new System.Windows.Forms.ComboBox();
            this.btn_fermer1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(348, 331);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 2;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.Location = new System.Drawing.Point(229, 100);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(29, 13);
            this.lbl_nom.TabIndex = 3;
            this.lbl_nom.Text = "Nom";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.Location = new System.Drawing.Point(229, 150);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(43, 13);
            this.lbl_prenom.TabIndex = 4;
            this.lbl_prenom.Text = "Prénom";
            // 
            // txt_nom
            // 
            this.txt_nom.Location = new System.Drawing.Point(307, 93);
            this.txt_nom.Name = "txt_nom";
            this.txt_nom.Size = new System.Drawing.Size(167, 20);
            this.txt_nom.TabIndex = 5;
            // 
            // txt_prenom
            // 
            this.txt_prenom.Location = new System.Drawing.Point(307, 147);
            this.txt_prenom.Name = "txt_prenom";
            this.txt_prenom.Size = new System.Drawing.Size(167, 20);
            this.txt_prenom.TabIndex = 6;
            // 
            // lbl_difficulté
            // 
            this.lbl_difficulté.AutoSize = true;
            this.lbl_difficulté.Location = new System.Drawing.Point(210, 266);
            this.lbl_difficulté.Name = "lbl_difficulté";
            this.lbl_difficulté.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulté.TabIndex = 7;
            this.lbl_difficulté.Text = "Difficulté";
            // 
            // cb_difficulte
            // 
            this.cb_difficulte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_difficulte.FormattingEnabled = true;
            this.cb_difficulte.Location = new System.Drawing.Point(307, 263);
            this.cb_difficulte.Name = "cb_difficulte";
            this.cb_difficulte.Size = new System.Drawing.Size(167, 21);
            this.cb_difficulte.TabIndex = 8;
            this.cb_difficulte.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_fermer1
            // 
            this.btn_fermer1.Location = new System.Drawing.Point(687, 12);
            this.btn_fermer1.Name = "btn_fermer1";
            this.btn_fermer1.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer1.TabIndex = 9;
            this.btn_fermer1.Text = "Fermer";
            this.btn_fermer1.UseVisualStyleBackColor = true;
            this.btn_fermer1.Click += new System.EventHandler(this.btn_fermer1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.btn_fermer1);
            this.Controls.Add(this.cb_difficulte);
            this.Controls.Add(this.lbl_difficulté);
            this.Controls.Add(this.txt_prenom);
            this.Controls.Add(this.txt_nom);
            this.Controls.Add(this.lbl_prenom);
            this.Controls.Add(this.lbl_nom);
            this.Controls.Add(this.btn_valider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.TextBox txt_nom;
        private System.Windows.Forms.TextBox txt_prenom;
        private System.Windows.Forms.Label lbl_difficulté;
        private System.Windows.Forms.ComboBox cb_difficulte;
        private System.Windows.Forms.Button btn_fermer1;
    }
}

