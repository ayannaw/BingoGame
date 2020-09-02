using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Ayanna Woodlin
 * Frank Friedman
 * Project 1: Bingo
 * 1/24/2019
 * Player class
 * */
namespace ProjectI_Woodlin.Classes
{
    class Player
    {
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
