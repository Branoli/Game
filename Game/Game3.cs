using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game3 : Game2
    {
        public Game3(int GetLenght)
        {
            this.ArrOfKnuckles = new int[GetLenght, GetLenght];
            ArrOfKnuckle();
            PrintOfKnuckles();
            HistoryYourMove();
        }
        public void PrintOfKnuckles()
        {
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {

                    if (this.ArrOfKnuckles[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t{0}", this.ArrOfKnuckles[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t{0}", this.ArrOfKnuckles[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public void HistoryYourMove()
        {
            List<int> list = new List<int>();
            do
            {
                list.Add(MovingTheKnuckles());
                PrintOfKnuckles();
            } while (CheckInBox() > 0);
            Console.WriteLine("Вы это сделали!!!\n\n\n История ходов");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write("0 -> {0} ", list[i]);
            }
        }
    }
}
