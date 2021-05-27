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
        private static Random rnd = new Random();
        protected int maxNum;
        protected int genNum;

        public Game() { }
        public Game(int max)
        {
            MaxNum = max;
            genNum = rnd.Next(0, maxNum);
        }
        public int MaxNum
        {
            get { return maxNum; }
            private set
            {
                if (value <= 0)
                    throw new NotNullException("Az érték legyen nagyobb mint 0!");

                maxNum = value;
            }
        }
        
    }
}
