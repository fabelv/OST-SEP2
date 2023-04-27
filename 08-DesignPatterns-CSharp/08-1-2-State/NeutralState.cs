using System;

namespace State
{
    internal class NeutralState : IPartnerState
    {
        private Partner _partner;
        public NeutralState(Partner partner)
        {
            _partner = partner;
        }

        public void Insult()
        {
            Console.WriteLine("NeutralState -> Insult -> Are u fucking kidding me");
            _partner.State = new AngryState(_partner);
        }

        public void Kiss()
        {
            Console.WriteLine("NeutralState -> Kiss -> Thanks! :)");
            _partner.State = new HappyState(_partner);
        }

        public void Talk()
        {
            Console.WriteLine("NeutralState -> Talk -> Hi");
        }
    }
}