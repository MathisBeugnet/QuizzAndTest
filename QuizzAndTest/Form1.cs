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
using QuizzAndTest.Controllers;

namespace QuizzAndTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(153, 180, 209);
            Difficulte dt_listeDifficulte = new Difficulte();
            cb_difficulte.DataSource = dt_listeDifficulte.GetListeDifficulte();
            cb_difficulte.DisplayMember = "Difficulte";
            cb_difficulte.ValueMember = "IDDIFFICULTE";
        }

        private void btn_valider_Click(object sender, EventArgs e)
        {
            int difficultePartie = Convert.ToInt32(cb_difficulte.SelectedIndex.ToString());
            if (txt_nom.Text != "" && txt_prenom.Text != "" && cb_difficulte.SelectedIndex > -1)
            {
                SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).pnl_SF);
                SF.openChildForm(new Jeu(txt_nom.Text, txt_prenom.Text, difficultePartie));
                this.Hide();
            }
            else
            {
                MessageBox.Show("Aucun nom ou prenom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_difficulte.SelectedItem.ToString() == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Bold);
            }
            else
            {
                this.BackColor = Color.FromArgb(153, 180, 209);
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Regular);
            }
        }


        private void btn_fermer1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        
    }
}
