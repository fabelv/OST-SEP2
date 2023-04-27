namespace State
{
    using System;

    public class Partner
    {
        public Partner() {
            State = new NeutralState(this);
        }

        internal IPartnerState State { get; set; }

        public void Talk() => State.Talk();
        public void Kiss() => State.Kiss();
        public void Insult() => State.Insult();
    }
}