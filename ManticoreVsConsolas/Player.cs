using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreVsConsolas
{
    internal class Player
    {
        private int _hp = 100;
        private int _range; 
       
        public int HP { get { return _hp; } set { _hp = value; } }
        public int Range {get { return _range; } set { _range = value; } }

        public void Damage(int damage) 
        {
            HP -= damage;
        }


    }
}
