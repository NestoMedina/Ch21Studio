using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch21Studio
{
    public class Questions
    {
        public Dictionary<int, string> Quest = new Dictionary<int, string>();
        public Dictionary<int, string> TestAnswers = new Dictionary<int, string>();
        private static int iQ = 0;
        public void AddQuestions(string question)
        {
            this.Quest.Add(iQ, question);
            iQ++;
        }

        public void AddSingleAnswer(string name)
        {
            this.TestAnswers.Add(iQ, name.ToLower());
        }

        public void AddMultipleAnswers(string name)
        {
            string newname = name.Replace(" ", "");
            string[] newarr = newname.Split(',');
            Array.Sort(newarr);
            string newString = string.Join(',', newarr);
            this.TestAnswers.Add(iQ, newString.ToLower());
        }


    }
}
