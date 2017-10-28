using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcYourBrainMainMenuGUI
{
    public class Level
    {
        public int Num;
        public String Calc;
        public int Score;
        public int Number1;
        public int Number2;
        public char ope;

        public Level()
        {
            Num = 1;
            Calc = null;
            Score = 1;
        }

        public void GenerateCalc()
        {
            Random rand = new Random();
            int pioche;
            if(Num <= 10)
            {
                pioche = rand.Next(0,2);

                if (pioche == 0)
                {
                    ope = '+';
                    Score = 1;
                }
                else
                {
                    ope = '-';
                    Score = 2;
                }

                Number1 = rand.Next(0, 20);
                Number2 = rand.Next(0, 20);

                Calc = "" + Number1 + " " + ope + " " + Number2;
            }
            else if(Num <= 20)
            {
                pioche = rand.Next(0, 3);

                if (pioche == 0)
                {
                    ope = '+';
                    Score = 1;
                }
                else if(pioche == 1)
                {
                    ope = '-';
                    Score = 2;
                }
                else
                {
                    ope = '*';
                    Score = 5;
                }

                Number1 = rand.Next(-Num, Num);
                Number2 = rand.Next(-Num, Num);

                Calc = "" + Number1 + " " + ope + " " + Number2;
            }
            else if(Num <= 30)
            {
                pioche = rand.Next(0, 6);

                if (pioche == 0)
                {
                    ope = '+';
                    Score = 1;
                }
                else if (pioche == 1)
                {
                    ope = '-';
                    Score = 2;
                }
                else if(pioche <= 3)
                {
                    ope = '*';
                    Score = 5;
                }
                else
                {
                    ope = '/';
                    Score = 10;
                }

                Number1 = rand.Next(-Num, Num);
                Number2 = rand.Next(-Num, Num);

                Calc = "" + Number1 + " " + ope + " " + Number2;
            }
            else if(Num <= 40)
            {
                pioche = rand.Next(0, 10);

                if (pioche == 0)
                {
                    ope = '+';
                }
                else if (pioche == 1)
                {
                    ope = '-';
                }
                else if (pioche <= 5)
                {
                    ope = '*';
                }
                else
                {
                    ope = '/';
                }

                Number1 = rand.Next(-Num, Num);
                Number2 = rand.Next(-Num, Num);

                Calc = "" + Number1 + " " + ope + " " + Number2;
            }
            else
            {
                pioche = rand.Next(0, 16);

                if (pioche == 0)
                {
                    ope = '+';
                    Score = 1;
                }
                else if (pioche == 1)
                {
                    ope = '-';
                    Score = 2;
                }
                else if (pioche <= 9)
                {
                    ope = '*';
                    Score = 5;
                }
                else
                {
                    ope = '/';
                    Score = 10;
                }

                Number1 = rand.Next(-Num, Num);
                Number2 = rand.Next(-Num, Num);

                Calc = "" + Number1 + " " + ope + " " + Number2;
            }
            
        }

        public Boolean ResolvCalc(double response)
        {
            double result = 0;

            switch(ope)
            {
                case '+': result = Number1 + Number2;
                    break;
                case '-':
                    result = Number1 - Number2;
                    break;
                case '*':
                    result = Number1 * Number2;
                    break;
                case '/':
                    result = Number1 / Number2;
                    break;
            }

            if(response == result)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }
}
