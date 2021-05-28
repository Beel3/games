using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games.GameEcuation
{
    public enum Operation
    {
        Add = '+',
        Subtract = '-', 
        Multiply = '*', 
        Divide = '/'    
    }
    public class Equation
    {
        protected int firsParam;
        protected int secondParam;
        protected Operation operation;
        protected int ansver;
        private static Random random;
        private int min;
        private int max;
        private bool level = false;
        public Equation()
        {
            random = new Random();
            min = 10;
            max = 100;
        }
        public Equation(int min, int max, bool level)
        {
            random = new Random();
            this.level = level;
            this.min = min;
            this.max = max;
        }
        public string GetStrEcuation()
        {
            CreateNewParam(min, max);
            string retValue = Convert.ToString(firsParam);
            retValue += Convert.ToChar(operation);
            retValue += Convert.ToString(secondParam);
            return retValue;
        }
        public string GetAnsver()
        {
            if (ansver == default)
                CreateNewParam(min, max);
            return Convert.ToString(ansver);
        }
        protected void CreateNewParam(int min, int max)
        {
            firsParam = random.Next(min, max);
            secondParam = random.Next(min, max);
            if(level)
                operation = ConvertIntToOperation(random.Next(1, 4));
            else
                operation = ConvertIntToOperation(random.Next(1, 2));

            switch (operation)
            {
                case Operation.Add:
                    {
                        ansver = firsParam + secondParam;
                        break;
                    }
                case Operation.Subtract:
                    {
                        ansver = firsParam - secondParam;
                        break;
                    }
                case Operation.Multiply:
                    {
                        ansver = firsParam * secondParam;
                        break;
                    }
                case Operation.Divide:
                    {
                        ansver = firsParam / secondParam;
                        break;
                    }
            }
        }
        protected Operation ConvertIntToOperation(int val)
        {
            switch (val)
            {
                case 1:
                    return Operation.Add;
                case 2:
                    return Operation.Divide;
                case 3:
                    return Operation.Multiply;
                case 4:
                    return Operation.Subtract;
            }
            return Operation.Add;
        }
    }
}
