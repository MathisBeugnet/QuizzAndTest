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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            pnl_SF.Controls.Add(formEnfant);
            pnl_SF.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();
        }
        private void démarerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnl_SF);
            SF.openChildForm(new Form1());
        }

        private void afficherDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire(pnl_SF);
            SF.openChildForm(new affichageDonnees());
        }
    }
}
