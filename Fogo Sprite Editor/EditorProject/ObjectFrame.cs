using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fogo_Sprite_Editor.EditorProject
{
    public class ObjectFrame 
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
    }
}
