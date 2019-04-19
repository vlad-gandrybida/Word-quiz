﻿using System;
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
using System.Windows.Shapes;

namespace Word_quiz
{
    /// <summary>
    /// Interaction logic for AnswerDialog.xaml
    /// </summary>
    public partial class AnswerDialog : Window
    {

        public AnswerDialog(string answer)
        {
            InitializeComponent();

            resultBox.Text = answer;

            this.Show();
        }
    }
}
