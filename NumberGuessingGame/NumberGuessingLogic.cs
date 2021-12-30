using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGuessingGame
{
    public class NumberGuessingLogic
    {
        public int Lives;
        public int currentAnswer;
        private static Random random = new Random();
        private static int hints;

        public void GameSetup(int lives, int max)
        {
            var random = new Random();
            currentAnswer = random.Next(1,max);
            Lives = lives;
        }

        
        public string CheckAnswer(int userAnswer)
        {

            if (userAnswer != currentAnswer)
            {
                Lives--;
                
                if (Lives > 0)
                {
                    return $"Wrong answer, The correct answer is {AboveOrBelow(currentAnswer, userAnswer).ToLower()}";
                }
                else
                {
                    
                    return $"Wrong answer, you're out of lives!";
                }
            }
            else if (userAnswer == currentAnswer)
            {
                Lives = 0;
                return "Correct Answer! You win";
            }
            else
            {
                return null;
            }
        }

        public string GiveRandomHint()
        {
            hints = random.Next(0, 2);
            if (hints == 0 || currentAnswer == 50)
            {
                return EvenOrOdd(currentAnswer);
            }
            else if (hints == 1)
            {
                return AboveOrBelow(currentAnswer, 50);
            }
            else
            {
                return null;
            }
        }
        public static string EvenOrOdd(int correctAnswer)
        {
            if (correctAnswer % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }
        public static string AboveOrBelow(int correctAnswer, int condition)
        {
            if (correctAnswer < condition)
            {
                return $"Below {condition}";
            }
            else
            {
                return $"Above {condition}";
            }
        }

        public void EndGame()
        {

        }
    }
}
