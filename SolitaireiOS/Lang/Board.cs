﻿using System;
using System.Collections.Generic;

namespace SolitaireiOS.Lang
{
    public class Board : SolitaireType
    {
        public Board(string _name, string _description) : base (_name, _description) { }        

        private List<Deck> decks = new List<Deck>();
        private List<Card> cards = new List<Card>();
        private List<Contributor> contributors = new List<Contributor>();

        public List<Contributor> Contributors
        {
            get { return contributors; }
            set { contributors = value; }
        }
        public List<Card> Cards
        {
            get { return cards; }
            set { cards = value; }
        }
        public List<Deck> Decks
        {
            get { return decks; }
            set { decks = value; }
        }
    }    
}