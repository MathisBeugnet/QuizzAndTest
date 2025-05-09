using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest.Model
{
    public class Partie
    {
        public int score;
        public int difficulte;
        public int nbQuestion;
        public int numReponse;
        public int numQuestion;
        public List<Question> question;
        public string nomJoueur;
        public string prenomJoueur;
        public int dureePartie;
        public int dureeTQuestion;
        public Timer timer;
        private SousFormulaire SF;


        public Partie(List<Question> question)
        {
            List<Question> questionN = new List<Question>();
            questionN=listeAleatoireQuestion(question);
            this.score = 0;
            this.difficulte = 0;
            this.nbQuestion = questionN.Count;
            this.numReponse = 0;
            this.numQuestion = 0;
            this.question = questionN;
            this.nomJoueur = "";
            this.prenomJoueur = "";
        }
        private void changerImg(PictureBox PbImage, bool BonneReponse, bool raz)
        {
            if (!raz)
            {
                if (BonneReponse)
                {
                    PbImage.Image = Properties.Resources.vrai;
                }
                else
                {
                    PbImage.Image = Properties.Resources.faux;
                }

            }
            else
            {
                PbImage.Image = Properties.Resources.Interrogation;
            }
        }

        private void calculerScore(bool BonneReponse)
        {
            score++;
        }
        public void validerReponse(int reponse, PictureBox PbImage)
        {
            if (reponse == numReponse)
            {
                calculerScore(true);
                changerImg(PbImage, true, false);
            }
            else
            {
                changerImg(PbImage, false, false);
            }

        }

        public void changerQuestion(TextBox txt_affichage, Label lbl_question, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Panel pnl_Principal)
        {

            if (nbQuestion > numQuestion)
            {
                aleatoireReponse(txt_affichage, gd_reponse);
                ckb_reponse1.Checked = false;
                ckb_reponse2.Checked = false;
                ckb_reponse3.Checked = false;
                ckb_reponse4.Checked = false;
                ckb_reponse5.Checked = false;

            }
            else
            {
                FinDePartie(txt_affichage, lbl_question, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_Principal);


            }
        }
        private void aleatoireReponse(TextBox txt_affichage, GroupBox gd_reponse)
        {
            int bonneReponse = question[numQuestion].reponse;
            txt_affichage.Text = question[numQuestion].enonce;
            List<int> reponseAleatoire = new List<int>() { 1, 2, 3, 4, 5 };
            Random rnd = new Random();

            for (int i = 1; i <= 5; i++)
            {
                int randIndex = rnd.Next(reponseAleatoire.Count);
                int random = reponseAleatoire[randIndex];
                reponseAleatoire.Remove(random);
                string reponse = "";

                switch (random)
                {
                    case 1:
                        reponse = question[numQuestion].proposition1;
                        break;

                    case 2:
                        reponse = question[numQuestion].proposition2;
                        break;

                    case 3:
                        reponse = question[numQuestion].proposition3;
                        break;
                    case 4:
                        reponse = question[numQuestion].proposition4;
                        break;

                    default:
                        reponse = question[numQuestion].proposition5;
                        break;
                }

                getCheckBox(i, gd_reponse).Text = reponse;
                if (bonneReponse == random)
                {
                    numReponse = i;
                }
            }
        }

        private CheckBox getCheckBox(int indice, GroupBox gd_reponse)
        {
            foreach (Control c in gd_reponse.Controls)
            {
                if (c.GetType() == typeof(CheckBox) && c.Name == "rep" + indice.ToString())
                {
                    return ((CheckBox)c);
                }
            }
            return null;
        }

        public void FinDePartie(TextBox txt_affichage, Label lbl_question, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Panel pnl_principal)
        {
            DialogResult msg;
            timer.Stop();
            SF = new SousFormulaire(pnl_principal);
            msg = MessageBox.Show("Votre score est de " + score + ".\r\n vous avez fini la partie en " + dureePartie + " secondes.\r\n Voulez vous rejouer?", "Fin de la partie"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (msg == DialogResult.Yes)
            {
                score = 0;
                numQuestion = 0;
                dureePartie = 0;
                lbl_question.Text = "Question 1";
                changerQuestion(txt_affichage, lbl_question, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_principal);
                changerImg(PbImage, true, true);
                timer.Start();
            }
            else
            {
                SF.openChildForm(new Form1());


            }


        }

        public void gestionTimer(TextBox txt_timer, Label lbl_question, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numQuestion, Panel pnl_principal)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer, lbl_question, pb_dureeRepQuestion, txt_affichage, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, numQuestion, pnl_principal);

            timer.Start();
        }

        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer, Label lbl_question, ProgressBar pb_dureeRepQuestion, TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage, Label numeroQuestion, Panel pnl_principal)
        {
            dureePartie++;
            dureeTQuestion++;
            pb_dureeRepQuestion.Increment(1);
            txt_timer.Text = dureePartie.ToString() + " sec";
            if (dureeTQuestion > 15)
            {
                validerReponse(0, PbImage);
                numQuestion++;
                numeroQuestion.Text = "Question " + (numQuestion + 1).ToString();
                changerQuestion(txt_affichage, lbl_question, ckb_reponse1, ckb_reponse2, ckb_reponse3, ckb_reponse4, ckb_reponse5, formulaire, gd_reponse, PbImage, pnl_principal);
                pb_dureeRepQuestion.Value = 0;
                dureeTQuestion = 0;
            }
        }

        public List<Question> listeAleatoireQuestion(List<Question> L_Question)
        {
            List<Question> L_Selection = new List<Question>();
            Random rnd = new Random();

            while (L_Selection.Count < 10)
            {
                int randIndex = rnd.Next(L_Question.Count);
                Question q = L_Question[randIndex];

                if (!L_Selection.Contains(q))
                {
                    L_Selection.Add(q);
                }
            }

            return L_Selection;
        }
    }
}
