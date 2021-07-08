using System;
using System.Collections.Generic;

namespace ch21Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz One = new Quiz();
            One.AddQuestions("What planet number is the Earth away from the Sun?\n- 2\n- 3\n- 4\n- 5");
            One.AddSingleAnswer("3");

            One.AddQuestions("Pick three colors of the rainbow: (separate answers by a comma)\n- pink\n- red\n- blue\n- orange\n- white\n- gold");
            One.AddMultipleAnswers("red, blue, orange");

            One.AddQuestions("True or False: There are four primary colors.");
            One.AddSingleAnswer("false");

            One.AddQuestions("True or False: Transportation is key infrastructure in the United States.");
            One.AddSingleAnswer("true");

            One.AddQuestions("Who are the four presidents on Mount Rushmore? Only enter their last names. (separate answers by a comma)");
            One.AddMultipleAnswers("washington, jefferson, roosevelt, lincoln");

            One.PrintQuestionsReceiveAnswers();

            foreach(var i in One.UserAnswers)
            {
                Console.WriteLine(i);
            }
            foreach (var i in One.TestAnswers)
            {
                Console.WriteLine(i);
            }

            One.GetGrade();

        }   
    }
}
