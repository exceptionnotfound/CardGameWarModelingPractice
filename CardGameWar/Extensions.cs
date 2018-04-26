using CardGameWar.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar
{
    public static class Extensions
    {
        public static Card Pop(this List<Card> cards)
        {
            var card = cards.First();
            cards.RemoveAt(0);
            return card;
        }

        public static void Push(this List<Card> cards, Card card)
        {
            cards.Insert(0, card);
        }

        public static void Append(this List<Card> cards, List<Card> newCards)
        {
            foreach(var card in newCards)
            {
                cards.Insert(cards.Count, card);
            }
        }
    }
}
