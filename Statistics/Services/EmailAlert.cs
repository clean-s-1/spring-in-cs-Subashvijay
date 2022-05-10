using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics.Services
{
    public class EmailAlert : IAlerter
    {
        public bool emailSent;

        public EmailAlert()
        {
            emailSent = false;
        }
        public void Alert()
        {
            emailSent = true;
        }
    }
}
