using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_quiz
{
    public class Level
    {
        public List<Word> Words = new List<Word>();

        public List<int> results = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        public List<string> hidden;

        public List<string> Hidden { get
            {
                if(hidden == null)
                {
                    hidden = new List<string>();
                    foreach (Word word in Words)
                    {
                        string ans = "";
                        foreach(char i in word.Answer)
                        {
                            ans += "_";
                        }
                        hidden.Add(ans);
                    }
                    return hidden;
                }
                else
                {
                    return hidden;
                }
            }
            set
            {
                hidden = value;
            }
        }

        public int CheckAnswer(string answer, int word)
        {
            if (Words[word].Answer.ToLower() == answer.ToLower())
            {
                if (results[word] == 1)
                {
                    return 2;
                }
                results[word] = 1;
                return 1;
            }
            else
            {
                results[word] = -1;
                return 0;
            }
        }

        Random random = new Random();

        internal void Help(int index)
        {
            int count = 0;
            foreach(var j in Hidden[index])
            {
                if (j !='_') count++;
            }
            if (count > 1) return;
            int d = 0;
            do
            {
                d = random.Next(0, Hidden[index].Length);
            } while (Hidden[index][d] != '_');
            var check = new StringBuilder(Hidden[index]);
            check[d] = Words[index].Answer[d];
            hidden[index] = check.ToString();

        }
    }
}
