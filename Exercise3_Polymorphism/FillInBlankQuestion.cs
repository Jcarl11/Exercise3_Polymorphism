﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Polymorphism {
    class FillInBlankQuestion : IQuestion {
        private string myAnswer;
        private string myText;

        public bool CheckAnswer( string answer ) {
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
