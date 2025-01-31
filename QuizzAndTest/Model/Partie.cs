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
    internal class Partie
    {
        public int score;
        public int difficulte;
        public int nbQuestion;
        public int numReponse;
        public int numQuestion;
        public List<Question> question;

        public Partie(List<Question> question)
        {
            this.score = 0;
            this.difficulte = 0;
            this.nbQuestion = question.Count;
            this.numReponse = 0;
            this.numQuestion = 0;
            this.question = question;

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

        public void changerQuestion(TextBox txt_affichage, CheckBox ckb_reponse1, CheckBox ckb_reponse2, CheckBox ckb_reponse3, CheckBox ckb_reponse4, CheckBox ckb_reponse5, Form formulaire, GroupBox gd_reponse, PictureBox PbImage)
        {
            if (numQuestion <= nbQuestion)
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
                //appel de la méthode de fin de partie qui sera réalisé plus tard
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

    }
}
