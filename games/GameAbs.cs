using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace games
{
    public abstract class GameAbs
    {
        protected object gameObject;
        protected SavesClass.AbstractSave saver;
        public abstract string GetGameObject();
        public abstract string GetDataInSaver();
        public abstract void SaveData();
        public abstract bool WordIsRight(string ansver);
    }
}
