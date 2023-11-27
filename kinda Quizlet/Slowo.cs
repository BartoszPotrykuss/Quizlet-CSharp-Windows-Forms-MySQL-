using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kinda_Quizlet
{
    internal class Slowo
    {
        public string polski, angielski;
        public int id;
        public bool nauczone;

        public Slowo(string polski, string angielski, int id, bool nauczone)
        {
            this.polski = polski;
            this.angielski = angielski;
            this.id = id;
            this.nauczone = nauczone;
        }
    }
}
