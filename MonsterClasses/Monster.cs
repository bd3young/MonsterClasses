using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
	public abstract class Monster
	{
		public enum MonsterAction
		{
			Attack,
			Defend,
			Retreat
		}

        public enum MonsterPerform
        {
            Frontflip,
            Backflip,
            Jump
        }

        private int _id;
		private string _name;
		private int _age;
        private double _height;
        private double _weight;

        public int Id
		{
			get { return _id; }
			set { _id = value; }
		}
		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Age
		{
			get { return _age; }
			set { _age = value; }
		}

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public Monster()
        {

        }

		public Monster(int id, string name)
		{
			_id = id;
			_name = name;
		}

		public virtual string Greeting()
		{
			return $"Hello, my name is {_name}.";
		}

        public virtual string Roar()
        {
            return $"{_name} Growls at you.";
        }

		public abstract bool IsHappy();
	}
}
