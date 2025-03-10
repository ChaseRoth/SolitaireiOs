﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SolitaireiOS.Lang
{
    public class SolitaireType
    {
        public SolitaireType(string _name, string _description)
        {
            id = IdManager.GenerateId();
            Name = _name;
            Description = _description;
        }

        private long id;
        private string name;
        private string description;


        public long Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }        
    }
}