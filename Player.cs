using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Player
    {
        string name;
        public List<Card> hand = new List<Card>();

        public Player(string n)
        {
            name = n;
        }

        public void draw(Deck d)
        {
            Random rand = new Random();
            int cardIndex = rand.Next(d.cards.Count + 1);
            Card card = d.cards[cardIndex];
            d.cards.RemoveAt(cardIndex);
            this.hand.Add(card);

        }

        public Card discard(int idx)
        {
            if(idx >= hand.Count)
            {
                return null;
            }
            else 
            {
                Card card = hand[idx];
                hand.RemoveAt(idx);
                return card;
            }
        }
    }
}