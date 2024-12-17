using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Larpmaster
{
    internal class SelectionManager
    {
        private static SelectionManager _instance;
        public CharacterSelections Selections { get; private set; }

        private SelectionManager()
        {
            Selections = new CharacterSelections();
        }

        public static SelectionManager Instance => _instance ??= new SelectionManager();
    }
}
