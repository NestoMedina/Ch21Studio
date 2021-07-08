using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch21Studio
{
    public class Quiz : Questions
    {
        public List<string> UserAnswers = new List<string>();
        
        public void PrintQuestionsReceiveAnswers()
        {
            foreach(KeyValuePair<int,string> kvp in Quest)
            {
                Console.WriteLine(kvp.Value);
                string answer = Console.ReadLine();
                if (answer.Length > 6)
                {
                    string newanswer = answer.Replace(" ", "");
                    string[] newarr = newanswer.Split(',');
                    Array.Sort(newarr);
                    string newString = string.Join(',', newarr);
                    this.UserAnswers.Add(newString.ToLower());
                }
                else if (answer.Length < 6)
                {
                    this.UserAnswers.Add(answer.ToLower());
                }
            }
        }

        private static int k = 0;
        public void GetGrade()
        {
            foreach(KeyValuePair<int,string> kvp in TestAnswers)
            {
                foreach(string ua in UserAnswers)
                {
                    if (kvp.Value == ua)
                    {
                        k++;
                        break;
                    }
                }
            }
            if (k >= 4)
            {
                Console.WriteLine($"Congratulations you passed with a grade of {k * 20}%");
            }
            else
            {
                Console.WriteLine($"Unfortunately, you did not pass with a grade of {k * 20}%");
            }
        }


    }
}
