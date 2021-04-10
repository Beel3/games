using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace games.SavesClass
{
    abstract public class AbstractSave
    {
        protected string nameFile;
        public static readonly string path = "Saves";
        protected SimpleData data;
        public abstract void SaveAsBinaryFormat(object objGraph);
        public abstract void LoadFromBinaryFile();
    }
}
