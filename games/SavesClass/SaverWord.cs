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

        public SaverWord(string nameFile)
        {
            this.nameFile = nameFile;
            data = new WordData();
        }
        
        public override void SaveAsBinaryFormat(object objGraph)
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            if (Directory.Exists(path) == false)
            {
                Directory.CreateDirectory(path);
            }
            using (Stream fStream = new FileStream(path + nameFile + extension,
            FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binFormat.Serialize(fStream, objGraph);
            }
            System.Windows.Forms.MessageBox.Show("Сериализация");

        }
        public override void LoadFromBinaryFile()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            if (Directory.Exists(path) == true)
            {
                using (Stream fStream = File.OpenRead(path + nameFile + extension))
                {
                    WordData carFromDisk = (WordData)binFormat.Deserialize(fStream);
                    System.Windows.Forms.MessageBox.Show("Десерицализация");
                }
            }
        }

    }
}
