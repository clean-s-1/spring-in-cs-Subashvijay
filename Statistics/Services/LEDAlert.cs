using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics.Services
{
    public class LEDAlert : IAlerter
    {
        public bool ledGlows;

        public LEDAlert()
        {
            ledGlows = false;
        }
        public void Alert()
        {
            this.ledGlows = true;
        }
    }
}
