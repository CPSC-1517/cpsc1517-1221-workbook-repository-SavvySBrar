using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace OOPReview1
{
    public class NHLTeam
    {
        public enum NHLConference { Eastern, Western }

        public string _name;
        public string Name
        {
            get => _name;
            private set
            {
                if (string IsNullOrWhiteSpace(value))

	                {
                    throw new ArgumentException("Name must contain text.")

                    }
                _name = value.Trim();
            }
        }

        public string _city;
        public string City
        {
            get => _city;
            private set
            {
                if (string IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("City must contain text.")
                }
                _city = value.Trim();
            }

        }
        private int _gamesPlayed;
        public int GamesPlayed
        {
            get => _gamesPlayed;
            private set
            {
                if (string IsNullOrWhiteSpace(value))
                        {
                    throw new ArgumentException("Games played must contain text.")
                        }
                _gamesPlayed = value;
            }
        }
        private int _wins;
        public int Wins
        {
            get => _wins;
            private set
            {
                if (string IsNullOrWhiteSpace(value))
                        {
                    throw new ArgumentException("Wins must contain text.")
                        }
                _wins = value;
            }
        }
        private int _losses;
        public int Losses
        {
            get => _losses;
            private set
            {
                if (string IsNullOrWhiteSpace(value))
                        {
                    throw new ArgumentException("Losses must contain text.")
                        }
                _losses = value;
            }
        }

        public int _overtimeLosses;
        public int OvertimeLosses
        {

        }

        public int _points;
        public int Points
        {
            get => (Wins * 2) + OvertimeLosses;
        }

        public NHLTeam(NHLConference conference,
            NHLDivision division,
            string name,
            string city)
        {
            Conference = conference;
            Division = division;
            Name = name;
            this City = city;
            GamesPlayed = 0;
            Wins = 0;
            Losses = 0;
            OvertimeLosses = 0;
        }
        public override string ToString()
        {
            return $"{Conference}, {Division}, {Name}, {City}, {GamesPlayed}, {Wins}, {Losses}, {OvertimeLosses}"
        }
    }

}
