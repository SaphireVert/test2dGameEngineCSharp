using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2dGameEngine.GameEngine
{
    public class Vector2
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2()
        {
            this.X = Zero().X;
            this.Y = Zero().Y;
        }

        public Vector2(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Return X & Y as 0
        /// </summary>
        /// <returns></returns>
        public static Vector2 Zero()
        {
            return new Vector2(0, 0);
        }
    }
}
