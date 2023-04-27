using System;

namespace State
{
    internal class SuperAngryState : IPartnerState
    {
        private Partner _partner;
        private int _kissCounter;
        public SuperAngryState(Partner partner, int kissCounter = 0)
        {
            _partner = partner;
            _kissCounter = kissCounter;
        }

        public void Insult()
        {
            Console.WriteLine("SuperAngryState -> Insult -> die");
        }

        public void Kiss()
        {
            if(_kissCounter == 5) {
                Console.WriteLine("SuperAngryState -> Kiss -> partners mood leveld up");
                _partner.State = new AngryState(_partner);
            }
            else
            {
                Console.WriteLine($"SuperAngryState -> Kiss -> hmm -> you {5 - _kissCounter} more kissed to level up");
                _partner.State = new SuperAngryState(_partner, _kissCounter + 1);
            }
        }

        public void Talk()
        {
            Console.WriteLine("SuperAngryState -> Talk -> die but less");
        }
    }
}