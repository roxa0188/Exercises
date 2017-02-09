using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Tools
    {
        //EX a
        public int BiggerTwoInt(int a, int b)
        {
            if (a < b)
            {
                return b;
            }
            else return a;
        }

        //EX b
        public int BiggerThreeInt(int a, int b, int c)
        {
            if(a>b && a>c)
            {
                return a;
            }
            else if (b>a && b>c)
            {
                return b;
            } 
            else return c;
           
        }

        //EX c
        public char BiggerTwoChar(char a, char b)
        {
            return (char)BiggerTwoInt((int)a, (int)b);
        }

        //EX d & e
        public int GetRemainder(int a, int b)
        {
            int remainder;
            return remainder = a - (this.divide(a,b)) * b;


        }

        int divide(int nu, int de)
        {

            int temp = 1;
            int quotient = 0;

            while (de <= nu)
            {
                de <<= 1;
                temp <<= 1;
            }

            //printf("%d %d\n",de,temp,nu);
            while (temp > 1)
            {
                de >>= 1;
                temp >>= 1;

                if (nu >= de)
                {
                    nu -= de;
                    //printf("%d %d\n",quotient,temp);
                    quotient += temp;
                }
            }

            return quotient;
        }

        //EX f
        public int GetCharsInString(char a, string b)
        {
            int counter = 0;
            foreach (char Char in b)
            {
                return a;
                counter++;
            }
            return counter;
        }

       
    }
}
