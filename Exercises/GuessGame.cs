using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class GuessGame
    {
        private static Random random = new Random();
        private int randomNumber;
        private int guesses = 0;



        public GuessGame()
        {
            randomNumber = random.Next(1, 100);
        }

        public int Guess(int guess)
        {


            guesses++;
            int result = 0;
            if(guesses>7)
            {
                throw new Exception("You are out of guesses!");
            }

            if (guess == randomNumber)
            {
                result = 0;
            }

            else if (guess > randomNumber)
            {
                result = 1;
            }
                
            else if (guess < randomNumber)
            {
                result = -1;
            }
            return result;

        }


    }
}
