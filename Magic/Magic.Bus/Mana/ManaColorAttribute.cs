using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magic.Bus.Mana
{
    public class ManaColorAttribute : Attribute
    {
        public string ColorShortName { get; set; }

        public ManaColorAttribute(string colorShortName)
        {
            ColorShortName = colorShortName;
        }
    }
}
