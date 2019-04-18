using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Polymorphism {
    class SimpleQuiz {
        private List<IQuestion> myQuestions;
        private int currentQuestion;
        public SimpleQuiz() {
            myQuestions = new List<IQuestion>();
            myQuestions.Add(new ShortAnswerQuestion("1What is the capital of the Philippines?", "MANILA"));
            myQuestions.Add( new ShortAnswerQuestion( "2What is the name of our national hero?", "JOSE RIZAL" ));
            myQuestions = shuffileList( myQuestions );
            currentQuestion = 0;
        }
        public string getCurrentAnswer() {
            return myQuestions.ElementAt( currentQuestion ).GetAnswer();
        }

        public string getCurrentQuestion() {
            return myQuestions.ElementAt( currentQuestion ).GetQuestion();
        }

        public bool checkCurrentAnswer(string answer) {
            return myQuestions.ElementAt( currentQuestion ).CheckAnswer( answer );
        }

        public bool hasNext() {
            return currentQuestion < myQuestions.Count - 1;
        }

        public void next() {
            if(currentQuestion == myQuestions.Count - 1) {
                throw new Exception( "There are no more questions." );
            }
            currentQuestion++;
        }

        public List<IQuestion> shuffileList(List<IQuestion> list) {
            List<IQuestion> newList = new List<IQuestion>();
            Random r = new Random();
            int randomIndex = 0;
            while (list.Count > 0) {
                randomIndex = r.Next( 0, list.Count );
                newList.Add( list[randomIndex] );
                list.RemoveAt( randomIndex );
            }
            return newList;
        }
    }
}
