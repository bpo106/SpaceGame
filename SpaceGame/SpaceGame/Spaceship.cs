using SpaceEnvironment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceGame
{
    public class Spaceship
    {
        protected int lvl;
        protected int hp;
        protected int d6;
        protected int posx;
        protected int posy;
        protected static readonly Random random = new Random();
        protected static SpaceDraw spaceDraw;

        public void DrawShip(string filename)
        {
            spaceDraw.AddImage(filename, posx * 50, posy * 50);
        }
    }
}
