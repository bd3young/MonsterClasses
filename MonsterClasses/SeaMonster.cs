using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterClasses
{
	public class SeaMonster : Monster
	{
		private string _homesea;
		private bool _hasgills;
        private string _favoritefood;

        public string HomeSea
		{
			get { return _homesea; }
			set { _homesea = value; }
		}

		public bool HasGills
		{
			get { return _hasgills; }
			set { _hasgills = value; }
		}

        public string FavoriteFood
        {
            get { return _favoritefood; }
            set { _favoritefood = value; }
        }

		public override bool IsHappy()
		{
			//if (_hasgills)
			//{
			//	return true;
			//}
			//else
			//{
			//	return false;
			//}

			return _hasgills ? true : false;
		}
	}
}
