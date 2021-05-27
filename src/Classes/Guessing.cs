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
        public bool boolGuessed = false;
        public bool boolCorrect = false;
        NewMessage message;
        protected int tips;

        
        public int GetTipsNum()
        {
            return tips;
        }


        public int GetGeneratedNum()
        {
            return generatedNumber;
        }

        public Guessing(int max)
        {
            this.maxNum = max;
            this.generatedNumber = rnd.Next(0, maxNum);
        }

        public void Guess(int which, int guessed, int generated)
        {
            if (which == 0)
            {
                if (generated > guessed)
                {
                    message = new NewMessage("A kérdés igaz, nagyobb, mint  " + guessed, "IGAZ!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = true;
                }
                else if (generated < guessed)
                {
                    message = new NewMessage("A kérdés hamis, nem nagyobb, mint " + guessed, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = false;
                }
                else
                {
                    message = new NewMessage("A kérdés hamis, nem nagyobb és nem kisebb, mint " + guessed, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = false;
                }
            }
            if (which == 1)
            {
                if (generated < guessed)
                {
                    message = new NewMessage("A kérdés igaz, kisebb, mint " + guessed, "IGAZ!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = true;
                }
                else if(generated > guessed)
                {
                    message = new NewMessage("A kérdés hamis, nem kisebb, mint " + guessed, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = false;
                }
                else
                {
                    message = new NewMessage("A kérdés hamis, nem kisebb és nem nagyobb, mint " + guessed, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = false;
                }
            }
            if(which == 2)
            {
                if (generated == guessed)
                {
                    message = new NewMessage("A kérdés igaz, egyenlo a gondolt szammal: " + guessed, "IGAZ!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    boolGuessed = true;
                    tips++;
                }
                else
                {
                    message = new NewMessage("A kérdés hamis, nem egyenlő ezzel: " + guessed, "HAMIS!", MessageBoxButton.OK, MessageBoxIcons.Information);
                    tips++;
                    boolGuessed = false;
                    boolCorrect = false;
                }
            }
        }
    }
}
