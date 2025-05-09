using QuizzAndTest.Controllers;
using QuizzAndTest.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizzAndTest
{
    public partial class Jeu : Form
    {
        int reponseQuestion = 0;
        int difficulte = 1;

        Partie partie;

        private void Init()
        {
            InitializeComponent();
            List<Question> ListeQuestion = new List<Question>();
            ListeQuestion=new QuestionBDD().GetListeQ(difficulte);
            partie = new Partie(ListeQuestion);
            partie.changerQuestion(tb_question, lbl_question, rep1, rep2, rep3, rep4, rep5, this, gb1, pb1, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_SF);
            partie.gestionTimer(txt_timer, lbl_question, pb_dureeRepQuestion, tb_question, rep1, rep2, rep3, rep4, rep5, this, gb1, pb1, lbl_question, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_SF);
        }
        

        public Jeu(string nomJ, string PrenomJ, int difficultePartie)
        {
            Init();
            difficulte = difficultePartie;
            tb_joueur.Text = nomJ+" "+PrenomJ;
            tb_difficulte.Text = difficultePartie.ToString();
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            partie.validerReponse(reponseQuestion, pb1);
            partie.numQuestion++;
            partie.changerQuestion(tb_question, lbl_question, rep1, rep2, rep3, rep4, rep5, this, gb1, pb1, (System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_SF);
            lbl_question.Text = "Question "+(partie.numQuestion + 1).ToString();
            reponseQuestion = 0;
            pb_dureeRepQuestion.Value = 0;
            partie.dureeTQuestion = 0;
        }

        private void rep1_Click(object sender, EventArgs e)
        { 
            
            //Boucle permettant de décocher toutes les cases à cocher du formulaire
            foreach (var box in gb1.Controls.OfType<CheckBox>())
            {
                box.Checked = false;
            }
    
            ((CheckBox)sender).Checked = true;
            reponseQuestion = Convert.ToInt32(((CheckBox)sender).Name.Remove(0, 3));
            
        }

        private void btn_fermer2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
