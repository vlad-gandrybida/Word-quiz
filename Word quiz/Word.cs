using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_quiz
{
    public class Word
    {
        public string Answer { get; set; }
        public string Discription { get; set; }
        public int CountOfLetters { get => Answer!=String.Empty? Answer.Length : 0; }
        
        public static bool operator==(Word obj,string answer)
        {
            if (answer.Length < obj.CountOfLetters) return false;
            else
            {
                if (answer.Substring(0, obj.CountOfLetters) == obj.Answer) return true;
                return false;
            }
        }

        public static bool operator!=(Word obj,string answer)
        {
            return !(obj == answer);
        }
    }
}
