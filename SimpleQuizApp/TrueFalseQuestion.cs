﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApp
{
    class TrueFalseQuestion : Question
    {
        private Boolean answer;

        /**
         * Constructor
         * @param questionText - The text for the True/False answer question
         * @param answerText - The correct answer for the short answer question, either "True" or "False", case is irrelevant
         */
        public TrueFalseQuestion(String questionText, String answerText) : base(questionText)
        {
            answer = answerText.Equals("True", StringComparison.InvariantCultureIgnoreCase);
        }
        /**
         * getAnswer()
         * @return The correct answer to this question as a single string, either "True" or "False", case is irrelevant
         */
        public override String getAnswer()
        {
            if (answer)
            {
                return ("True");
            }
            else
            {
                return ("False");
            }
        }
        /**
         * getQuestion()
         * @return Adds "True/False" to the question text
         */
        public override String getQuestion()
        {
            return this.questionText + "(True/False)";
        }
        /**
         * checkAnswer(String givenAnswer)
         * @param givenAnswer - The answer the user entered to be compared with the correct answer, either "True" or "False"
         * @return True is givenAnswer matches the correct answer, this is not case-sensitive
         */
        public override bool checkAnswer(String givenAnswer)
        {
            return (answer == givenAnswer.Equals("True", StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
