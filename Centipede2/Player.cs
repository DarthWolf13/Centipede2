using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class Player : SpriteGameObject
    {
        Vector2 startPos;

        public Player() : base("spr_player")
        {
            startPos = new Vector2(235, 500);
            this.position = startPos;
        }
    }
}
