using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpaceEnvironment;

namespace SpaceGame
{
    public class SpaceElement : GameObject
    {
        static public void DrawSpace(SpaceDraw spaceDraw, int x, int y)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    spaceDraw.AddImage("./images/space.gif", i * 50, j * 50);
                }
            }
        }
    }
}
