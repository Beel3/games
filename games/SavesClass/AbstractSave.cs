using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace games.SavesClass
{
    [Serializable]
    abstract class AbstractSave
    {
        public uint Victory { get; set; }
        public uint Defeat { get; set; }
        static void SaveAsXmlFormat(object objGraph, string fileName)
        {
            // Сохранить объект в файле CarData.xml в формате XML.
            XmlSerializer xmlFormat = new XmlSerializer(typeof(AbstractSave));
            using (System.IO.Stream fStream = new System.IO.FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                xmlFormat.Serialize(fStream, objGraph);
            }
            System.Windows.Forms.MessageBox.Show("Сохранение в xml формат");
        }
        
        
    }
}
