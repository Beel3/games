using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games
{
    public class GameWordsLogic
    {
        protected static Random rand = new Random();
        public List <string> WordExemps = new List<string> { "КРОШКА", "БУТЫЛКА", "ЯЗЫК","ССЫЛКА" };
        protected string Word;
        protected string MixedWord;
        protected SavesClass.SaverWord saver;

        public GameWordsLogic(string nameFile)
        {
            saver = new SavesClass.SaverWord(nameFile);
        }
        public GameWordsLogic()
        {
            saver = new SavesClass.SaverWord("stocName");
        }

        public string genWord()
        {
            Word = WordExemps[rand.Next(WordExemps.Count)];
            return Word;
        }
        public string GetWord()
        {
            if (Word == default(string))
                genWord();

            return Word;
        }
        public string GetMixedWord()
        {
            if (MixedWord == default(string))
                DoMixedWord();
            
            return MixedWord;
        }
        public string DoMixedWord()
        {            
            genWord();
            
            var arrWord = Word.ToArray();
            Array.Sort(arrWord);
            if(rand.Next(1)==1)
                arrWord.Reverse();

            string str = new string(arrWord);
            MixedWord = str;
            return MixedWord;
        }
        public bool WordIsRight(string resWord)
        {
            if (resWord == Word)
            {
                saver.IncData(true);
                return true;
            }
            else
            {
                saver.IncData(false);
                return false;
            }
        }
        public void SaveData()
        {
            saver.SaveAsBinaryFormat();
        }
        public string GetDataSaver()
        {
            string retVal = default;
            foreach (string str in saver.GetWordData())
            {
                retVal += (str + '\n');
            }            
            return retVal;
        }
    }
}
