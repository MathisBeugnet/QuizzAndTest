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
    public class QuestionBDD
    {

        public DataTable GetListeQuestion()
        {
            DataTable dt = new DataTable();
            ConnectionBDD conn = new ConnectionBDD("192.168.10.16", "beugnet_mathis_BDD_QuizzAndTest", "beugnet_mathis", "3ikikkwF");

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION,ENONCEQUESTION AS Enonce, LABELDIFFICULTE AS Difficulte FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE=DIFFICULTE.IDDIFFICULTE;", conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }

            conn.MySqlCo.Close();
            conn.MySqlCo = null;
            return dt;
        }
        public DataTable GetListeQuestionRecherche(string rechercheMot, int difficulte)
        {
            string rqtSql = "SELECT IDQUESTION,ENONCEQUESTION AS Enonce,LABELDIFFICULTE AS Difficulte FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE=DIFFICULTE.IDDIFFICULTE";
            if (rechercheMot != "" || difficulte != 0)
            {
                rqtSql += " WHERE ";
                if (rechercheMot!="")
                {
                    rqtSql += "ENONCEQUESTION LIKE @rechercheMot";

                }
                if (difficulte != 0)
                {
                    if (rechercheMot != "")
                    {
                        rqtSql += " AND ";

                    }
                    rqtSql += "DIFFICULTE.IDDIFFICULTE=@difficulte";

                }
            }
            rqtSql +=";";
            DataTable dt = new DataTable();
            try
            {
                ConnectionBDD conn = new ConnectionBDD();
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.MySqlCo))
                {
                    conn.MySqlCo.Open();
                    if (rechercheMot != "")
                    {
                        cmd.Parameters.AddWithValue("@rechercheMot", "%" + rechercheMot + "%");
                    }
                    if (difficulte != 0)
                    {
                        cmd.Parameters.AddWithValue("@difficulte", difficulte);
                    }
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dt.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dt;

        }
    }
}
