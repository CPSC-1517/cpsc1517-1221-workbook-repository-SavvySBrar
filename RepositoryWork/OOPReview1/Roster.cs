
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPReview1
{
    public class Roster
    { 
        private const int MinNum = 0;
        private const int MaxNum = 98;
        //define a fully implemented property for playernum
        private int _num;
        public int Num
        {
            get => _num;
            set
            {
            if (value > MaxNum || value < MinNum)
            {
                throw new ArgumentNullException($"Please enter a valid value between {MinNum} and {MaxNum}")

            }
            _num = value;
            }
        }

        private string _name;
        public string Name
            {
        get => _name;
        set {
                if (string.IsNullOrWhiteSpace(value))
                {
                throw new ArgumentNullException("")

                }
                 _name = value;

            }
        }

    
    }

    //define an auto-implemented property for position
    public Position Position { get; set; }

}

