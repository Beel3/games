using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games.SavesClass
{
    [Serializable]//Да, почему-то атрибут не наследуется
    sealed public class WordData:SimpleData
    {
        public WordData() : base()
        {
        }
    }
}
