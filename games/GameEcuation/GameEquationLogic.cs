using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games.GameEcuation
{
    public class GameEquationLogic : GameAbs
    {
        protected int min;
        protected int max;
        
        public GameEquationLogic(int min, int max, bool level)
        {
            this.min = min;
            this.max = max;
            gameObject = new Equation(min,max, level);
            saver = new SavesClass.SaverEquation("Equation");
        }
        public override string GetGameObject()
        {
            return ((Equation)gameObject).GetStrEcuation();
        }
        public override bool WordIsRight(string ansver)
        {
            if (ansver == ((Equation)gameObject).GetAnsver())
            {
                ((SavesClass.SaverEquation)saver).IncData(true);
                return true;
            }
            else
            {
                ((SavesClass.SaverEquation)saver).IncData(false);
                return false;
            }
        }
        public override string GetDataInSaver()
        {
            string retVal = default;
            foreach (string str in ((SavesClass.SaverEquation)saver).GetEquationData())
            {
                retVal += (str + '\n');
            }
            return retVal;
        }
        public override void SaveData()
        {
            saver.SaveAsBinaryFormat();
        }
        
    }
}
