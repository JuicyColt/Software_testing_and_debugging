using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Seldin
{
    public class Module1
    {
        //  перенести последнюю букву в начало слова;
        public static string InsertLastLetterToTheBeginning(string text) {
            char last_letter;
            var sb = new StringBuilder(text);
            last_letter = text[text.Length - 1];
            sb.Insert(0, last_letter);
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        //   удалить из слова повторные вхождения каждой буквы.
        public static string DeleteDuplicateLetters(string text)
        {
            string anwser = "";
            char tmp;
            for (int i=0; i < text.Length; i++)
            {
                tmp = text[i];
                if (anwser.IndexOf(tmp)==-1 & tmp != ' ')
                {
                    anwser = anwser.Insert(anwser.Length, tmp.ToString());
                }
            }
            return anwser.ToString();
        }
    }
}
