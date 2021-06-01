using games.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace games
{
    public class GameWordsLogic
    {
        protected static Random rand = new Random();        
        protected string Word;
        protected string MixedWord;
        protected SavesClass.SaverWord saver;
        protected const int countWordInXml = 9;
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
            Word = GetWordInXml();
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

        private string GetWordInXml()
        {
            XmlDocument xDoc = new XmlDocument();
            try
            {
                xDoc.LoadXml(Resources.XMLFile1);
            }
            catch
            {
                MessageBox.Show("aaa");
            }

            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            int numWord = rand.Next(countWordInXml);
            int i = 0;
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if ((xnode.Attributes.Count > 0)&&(i == numWord))
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem("name");
                    if (attr != null)
                        return attr.Value;
                }
                i++;
            }
            return "";
        }
    }
}
