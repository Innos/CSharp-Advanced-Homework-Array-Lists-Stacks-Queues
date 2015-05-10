using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class TerroristsWin
{
    static void Main(string[] args)
    {
        //declarations and initialization
        int bombPower = 0;
        int start = 0;
        int innerLength = 0;
        int explosionRigth = 0;
        int explosionLeft = 0;
        bool bombFound = false;
        string sentence = Console.ReadLine();

        //Looking for the start of a bomb
        for (int i = 0; i < sentence.Length; i++)
        {
            if(sentence[i] == '|')
            {
                bombFound = !bombFound;
                //finding the begining of a bomb
                if(bombFound)
                {
                    start = i;
                    bombPower = 0;
                }
                //ending of a bomb
                else
                {
                    int end = i;
                    innerLength = (end - start) - 1;
                    //parse input of the bomb
                    for (int l = start+1; l <end; l++)
                    {
                        bombPower += sentence[l];
                    }

                    bombPower = int.Parse(bombPower.ToString().Last().ToString());
                    explosionRigth = (innerLength + 2) + bombPower;
                    explosionLeft = bombPower;

                    //checking if the radius is bigger than the string
                    if(start + explosionRigth > sentence.Length )
                    {
                        explosionRigth = sentence.Length - start;
                    }
                    if(explosionLeft > start)
                    {
                        explosionLeft = start;
                    }
                    //exploding the string
                    int explosion = explosionLeft + explosionRigth;
                    string boom = new string('.', explosion);
                    sentence = sentence.Remove(start-explosionLeft, explosion).Insert(start - explosionLeft, boom);
                }
            }
        }
        Console.WriteLine(sentence);
    }
}
