using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards_stack
{
    class Card
    {
        public string symbol;
        public int number;

        public Card(int aNumber, string aSymbol)
        {
            symbol = aSymbol;
            number = aNumber;
        }
    }
}
