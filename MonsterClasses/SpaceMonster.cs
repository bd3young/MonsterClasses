using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
	public class SpaceMonster : Monster, IBattle
	{
		private string _galaxy;
        private bool _ownsspaceship;
        private bool _needoxygen;

        public string Galaxy
		{
			get { return _galaxy; }
			set { _galaxy = value; }
		}

        public bool OwnsSpaceship
        {
            get { return _ownsspaceship; }
            set { _ownsspaceship = value; }
        }

        public bool NeedOxygen
        {
            get { return _needoxygen; }
            set { _needoxygen = value; }
        }

		public override string Greeting()
		{
			return $"Hello, my name is {Name} and i am from the {_galaxy} galaxy.";
		}

		public override bool IsHappy()
		{
			return true;
		}

        public override string Roar()
        {
            return $"{Name} Roars at you.";
        }

        public MonsterAction MonsterBattleResponse()
		{
			Random randomNumber = new Random();
			int BattleResponseNumber = randomNumber.Next(0, 101);

			if (BattleResponseNumber >= 66)
			{
				return MonsterAction.Attack;
			}
			else if (BattleResponseNumber >= 33)
			{
				return MonsterAction.Defend;
			}
			else
			{
				return MonsterAction.Retreat;
			}

		}
	}
}
