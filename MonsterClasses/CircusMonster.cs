using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
	public class CircusMonster : Monster, IPerform
	{
        private string _specialty;
        private bool _hastent;
        private int _numofperformances;

        public int NumOfPerformances
        {
            get { return _numofperformances; }
            set { _numofperformances = value; }
        }

        public bool HasTent
        {
            get { return _hastent; }
            set { _hastent = value; }
        }


        public string Specialty
        {
            get { return _specialty; }
            set { _specialty = value; }
        }

        public override bool IsHappy()
		{
            return _hastent ? true : false;
		}

        public override string Greeting()
        {
            return $"Hello, my name is {Name} and my specialty is {_specialty}.";
        }

        public override string Roar()
        {
            return $"{Name} hisses at you.";
        }

        public MonsterPerform MonsterPerformResponse()
        {
            Random randomNumber = new Random();
            int PerformResponseNumber = randomNumber.Next(0, 101);

            if (PerformResponseNumber >= 66)
            {
                return MonsterPerform.Frontflip;
            }
            else if (PerformResponseNumber >= 33)
            {
                return MonsterPerform.Backflip;
            }
            else
            {
                return MonsterPerform.Jump;
            }
        }
    }
}
