using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class SnakeSegment : SpriteGameObject
    {
        Vector2 startPos;
        int speed = 200;

        public SnakeSegment(int x, int y, string assetname) : base(assetname) 
        {
            startPos = new Vector2(x, y);
            this.position = startPos;
            this.velocity = new Vector2(speed, 0);
        }

        public void Bounce()
        {
            this.position.Y += 32;
            this.velocity *= -1;
        }

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            if(this.position.X <= 0 || this.position.X + this.Width >= Centipede.Screen.X)
            {
                Bounce();
            }
        }
    }
}
