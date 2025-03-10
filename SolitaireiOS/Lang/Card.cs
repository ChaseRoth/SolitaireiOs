﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolitaireiOS.Lang
{
    public class Card : SolitaireType
    {
        public Card(string _name, string _description, string _parentDeck) : base(_name, _description) { ParentDeck = _parentDeck; }

        private string parentDeck;
        private bool isFinished = false;    // False by default

        public bool IsFinished { get { return isFinished; } set { isFinished = value; } }
        public string ParentDeck { get { return parentDeck; } set { parentDeck = value; } }
    }
}