﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlapJackCS3750
{
    class Player
    {
        private Boolean _slapped;
        public Boolean slapped
        {
            get { return slapped; }
            set {
                _slapped = slapped;
                }
        }

       
        public void slap()
        {
            // do a boolean and have a while loop on main program(game) that will check each run through until a slap occurs
            _slapped = true;
        }
    }
}
