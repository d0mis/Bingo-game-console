﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bing_test
{
    //Class used to store a number cell on the game board
    internal class BingNumb
    {
        public int number;
        public bool marked;
        public BingNumb()
        { }
        public BingNumb(int number,bool marked)
        {
            this.number = number;
            this.marked = marked;
        }
    }
}
