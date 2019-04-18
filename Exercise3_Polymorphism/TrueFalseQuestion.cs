using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Polymorphism {
    class TrueFalseQuestion : IQuestion{
        private string myAnswer;
        private string myText;

        public TrueFalseQuestion( string myText, string myAnswer ) {
            this.myAnswer = myAnswer;
            this.myText = myText;
        }

        public bool CheckAnswer( string answer ) {
            return myAnswer.Equals( answer, StringComparison.OrdinalIgnoreCase );
        }

        public string GetAnswer() {
            return myAnswer;
        }

        public string GetQuestion() {
            return myText;
        }
    }
}
