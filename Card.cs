using System;

namespace Deck_of_Cards
{
    public class Card{
        string stringVal;
        string suit;
        int val;

        public Card(string sv, string s, int v)
        {
            stringVal = sv;
            suit = s;
            val = v;
        }
    }

}