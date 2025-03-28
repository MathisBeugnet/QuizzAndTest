using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizzAndTest.Controllers;

namespace QuizzAndTest
{
    public partial class affichageDonnees : Form
    {
        public affichageDonnees()
        {
            InitializeComponent();
            DataView dv;
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            dv = new DataView(dt_listeQuestions.GetListeQuestion());
            dgv_questions.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_questions.Columns["Enonce"].Width = 300;
            dgv_questions.Columns["Difficulte"].Width = 100;
            //Attention il faut mettre le nom des alias à la place du nom des colonnes en cas d’utilisation d’alias dans la requête SQL.
            Difficulte dt_listedifficulte= new Difficulte();
            cbb_difficulte.DataSource = dt_listedifficulte.GetListeDifficulte();
            cbb_difficulte.DisplayMember = "Difficulte";
            cbb_difficulte.ValueMember = "IDDIFFICULTE";

        }

        private void fermer_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txt_rechercheMot_TextChanged(object sender, EventArgs e)
        {
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            DataView dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheMot.Text, cbb_difficulte.SelectedIndex));
            dgv_questions.DataSource = dv;
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            dgv_questions.Columns["Enonce"].Width = 300;
            dgv_questions.Columns["Difficulte"].Width = 100;
            
        }

        private void cbb_difficulte_SelectionChangeCommitted(object sender, EventArgs e)
        {
            QuestionBDD dt_listeQuestions = new QuestionBDD();
            DataView dv = new DataView(dt_listeQuestions.GetListeQuestionRecherche(txt_rechercheMot.Text, cbb_difficulte.SelectedIndex));
            dgv_questions.DataSource = dv;
            dgv_questions.Columns["IDQUESTION"].Visible = false;
            dgv_questions.Columns["Enonce"].Width = 300;
            dgv_questions.Columns["Difficulte"].Width = 100;
        }
    }
}
