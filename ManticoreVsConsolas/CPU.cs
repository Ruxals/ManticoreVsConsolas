using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManticoreVsConsolas
{
    internal class CPU
    {
        private int _hp = 100;
        private int _range;

        public int HP { get { return _hp; } set { _hp = value; } }
        public int Range => _range;

        public void Damage(int damage)
        {
            HP -= damage;
        }

        private Random _random = new Random();

        public CPU()
        {
            _range = _random.Next(101);
        }
    }
}
