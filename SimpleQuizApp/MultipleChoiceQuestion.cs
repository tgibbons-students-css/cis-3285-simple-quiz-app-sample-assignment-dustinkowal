using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApp
{
    public class MultipleChoiceQuestion : Question
    {

        String[] possibleAnswers;
        int answerIndex;

        public MultipleChoiceQuestion(String questionText, String[] possibleAnswers, int answerIndex) : base(questionText)
        {
            this.possibleAnswers = possibleAnswers;
            this.answerIndex = answerIndex;
        }

        /**
         * getQuestion()
         * @return Adds newline after each possible answer
         */
        public override string getQuestion()
        {
            String fullQuestion = questionText + "\n";
            foreach (String s in possibleAnswers)
            {
                fullQuestion += s + "\n";
            }
            return fullQuestion;
        }

        public override string getAnswer()
        {
            return possibleAnswers[answerIndex];
        }

        public override bool checkAnswer(String givenAnswer)
        {
            return (givenAnswer.Equals(possibleAnswers[answerIndex], StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
