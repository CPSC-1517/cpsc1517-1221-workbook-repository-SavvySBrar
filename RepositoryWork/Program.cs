// See https://aka.ms/new-console-template for more information
namespace OOPReview1
{
    public class HockeyTeam
    {
        public enum HockeyConference { Eastern, Western }
        public enum HockeyDivision { Metropolitan, Atlantic, Central, Pacific }

        //define fields for data storage
        private HockeyConference _conference;
        private HockeyDivision _division;

        //define fully implemented properties for data fields
        public HockeyConference _conference
        {
            get { return _conference; }
        }

        public HockeyDivison Divison
        {
            get { return _division; }
            set { _division = value;}
        }
    }
}