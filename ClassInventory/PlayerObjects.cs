using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInventory
{
  
    internal class PlayerObjects
    {
        public string name;
        public string team;
        public string position;
        public int age;

        public PlayerObjects (string _name, string _team, string _position, int _age)
        {
            name = _name;
            team = _team;
            position = _position;
            age = _age;
        }
    }
    
}
