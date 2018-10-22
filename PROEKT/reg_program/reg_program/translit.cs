using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace reg_program
{
  public class translit
  {
      public string trans(string src)
      {
          Dictionary<string, string> words = new Dictionary<string, string>();
          words.Add("а", "a");
          words.Add("б", "b");
          words.Add("в", "v");
          words.Add("г", "g");
          words.Add("д", "d");
          words.Add("е", "e");
          words.Add("ё", "yo");
          words.Add("ж", "zh");
          words.Add("з", "z");
          words.Add("и", "i");
          words.Add("й", "j");
          words.Add("к", "k");
          words.Add("л", "l");
          words.Add("м", "m");
          words.Add("н", "n");
          words.Add("о", "o");
          words.Add("п", "p");
          words.Add("р", "r");
          words.Add("с", "s");
          words.Add("т", "t");
          words.Add("у", "u");
          words.Add("ф", "f");
          words.Add("х", "h");
          words.Add("ц", "c");
          words.Add("ч", "ch");
          words.Add("ш", "sh");
          words.Add("щ", "sch");
          words.Add("ъ", "j");
          words.Add("ы", "i");
          words.Add("ь", "j");
          words.Add("э", "e");
          words.Add("ю", "yu");
          words.Add("я", "ya");
          words.Add("А", "a");
          words.Add("Б", "b");
          words.Add("В", "v");
          words.Add("Г", "g");
          words.Add("Д", "d");
          words.Add("Е", "e");
          words.Add("Ё", "yo");
          words.Add("Ж", "zh");
          words.Add("З", "z");
          words.Add("И", "i");
          words.Add("Й", "j");
          words.Add("К", "k");
          words.Add("Л", "l");
          words.Add("М", "m");
          words.Add("Н", "n");
          words.Add("О", "o");
          words.Add("П", "p");
          words.Add("Р", "r");
          words.Add("С", "s");
          words.Add("Т", "t");
          words.Add("У", "u");
          words.Add("Ф", "f");
          words.Add("Х", "h");
          words.Add("Ц", "c");
          words.Add("Ч", "ch");
          words.Add("Ш", "sh");
          words.Add("Щ", "sch");
          words.Add("Ъ", "j");
          words.Add("Ы", "i");
          words.Add("Ь", "j");
          words.Add("Э", "e");
          words.Add("Ю", "yu");
          words.Add("Я", "ya");
          words.Add(", ", "_");
          words.Add(" ", "_");
          words.Add(",", "_");

          foreach (KeyValuePair<string, string> pair in words)
          {
              src = src.Replace(pair.Key, pair.Value);
          }
          
          return src;
      }
  }
}
