using System;

namespace State
{
    internal class AngryState : IPartnerState
    {
        private Partner _partner;

        public AngryState(Partner partner)
        {
            _partner = partner;
        }

        public void Insult()
        {
            Console.WriteLine("AngryState -> Insult -> fuck off");
            _partner.State = new SuperAngryState(_partner);
        }

        public void Kiss()
        {
            Console.WriteLine("AngryState -> Kiss -> hmm");
            _partner.State = new NeutralState(_partner);
        }

        public void Talk()
        {
            Console.WriteLine("AngryState -> Talk -> i dont wanna talk");
        }
    }
}