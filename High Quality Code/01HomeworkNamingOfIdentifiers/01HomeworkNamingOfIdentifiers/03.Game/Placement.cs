namespace _03Game
{
    #region

    using System;

    #endregion

    public class Placement
    {
        private string playerName;

        private int points;

        public Placement(string name, int points)
        {
            this.PlayerName = name;
            this.Points = points;
        }

        public string PlayerName
        {
            get
            {
                return this.playerName;
            }

            set
            {
                if (string.IsNullOrEmpty(value.Trim()))
                {
                    throw new ArgumentNullException("playerName", "Player Name cannot be empty!");
                }

                this.playerName = value;
            }
        }

        public int Points
        {
            get
            {
                return this.points;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("points", "Points cannot be negative!");
                }

                this.points = value;
            }
        }
    }
}