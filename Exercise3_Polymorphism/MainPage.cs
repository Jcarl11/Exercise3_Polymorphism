using System;
using System.Windows.Forms;

namespace Exercise3_Polymorphism {
    public partial class MainPage : Form {
        SimpleQuiz simpleQuiz;
        double passing = 0.7; //  70%
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
            int userScore = simpleQuiz.getScore();
            int overall = simpleQuiz.getQuestionSize();

            string passingScore = ((int)Math.Round( overall * passing )).ToString();
            string remark = userScore >= ((int)Math.Round( overall * passing )) ? "PASSED" : "FAILED";
            
            String score = String.Format( "{0} / {1}",
                userScore.ToString(),
                overall.ToString() );

            MessageBox.Show( String.Format( "SCORE: {0} \nREMARK: {1} \nPASSING: {2}", score, remark, passingScore ) );

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
