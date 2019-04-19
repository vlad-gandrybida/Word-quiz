using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Word_quiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game WordQuiz = new Game();
        public MainWindow()
        {
            InitializeComponent();

            Description_1.Text = WordQuiz.Level_1.Words[0].Discription;
            Description_2.Text = WordQuiz.Level_1.Words[1].Discription;
            Description_3.Text = WordQuiz.Level_1.Words[2].Discription;
            Description_4.Text = WordQuiz.Level_1.Words[3].Discription;
            Description_5.Text = WordQuiz.Level_1.Words[4].Discription;
            Description_6.Text = WordQuiz.Level_1.Words[5].Discription;
            Description_7.Text = WordQuiz.Level_1.Words[6].Discription;
            Description_8.Text = WordQuiz.Level_1.Words[7].Discription;
            Description_9.Text = WordQuiz.Level_1.Words[8].Discription;
            Description_10.Text = WordQuiz.Level_1.Words[9].Discription;
        }

        private void Level_2()
        {
            Description_1.Text = WordQuiz.Level_2.Words[0].Discription;
            Description_2.Text = WordQuiz.Level_2.Words[1].Discription;
            Description_3.Text = WordQuiz.Level_2.Words[2].Discription;
            Description_4.Text = WordQuiz.Level_2.Words[3].Discription;
            Description_5.Text = WordQuiz.Level_2.Words[4].Discription;
            Description_6.Visibility = Visibility.Hidden;
            Description_7.Visibility = Visibility.Hidden;
            Description_8.Visibility = Visibility.Hidden;
            Description_9.Visibility = Visibility.Hidden;
            Description_10.Visibility = Visibility.Hidden;
            button_10.Visibility = Visibility.Hidden;
            button_9.Visibility = Visibility.Hidden;
            button_8.Visibility = Visibility.Hidden;
            button_7.Visibility = Visibility.Hidden;
            button_6.Visibility = Visibility.Hidden;
            changed1 = true;
        }

        private void Level_3()
        {
            Description_1.Text = WordQuiz.Level_3.Words[0].Discription;
            Description_2.Text = WordQuiz.Level_3.Words[1].Discription;
            Description_3.Text = WordQuiz.Level_3.Words[2].Discription;
            Description_4.Visibility = Visibility.Hidden;
            Description_5.Visibility = Visibility.Hidden;
            button_5.Visibility = Visibility.Hidden;
            button_4.Visibility = Visibility.Hidden;
            changed2 = true;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(1);
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(2);
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(3);
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(4);
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(5);
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(6);
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(7);
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(8);
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(9);
        }

        private void Button_10_Click(object sender, RoutedEventArgs e)
        {
            SetGameQuestion(10);
        }

        private void SetGameQuestion(int question)
        {
            _1_2.Visibility = Visibility.Hidden;
            Question.Visibility = Visibility.Visible;
            WordQuiz.CurrentQuestion = question-1;
            switch (WordQuiz.Level)
            {
                case 1:
                    Description.Text = WordQuiz.Level_1.Words[WordQuiz.CurrentQuestion].Discription;
                    Letters.Text = WordQuiz.Level_1.Hidden[WordQuiz.CurrentQuestion];
                    break;
                case 2:
                    Description.Text = WordQuiz.Level_2.Words[WordQuiz.CurrentQuestion].Discription;
                    Letters.Text = WordQuiz.Level_2.Hidden[WordQuiz.CurrentQuestion];
                    break;
                case 3:
                    Description.Text = WordQuiz.Level_3.Words[WordQuiz.CurrentQuestion].Discription;
                    Letters.Text = WordQuiz.Level_3.Hidden[WordQuiz.CurrentQuestion];
                    break;
            }
        }

        private void AnswerClear()
        {
            Points.Text = WordQuiz.Points.ToString();
            Level_count.Text = WordQuiz.Level.ToString();

            _1_2.Visibility = Visibility.Visible;
            Question.Visibility = Visibility.Hidden;

            answer.Text = "Введіть вашу відповідь тут";
        }

        private bool changed1 = false;
        private bool changed2 = false;

        private void Answer_button_Click(object sender, RoutedEventArgs e)
        {
            if (WordQuiz.CheckAnswer(answer.Text) == 1)
            {
                if (WordQuiz.Level == 2 && !changed1) Level_2();
                if (WordQuiz.Level == 3 && !changed2) Level_3();

                AnswerClear();
                if (WordQuiz.Points >= 30) {
                    new AnswerDialog("Ви виграли!!!");
                    return;
                } 
                new AnswerDialog("Правильно!");
            }
            else if (WordQuiz.CheckAnswer(answer.Text) == -1)
            {
                AnswerClear();
                
                new AnswerDialog("Вже введено!");
            }
            else
            {
                new AnswerDialog("Не правильно!");
            }
           
        }

        private void Help_Click(object sender, RoutedEventArgs e)
        {
            WordQuiz.Help();
            if (WordQuiz.Level == 1)
            {
                Letters.Text = WordQuiz.Level_1.Hidden[WordQuiz.CurrentQuestion];
            }
            else if (WordQuiz.Level == 2)
            {
                Letters.Text = WordQuiz.Level_2.Hidden[WordQuiz.CurrentQuestion];
            }
            else
            {
                Letters.Text = WordQuiz.Level_3.Hidden[WordQuiz.CurrentQuestion];
            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            _1_2.Visibility = Visibility.Visible;
            Question.Visibility = Visibility.Hidden;
        }
    }
}
