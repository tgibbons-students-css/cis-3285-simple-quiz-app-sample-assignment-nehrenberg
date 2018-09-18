using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleQuizApp
{
    public partial class Form1 : Form
    {
        //declare the quiz model
        SimpleQuizModel quiz;

        public Form1()
        {
            InitializeComponent();
            //initialize the quiz model and display the first question
            quiz = new SimpleQuizModel();
            txtQuestion.Text = quiz.getCurrentQuestion();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCheckAnswer_Click(object sender, EventArgs e)
        {
            String answer = txtAnswer.Text;
            bool correct = quiz.checkCurrentAnswer(answer);
            if (correct)
                txtFeedback.Text = "Correct!";
            else
                txtFeedback.Text = "Incorrect; the correct answer is: " + quiz.getCurrentAnswer();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNextQuestion_Click(object sender, EventArgs e)
        {
            // TODO add your handling code here:
            //clear the feedback, answer and question
            txtQuestion.Text = "";
            txtAnswer.Text = "";
            txtFeedback.Text = "";
            //advance the question
            if (quiz.hasNext())
            {
                quiz.next();
                txtQuestion.Text = quiz.getCurrentQuestion();
            }
            else
            {
                txtQuestion.Text = "No more questions!";
            }
        }
    }
}
