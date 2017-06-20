using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class Bullet : SpriteGameObject
    {
        Vector2 speed;
        Vector2 startPos;

        public Bullet() : base("spr_bullet")
        {
            startPos = new Vector2(-200, -200);

            this.Reset();
        }

        public override void Reset()
        {
            base.Reset();

            speed = Vector2.Zero;
            this.position = startPos;
        }

        public void Fire(Vector2 position)
        {
            this.position = position;
            speed = new Vector2(0, -200);
            this.velocity = speed;
        }
    }
}
