using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_Polymorphism {
    interface IQuestion {
        string GetQuestion();
        string GetAnswer();
        bool CheckAnswer(string answer);
    }
}
