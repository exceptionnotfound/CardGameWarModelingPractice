using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar.Objects
{
    public class Card
    {
        public string DisplayName { get; set; }
        public Suit Suit { get; set; }
        public int Value { get; set; }
    }
}
