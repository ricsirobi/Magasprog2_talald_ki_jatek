using KitalaloProgram.Dialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitalaloProgram.Classes
{
    public class Guessing : Game
    {
        private static Random rnd = new Random();
        public bool isGuessed = false;
        public bool isCorrect = false;
        NewMessage message;
        protected int tipsCount;

        
        

        public Guessing(int max)
        {
            this.maxNum = max;
            this.genNum = rnd.Next(0, maxNum);
        }

        public void Guess(int opt, int guessedNum, int generatedNum)
        {
            if (opt == 0)
            {
                if (generatedNum > guessedNum)
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés igaz, nagyobb, mint  " + guessedNum, "IGAZ!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = false;
                    isCorrect = true;
                }
                else if (generatedNum < guessedNum)
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés hamis, nem nagyobb, mint " + guessedNum, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = false;
                    isCorrect = false;
                }
                else
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés hamis, nem nagyobb és nem kisebb, mint " + guessedNum, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = false;
                    isCorrect = false;
                }
            }
            if (opt == 1)
            {
                if (generatedNum < guessedNum)
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés igaz, kisebb, mint " + guessedNum, "IGAZ!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = false;
                    isCorrect = true;
                }
                else if(generatedNum > guessedNum)
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés hamis, nem kisebb, mint " + guessedNum, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = false;
                    isCorrect = false;
                }
                else
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés hamis, nem kisebb és nem nagyobb, mint " + guessedNum, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = false;
                    isCorrect = false;
                }
            }
            if(opt == 2)
            {
                if (generatedNum == guessedNum)
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés igaz, egyenlo a gondolt szammal: " + guessedNum, "IGAZ!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    isGuessed = true;
                }
                else
                {
                    tipsCount++;
                    message = new NewMessage("A kérdés hamis, nem egyenlő ezzel: " + guessedNum, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);                    isGuessed = false;
                    isCorrect = false;
                }
            }
        }
        public int GetTipsCount()
        {
            return tipsCount;
        }


        public int GetGeneratedNum()
        {
            return genNum;
        }
    }
}
