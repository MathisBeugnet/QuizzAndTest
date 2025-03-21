namespace QuizzAndTest
{
    partial class Jeu
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
            this.lbl_question = new System.Windows.Forms.Label();
            this.tb_question = new System.Windows.Forms.TextBox();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.lbl_temps = new System.Windows.Forms.Label();
            this.Titre = new System.Windows.Forms.Label();
            this.btn_valider = new System.Windows.Forms.Button();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.rep5 = new System.Windows.Forms.CheckBox();
            this.rep4 = new System.Windows.Forms.CheckBox();
            this.rep3 = new System.Windows.Forms.CheckBox();
            this.rep2 = new System.Windows.Forms.CheckBox();
            this.rep1 = new System.Windows.Forms.CheckBox();
            this.tb_joueur = new System.Windows.Forms.TextBox();
            this.tb_difficulte = new System.Windows.Forms.TextBox();
            this.lbl_joueur_jeu = new System.Windows.Forms.Label();
            this.lbl_difficulte_jeu = new System.Windows.Forms.Label();
            this.pb_dureeRepQuestion = new System.Windows.Forms.ProgressBar();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.btn_fermer2 = new System.Windows.Forms.Button();
            this.gb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Location = new System.Drawing.Point(101, 64);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(58, 13);
            this.lbl_question.TabIndex = 0;
            this.lbl_question.Text = "Question 1";
            // 
            // tb_question
            // 
            this.tb_question.Location = new System.Drawing.Point(60, 91);
            this.tb_question.Multiline = true;
            this.tb_question.Name = "tb_question";
            this.tb_question.ReadOnly = true;
            this.tb_question.Size = new System.Drawing.Size(442, 70);
            this.tb_question.TabIndex = 1;
            // 
            // txt_timer
            // 
            this.txt_timer.Location = new System.Drawing.Point(598, 91);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.ReadOnly = true;
            this.txt_timer.Size = new System.Drawing.Size(174, 20);
            this.txt_timer.TabIndex = 2;
            // 
            // lbl_temps
            // 
            this.lbl_temps.AutoSize = true;
            this.lbl_temps.Location = new System.Drawing.Point(596, 64);
            this.lbl_temps.Name = "lbl_temps";
            this.lbl_temps.Size = new System.Drawing.Size(62, 13);
            this.lbl_temps.TabIndex = 3;
            this.lbl_temps.Text = "Temps total";
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.Location = new System.Drawing.Point(255, 9);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(274, 42);
            this.Titre.TabIndex = 5;
            this.Titre.Text = "Quizz And Test";
            // 
            // btn_valider
            // 
            this.btn_valider.Location = new System.Drawing.Point(336, 352);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(75, 23);
            this.btn_valider.TabIndex = 6;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.rep5);
            this.gb1.Controls.Add(this.rep4);
            this.gb1.Controls.Add(this.rep3);
            this.gb1.Controls.Add(this.rep2);
            this.gb1.Controls.Add(this.rep1);
            this.gb1.Location = new System.Drawing.Point(60, 191);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(442, 155);
            this.gb1.TabIndex = 7;
            this.gb1.TabStop = false;
            this.gb1.Text = "Réponses possibles";
            // 
            // rep5
            // 
            this.rep5.AutoSize = true;
            this.rep5.Location = new System.Drawing.Point(36, 122);
            this.rep5.Name = "rep5";
            this.rep5.Size = new System.Drawing.Size(78, 17);
            this.rep5.TabIndex = 4;
            this.rep5.Text = "Réponse 5";
            this.rep5.UseVisualStyleBackColor = true;
            this.rep5.Click += new System.EventHandler(this.rep1_Click);
            // 
            // rep4
            // 
            this.rep4.AutoSize = true;
            this.rep4.Location = new System.Drawing.Point(36, 98);
            this.rep4.Name = "rep4";
            this.rep4.Size = new System.Drawing.Size(78, 17);
            this.rep4.TabIndex = 3;
            this.rep4.Text = "Réponse 4";
            this.rep4.UseVisualStyleBackColor = true;
            this.rep4.Click += new System.EventHandler(this.rep1_Click);
            // 
            // rep3
            // 
            this.rep3.AutoSize = true;
            this.rep3.Location = new System.Drawing.Point(36, 74);
            this.rep3.Name = "rep3";
            this.rep3.Size = new System.Drawing.Size(78, 17);
            this.rep3.TabIndex = 2;
            this.rep3.Text = "Réponse 3";
            this.rep3.UseVisualStyleBackColor = true;
            this.rep3.Click += new System.EventHandler(this.rep1_Click);
            // 
            // rep2
            // 
            this.rep2.AutoSize = true;
            this.rep2.Location = new System.Drawing.Point(36, 50);
            this.rep2.Name = "rep2";
            this.rep2.Size = new System.Drawing.Size(78, 17);
            this.rep2.TabIndex = 1;
            this.rep2.Text = "Réponse 2";
            this.rep2.UseVisualStyleBackColor = true;
            this.rep2.Click += new System.EventHandler(this.rep1_Click);
            // 
            // rep1
            // 
            this.rep1.AutoSize = true;
            this.rep1.Location = new System.Drawing.Point(36, 26);
            this.rep1.Name = "rep1";
            this.rep1.Size = new System.Drawing.Size(78, 17);
            this.rep1.TabIndex = 0;
            this.rep1.Text = "Réponse 1";
            this.rep1.UseVisualStyleBackColor = true;
            this.rep1.Click += new System.EventHandler(this.rep1_Click);
            // 
            // tb_joueur
            // 
            this.tb_joueur.Location = new System.Drawing.Point(598, 313);
            this.tb_joueur.Name = "tb_joueur";
            this.tb_joueur.ReadOnly = true;
            this.tb_joueur.Size = new System.Drawing.Size(166, 20);
            this.tb_joueur.TabIndex = 8;
            // 
            // tb_difficulte
            // 
            this.tb_difficulte.Location = new System.Drawing.Point(599, 352);
            this.tb_difficulte.Name = "tb_difficulte";
            this.tb_difficulte.ReadOnly = true;
            this.tb_difficulte.Size = new System.Drawing.Size(166, 20);
            this.tb_difficulte.TabIndex = 9;
            // 
            // lbl_joueur_jeu
            // 
            this.lbl_joueur_jeu.AutoSize = true;
            this.lbl_joueur_jeu.Location = new System.Drawing.Point(595, 293);
            this.lbl_joueur_jeu.Name = "lbl_joueur_jeu";
            this.lbl_joueur_jeu.Size = new System.Drawing.Size(39, 13);
            this.lbl_joueur_jeu.TabIndex = 10;
            this.lbl_joueur_jeu.Text = "Joueur";
            // 
            // lbl_difficulte_jeu
            // 
            this.lbl_difficulte_jeu.AutoSize = true;
            this.lbl_difficulte_jeu.Location = new System.Drawing.Point(596, 336);
            this.lbl_difficulte_jeu.Name = "lbl_difficulte_jeu";
            this.lbl_difficulte_jeu.Size = new System.Drawing.Size(48, 13);
            this.lbl_difficulte_jeu.TabIndex = 11;
            this.lbl_difficulte_jeu.Text = "Difficulté";
            // 
            // pb_dureeRepQuestion
            // 
            this.pb_dureeRepQuestion.Location = new System.Drawing.Point(598, 259);
            this.pb_dureeRepQuestion.Maximum = 15;
            this.pb_dureeRepQuestion.Name = "pb_dureeRepQuestion";
            this.pb_dureeRepQuestion.Size = new System.Drawing.Size(174, 23);
            this.pb_dureeRepQuestion.TabIndex = 13;
            // 
            // pb1
            // 
            this.pb1.Image = global::QuizzAndTest.Properties.Resources.Interrogation;
            this.pb1.Location = new System.Drawing.Point(598, 119);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(174, 115);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 4;
            this.pb1.TabStop = false;
            // 
            // btn_fermer2
            // 
            this.btn_fermer2.Location = new System.Drawing.Point(697, 9);
            this.btn_fermer2.Name = "btn_fermer2";
            this.btn_fermer2.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer2.TabIndex = 14;
            this.btn_fermer2.Text = "Fermer";
            this.btn_fermer2.UseVisualStyleBackColor = true;
            this.btn_fermer2.Click += new System.EventHandler(this.btn_fermer2_Click_1);
            // 
            // Jeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 385);
            this.Controls.Add(this.btn_fermer2);
            this.Controls.Add(this.pb_dureeRepQuestion);
            this.Controls.Add(this.lbl_difficulte_jeu);
            this.Controls.Add(this.lbl_joueur_jeu);
            this.Controls.Add(this.tb_difficulte);
            this.Controls.Add(this.tb_joueur);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.lbl_temps);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.tb_question);
            this.Controls.Add(this.lbl_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Jeu";
            this.Text = "Jeu";
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_question;
        private System.Windows.Forms.TextBox tb_question;
        private System.Windows.Forms.TextBox txt_timer;
        private System.Windows.Forms.Label lbl_temps;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Button btn_valider;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.CheckBox rep5;
        private System.Windows.Forms.CheckBox rep4;
        private System.Windows.Forms.CheckBox rep3;
        private System.Windows.Forms.CheckBox rep2;
        private System.Windows.Forms.CheckBox rep1;
        private System.Windows.Forms.TextBox tb_joueur;
        private System.Windows.Forms.TextBox tb_difficulte;
        private System.Windows.Forms.Label lbl_joueur_jeu;
        private System.Windows.Forms.Label lbl_difficulte_jeu;
        private System.Windows.Forms.ProgressBar pb_dureeRepQuestion;
        private System.Windows.Forms.Button btn_fermer2;
    }
}