using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet1_questions.modele
{
    class QuestionDejaPresenteException : Exception
    {
        public Question ques { get; set; }

        public QuestionDejaPresenteException()
        {
        }

        public QuestionDejaPresenteException(Question ques, String message) : base(message)
        {
            this.ques = ques;
        }

   
    }
}
