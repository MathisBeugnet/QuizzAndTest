using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizzAndTest.Model
{
    public class Question
    {
        public string enonce;
        public int reponse;
        public int difficulte;
        public string proposition1;
        public string proposition2;
        public string proposition3;
        public string proposition4;
        public string proposition5;

        public Question(string enonce,int reponse,int difficulte,string proposition1,string proposition2,string proposition3,string proposition4,string proposition5)
        {
            this.enonce= enonce;
            this.reponse= reponse;
            this.difficulte= difficulte;
            this.proposition1= proposition1;
            this.proposition2= proposition2;
            this.proposition3= proposition3;
            this.proposition4= proposition4;
            this.proposition5= proposition5;
        }
    }
}
