namespace SlapJackCS3750
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Player
    {
        //Properties
        private Models.Card[] hand;

        private Boolean _slapped;
        public Boolean slapped
        {
            get { return slapped; }
            set {
                _slapped = slapped;
                }
        }

       //Methods
        public void slap()
        {
            // do a boolean and have a while loop on main program(game) that will check each run through until a slap occurs
            _slapped = true;
        }

        public void Flip()
        {

        }
         
    }
}
