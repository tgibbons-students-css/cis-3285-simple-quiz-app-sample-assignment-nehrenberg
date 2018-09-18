﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleQuizApp
{
     public class ShortAnswerQuestion : Question
    {
        private String answer;

        /**
         * Constructor
         * @param questionText - The text for the short answer question
         * @param answerText - The correct answer for the short answer question, case is irrelevant
         */
        public ShortAnswerQuestion(string questionText, String answerText) : base(questionText)
        {
            answer = answerText;
        }

        /**
         * getAnswer()
         * @return The correct answer to this question as a single string
         */

        public override string getAnswer()
        {
            return (answer);
        }
        /**
         * checkAnswer(String givenAnswer)
         * @param givenAnswer - The answer the user entered to be compared with the correct answer
         * @return True is givenAnswer matches the correct answer, this is not case-sensitive
         */
        public override bool checkAnswer(String givenAnswer)
        {
            return (answer.Equals(givenAnswer, StringComparison.InvariantCultureIgnoreCase));
        }

        /// <summary>
        /// The function removes all whitespace from a string. So it removes all spaces at the start, middle and end of a string
        ///  ***** Currently this method is never called so a unit test should fail *****
        /// </summary>
        /// <param name="fullString">The given string where whitespaces will be removed</param>
        /// <returns>The given string with all white space removed</returns>
        private String RemoveWhitespace(String fullString)
        { 
            String resultString = String.Concat(fullString.Where(c => !char.IsWhiteSpace(c)));
            return resultString;
        }
    }
}
