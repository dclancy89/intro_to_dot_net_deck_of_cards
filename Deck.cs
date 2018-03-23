using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        public List<Card> cards = new List<Card>();
        string[] suits = {"Clubs", "Spades", "Heats", "Diamonds"};
       
       public Deck()
       {
           foreach(string suit in suits)
           {
               for(int i = 0; i < 13; i++)
               {
                   string s = suit;
                   int v = i+1;
                   string sv = "";
                   switch(v)
                   {
                        case 1:
                            sv = "Ace";
                            break;
                        case 11:
                            sv = "Jack";
                            break;
                        case 12:
                            sv = "Queen";
                            break;
                        case 13:
                            sv = "King";
                            break;
                   }
                   cards.Add(new Card(sv, s, v));
               }
           }
       } // end constructor

        public Card deal()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }

        public void reset() {
            foreach(string suit in suits)
           {
               for(int i = 0; i < 13; i++)
               {
                   string s = suit;
                   int v = i+1;
                   string sv = "";
                   switch(v)
                   {
                        case 1:
                            sv = "Ace";
                            break;
                        case 11:
                            sv = "Jack";
                            break;
                        case 12:
                            sv = "Queen";
                            break;
                        case 13:
                            sv = "King";
                            break;
                   }
                   cards.Add(new Card(sv, s, v));
               }
           }
        } // end reset

        public Deck shuffle()
        {
            Random rand = new Random();
            for(int idx = cards.Count - 1; idx > 0; idx--) {
                int randIdx = rand.Next(idx);
                Card temp = cards[randIdx];
                cards[randIdx] = cards[idx];
                cards[idx] = temp;
            }
            return this;
        }

    }
}