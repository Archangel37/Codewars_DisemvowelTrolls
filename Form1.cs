using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codewars_DisemvowelTrolls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

//A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
//Your task is to write a function that takes a string and return a new string with all vowels removed.
//For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

//best solution:
//using System;
//using System.Text.RegularExpressions;

//public static class Kata
//{
//  public static string Disemvowel(string str)
//  {
//    return Regex.Replace(str,"[aeiou]", "", RegexOptions.IgnoreCase);
//  }
//}
//one more:
//        using System;
//using System.Linq;

//public static class Kata
//{
//  public static string Disemvowel(string str)
//  {
//    return string.Concat(str.Where(ch => !"aeiouAEIOU".Contains(ch)));
//  }
//}


        public string Disemvowel(string words)
        {
            List<char> vowelsLellers = new List<char> {'A', 'E', 'I', 'O', 'U', 'a', 'e', 'i', 'o', 'u'};

            foreach(char ch in words)
            {
            if (vowelsLellers.Contains(ch))
             words = words.Replace(Convert.ToString(ch), string.Empty); 
            }
            return words;
        }


        private void button_convert_Click(object sender, EventArgs e)
        {
            richTextBox_output.Text = Disemvowel(richTextBox_input.Text);
            
        }
    }
}
