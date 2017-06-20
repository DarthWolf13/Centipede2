using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class PlayingState : GameObjectList
    {
        Player player;
        Bullet bullet;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(player);
            this.Add(bullet);
        }

        public override void HandleInput(InputHelper inputHelper)
        {
            base.HandleInput(inputHelper);

            if (inputHelper.KeyPressed(Keys.Space))
            {
                bullet.Fire(new Vector2(player.Position.X + player.Width/2 - bullet.Width/2, player.Position.Y + 20));
            }
        }
    }
}
