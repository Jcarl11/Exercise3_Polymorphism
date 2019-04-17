using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Polymorphism {
    class TrueFalseQuestion : IQuestion{
        private string myAnswer;
        private string myText;

        public bool CheckAnswer() {
            throw new NotImplementedException();
        }

        public string GetAnswer() {
            throw new NotImplementedException();
        }

        public string GetQuestion() {
            throw new NotImplementedException();
        }
    }
}
