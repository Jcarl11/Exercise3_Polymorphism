using System;
using System.Windows.Forms;

namespace Exercise3_Polymorphism {
    public partial class MainPage : Form {
        SimpleQuiz simpleQuiz;
        public MainPage() {
            InitializeComponent();
            simpleQuiz = new SimpleQuiz();
            startQuiz();
        }

        private void startQuiz() {
            question_question.Text = simpleQuiz.getCurrentQuestion();
        }

        private void endQuiz() {
            question_question.Text = "Quiz Finished";
            question_answer.Enabled = false;
        }

        private void performClick() {
            try {
                if (simpleQuiz.checkCurrentAnswer( question_answer.Text )) {
                    question_message.Text = "Well done!";
                } else {
                    question_message.Text = String.Format("Sorry, the answer was {0}", simpleQuiz.getCurrentAnswer());
                }
                question_answer.Clear();
                if (simpleQuiz.hasNext()) {
                    try {
                        simpleQuiz.next();
                        startQuiz();
                    }catch(Exception) {
                        endQuiz();
                    }
                } else {
                    endQuiz();
                }
            }catch(Exception ex) {
                question_message.Text = ex.Message;
            }
        }
        private void Question_answer_KeyDown( object sender, KeyEventArgs e ) {
            if(e.KeyCode == Keys.Enter) {
                performClick();
            }
        }
    }
}
