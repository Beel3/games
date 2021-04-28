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
        public SimpleData()
        {
            numСorrectAnswers = 0;
            numAnswer = 0;
        }
        private uint numСorrectAnswers;
        private uint numAnswer;

        public uint GetNumСorrectAnswers()
        {
            return numСorrectAnswers;
        }
        public void SetNumСorrectAnswers(uint value)
        {
            numСorrectAnswers = value;
        }
        public uint GetNumAnswer()
        {
            return numAnswer;
        }
        public void SetNumAnswer(uint value)
        {
            numAnswer = value;
        }
        public void IncData(bool isRight)
        {
            if (isRight)
                ++numСorrectAnswers;

            ++numAnswer;
        }
    }
}
