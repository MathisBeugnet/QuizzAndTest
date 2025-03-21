using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
using QuizzAndTest.Model;

namespace QuizzAndTest.Controllers
{
    class Difficulte
    {
        public DataTable GetListeDifficulte()
        {
            DataTable dtListeDifficulte = new DataTable();
            ConnectionBDD conn = new ConnectionBDD("192.168.10.16", "beugnet_mathis_BDD_QuizzAndTest", "beugnet_mathis", "3ikikkwF");


            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE,LABELDIFFICULTE AS Difficulte FROM DIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeDifficulte.Load(reader);
                }
                DataRow workRow = dtListeDifficulte.NewRow();
                workRow[0] = -1;
                workRow[1] = "";
                dtListeDifficulte.Rows.InsertAt(workRow, 0);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dtListeDifficulte;
        }

    }
}
