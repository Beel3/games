using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games.GameEcuation
{
    public class GameEquationWithTimer : GameEquationLogic
    {
        protected int countCorrectAnsver;
        protected int countAnsver;
        public GameEquationWithTimer(int min, int max, bool levelMp) :base(min, max, levelMp)
        {
            countCorrectAnsver = 0;
            countAnsver = 0;
        }

        public override bool WordIsRight(string ansver)
        {
            if (ansver == ((Equation)gameObject).GetAnsver())
            {
                ((SavesClass.SaverEquation)saver).IncData(true);
                ++countCorrectAnsver;
                ++countAnsver;
                return true;
            }
            else
            {
                ((SavesClass.SaverEquation)saver).IncData(false);
                ++countAnsver;
                return false;
            }            
        }
        public string TimeIsOver()
        {
            return string.Format("Количество верных ответов = {0}\nОбщее количесвто ответов = {1}", countCorrectAnsver, countAnsver);
        }
    }
}
