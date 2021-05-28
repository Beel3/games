using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace games.SavesClass
{
    sealed public class SaverWord : AbstractSave
    {
        private string extension = ".saveWord";
        private WordData data;
        public SaverWord(string nameFile)
        {
            this.nameFile = nameFile;
            data = new WordData();
            data = (WordData)LoadFromBinaryFile();
        }
        
        public override void SaveAsBinaryFormat()
        {
            object objGraph = (object)data;
            BinaryFormatter binFormat = new BinaryFormatter();
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            //if(File.Exists(path + '/' + nameFile + extension) == true)
            //{
            //    WordData dataTemp = (WordData)LoadFromBinaryFile();
            //    data.SetNumAnswer(data.GetNumAnswer() + dataTemp.GetNumAnswer());
            //    data.SetNumСorrectAnswers(data.GetNumСorrectAnswers() + dataTemp.GetNumСorrectAnswers());
            //}
            using (Stream fStream = new FileStream(path +'/'+ nameFile + extension, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, data);
            }
            System.Windows.Forms.MessageBox.Show("Сериализация");

        }
        public override object LoadFromBinaryFile()
        {
            object dataObj = new object();
            BinaryFormatter binFormat = new BinaryFormatter();
            if (File.Exists(path + '/' + nameFile + extension) != true)
            {
                SaveAsBinaryFormat();
            }            
            using (Stream fStream = File.OpenRead(path + '/' + nameFile + extension))
            {
                dataObj = (WordData)binFormat.Deserialize(fStream);
                System.Windows.Forms.MessageBox.Show("Десерицализация");
            }
            return dataObj;
        }
        public void IncData(bool wordIsRight)
        {
            data.IncData(wordIsRight);
        }
        public List<string> GetWordData()
        {
            List<string> retVal = new List<string>();
            retVal.Add("Количество правильных ответов = " + Convert.ToString(data.GetNumСorrectAnswers()));
            retVal.Add("Количество ответов = " + Convert.ToString(data.GetNumAnswer()));
            return retVal;
        }
    }
}
