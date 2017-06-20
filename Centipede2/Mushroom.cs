using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class Mushroom : SpriteGameObject
    {
        Vector2 randomPos;

        public Mushroom() : base("spr_mushroom")
        {
            randomPos = new Vector2(GameEnvironment.Random.Next(0, 470), GameEnvironment.Random.Next(25, 450));
            this.position = randomPos;
        }

        public Mushroom(Vector2 startPosition) : base("spr_mushroom")
        {
            this.Position = startPosition;
        }
    }
}
