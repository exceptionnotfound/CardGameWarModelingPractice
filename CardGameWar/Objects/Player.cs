using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGameWar.Objects
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Deck { get; set; }

        public Player() { }

        public Player(string name)
        {
            Name = name;
        }

        public List<Card> Deal(List<Card> cards)
        {
            List<Card> player1cards = new List<Card>();
            List<Card> player2cards = new List<Card>();

            for(int i = 0; i < cards.Count; i++)
            {
                if(i % 2 == 0)
                {
                    player2cards.Push(cards[i]);
                }
                else
                {
                    player1cards.Push(cards[i]);
                }
            }

            Deck = player2cards;
            return player1cards;
        }
    }
}
