using KitalaloProgram.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitalaloProgram.Classes
{
    public class Game
    {
        protected int maxNum;
        private static Random rnd = new Random();
        protected int generatedNumber;

        public Game() { }
        public Game(int max)
        {
            MaxNum = max;
            generatedNumber = rnd.Next(0, maxNum);
        }
        public int MaxNum
        {
            get { return maxNum; }
            private set
            {
                if (value <= 0)
                    throw new NotNullException("Az érték nagyobb kell, hogy legyen, mint 0!");

                maxNum = value;
            }
        }
        
    }
}
