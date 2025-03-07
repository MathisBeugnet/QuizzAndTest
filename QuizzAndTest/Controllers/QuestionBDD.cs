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
            ConnectionBDD conn = new ConnectionBDD("192.168.10.16","beugnet_mathis_BDD_QuizzAndTest","beugnet_mathis","3ikikkwF");

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDQUESTION,ENONCEQUESTION AS Enonce,BONREPQUESTION AS 'Bonne Reponse',LABELDIFFICULTE AS Difficulte FROM QUESTION INNER JOIN DIFFICULTE ON QUESTION.IDDIFFICULTE=DIFFICULTE.IDDIFFICULTE;", conn.MySqlCo))
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


    }
}
