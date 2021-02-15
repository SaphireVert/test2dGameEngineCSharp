using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test2dGameEngine.GameEngine;
using System.Drawing;

namespace test2dGameEngine
{
    class DemoGame : GameEngine.GameEngine
    {
        Shape2D player;
        public DemoGame() : base(new Vector2(615, 512), "Engine Demo") { }
        public override void OnLoad()
        {
            Console.WriteLine("Onload !");
            BackgroundColor = Color.Black;
            player = new Shape2D(new Vector2(10,10), new Vector2(10, 10), "Test");
        }

        public override void OnDraw()
        {
            
        }

        int time = 0;
        public override void OnUpdate()
        {
            if (time > 400)
            {
                if (player != null)
                {
                    player.DestroySelf();
                    player = null;
                }
            }
            time++;
        }
    }
}
