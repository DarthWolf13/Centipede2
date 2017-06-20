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
        GameObjectList snakeSegments;
        int snakeLenght = 10;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();
            snakeSegments = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(player);
            this.Add(bullet);
            this.Add(snakeSegments);

            for(int i = 0; i < snakeLenght; i++)
            {
                if(i < snakeLenght - 1)
                {
                    this.snakeSegments.Add(new SnakeSegment(i * 32 + 1, 0, "spr_snakebody"));
                }
                if(i == snakeLenght - 1)
                {
                    this.snakeSegments.Add(new SnakeSegment(i * 32, 0, "spr_snakehead"));
                }
            }
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
