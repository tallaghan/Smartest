using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Entities
{
    public class Question
    {
        public int Answer { get; set; }

        public String Operator { get; set; }

        public int Number1 { get; set; }

        public int Number2 { get; set; }

        public int[] Choices
        {
            get
            {
                return _choices;
            }
        }

        private int[] _choices = new int[4];

        private String[] _operators = new String[] { "+", "-", "*", "/" };

        public Question(int num1, int num2, String oper )
        {

            Number1 = num1;
            Number2 = num2;
            Operator = oper;

            Answer = GetAnswer(num1, num2, oper);

            GenerateChoices(Answer);

        }


        public Question()
        {
            GenerateRandomQuestion();
            GenerateChoices(Answer);
        }

        private void GenerateChoices(int answer)
        {

            long currentTicks = DateTime.Now.Ticks;

            long seed = currentTicks % int.MaxValue;

            int answerIndex = new Random((int)seed).Next(0, 3);                       

            for (int i=0; i<4; i++) {

                if (i == answerIndex) {
                    _choices[answerIndex] = answer;

                } else {

                    int option = GenerateRandomInteger(1, 99);

                    while (_choices.Contains(option)) {
                        option = GenerateRandomInteger(1, 99);
                    }

                    _choices[i] = option;
                }
            }

        }

        private void GenerateRandomQuestion(){

            Number1 = GenerateRandomInteger(1, 99);

            Number2 = GenerateRandomInteger(1, 99);

            int numOperators = _operators.Length;
            
            int operIndex = GenerateRandomInteger(0, numOperators-1);

            Operator = _operators[operIndex];

            Answer = GetAnswer(Number1, Number2, Operator);

        }

        private int GenerateRandomInteger(int minVal, int maxVal)
        {
            long currentTicks = DateTime.Now.Ticks;

            long seed = currentTicks % int.MaxValue;

            return new Random((int)seed).Next(minVal, maxVal);

        }
        private int GetAnswer(int num1, int num2, String oper)
        {

            int answer = 0;

            switch (oper)
            {
                case "+":
                    answer = num1 + num2;
                    break;

                case "-":
                    answer = num1 - num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

            }

            return answer;

        }

    }
}