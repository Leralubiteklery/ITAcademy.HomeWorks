using System;
using System.Collections.Generic;
using System.Text;

namespace HW._10___3
{
    class Ball
    {
        public string ballType { get; set; }

        public Ball()
        {
            ballType = "regular";
        }

        public Ball(string ballType)
        {
            this.ballType = ballType;
        }
    }
}
