namespace TheSlum
{
    using Interfaces;

    public abstract class Bonus : Item, ITimeoutable
    {
        protected Bonus(string id, int healthEffect, int defenseEffect, int attackEffect,int countdown)
            : base(id, healthEffect, defenseEffect, attackEffect)
        {
            this.Countdown = countdown;
        }

        //Whats the purpose of Timeout? It's never used!
        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }
    }
}
