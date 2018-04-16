using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class EnemySpaceship : Spaceship
    {
        public EnemySpaceship()
        {
            posx = random.Next(9);
            posy = random.Next(9);
        }
    }
}
