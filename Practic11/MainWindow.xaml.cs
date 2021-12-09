using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;

namespace Practic11
{
    /// <summary>
    /// ИСП-31. Назаров Д. Вариант 2. Дана строка 'aba aca aea abba adca abea'. Напишите регулярное выражение, которое найдет строки abba adca abea.
    ///Дана строка 'ave a#b a2b a$b a4b a5b a-b acb'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между ними - не буква и не цифра
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calculate1programm_Click(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            string line = outLine1.Text;
            Regex regex = new Regex("a..a");
            MatchCollection match = regex.Matches(line);
            for (int i = 0; i < match.Count; i++) 
            {
                listBox1.Items.Add(match[i]);
            }
        }

        private void calculate2programm_Click(object sender, RoutedEventArgs e)
        {
            listBox2.Items.Clear();
            string line = outLine2.Text;
            Regex regex = new Regex("a[^a-z || 0-9]b");
            MatchCollection match = regex.Matches(line);
            for (int i = 0; i < match.Count; i++)
            {
                listBox2.Items.Add(match[i]);
            }
        }
        
        private void info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31. Назаров Д. Вариант 2. \nДана строка 'aba aca aea abba adca abea'. Напишите регулярное выражение, которое найдет строки abba adca abea. \nДана строка 'ave a#b a2b a$b a4b a5b a-b acb'. Напишите регулярное выражение, которое найдет строки следующего вида: по краям стоят буквы 'a' и 'b', а между ними - не буква и не цифра","О программе");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
