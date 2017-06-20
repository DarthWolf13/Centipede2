using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class Player : SpriteGameObject
    {
        Vector2 startPos;
        int speed = 200;

        public Player() : base("spr_player")
        {
            startPos = new Vector2(235, 500);
            this.position = startPos;
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.IsKeyDown(Keys.Left) && this.position.X > 0)
            {
                this.velocity = new Vector2(-speed, 0);
            }
            else if (inputHelper.IsKeyDown(Keys.Right) && this.position.X + this.Width < Centipede.Screen.X)
            {
                this.velocity = new Vector2(speed, 0);
            }
            else
            {
                this.velocity = Vector2.Zero;
            }
        }
    }
}
