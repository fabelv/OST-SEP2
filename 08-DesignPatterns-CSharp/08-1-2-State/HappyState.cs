using System;

namespace State
{
    internal class HappyState : IPartnerState
    {
        private Partner _partner;
        public HappyState(Partner partner) {
            _partner = partner;
        }

        public void Insult()
        {
            Console.WriteLine("HappyState -> Insult -> wtf?");
            _partner.State = new AngryState(_partner);
        }

        public void Kiss()
        {
            Console.WriteLine("HappyState -> Kiss -> aww");
        }

        public void Talk()
        {
            Console.WriteLine("HappyState -> Talk -> Talks *but in happy idk man*");
        }
    }
}