using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larpmaster
{
    internal class CharacterSelections
    {
            public string Race { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
            public string Charisma { get; set; }
            public string Class { get; set; }
            public int YearsInCult { get; set; }
            public string Kingdom { get; set; }
            public string CharacterName { get; set; }
            public string RealName { get; set; }
            public List<string> Weapons { get; set; } = new List<string>();
            public string Tasks { get; set; }
            public string OtherInfo { get; set; }       
    }
}
