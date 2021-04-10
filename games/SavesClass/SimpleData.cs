using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games.SavesClass
{
    [Serializable]
    public class SimpleData
    {
        private uint numСorrectAnswers;

        public uint GetNumСorrectAnswers()
        {
            return numСorrectAnswers;
        }

        protected void SetNumСorrectAnswers(uint value)
        {
            numСorrectAnswers = value;
        }

        private uint numAnswer;

        public uint GetNumAnswer()
        {
            return numAnswer;
        }

        protected void SetNumAnswer(uint value)
        {
            numAnswer = value;
        }
    }
}
