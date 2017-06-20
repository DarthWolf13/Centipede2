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
        GameObjectList snakeSegments, mushrooms;
        int snakeLenght = 10;
        int mushroomAmount = 20;

        public PlayingState()
        {
            player = new Player();
            bullet = new Bullet();
            snakeSegments = new GameObjectList();
            mushrooms = new GameObjectList();

            this.Add(new SpriteGameObject("spr_background"));
            this.Add(player);
            this.Add(bullet);
            this.Add(snakeSegments);
            this.Add(mushrooms);

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

            for (int i = 0; i < mushroomAmount; i++)
            {
                this.mushrooms.Add(new Mushroom());
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

        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            foreach(SnakeSegment snakeSegment in snakeSegments.Objects)
            {
                foreach(Mushroom mushroom in mushrooms.Objects)
                {
                    if (snakeSegment.CollidesWith(mushroom))
                    {
                        snakeSegment.Bounce();
                    }

                    if (bullet.CollidesWith(mushroom))
                    {
                        this.mushrooms.Remove(mushroom);
                        bullet.Reset();
                        break;
                    }                   
                }
            }


            foreach (SnakeSegment snakeSegment in snakeSegments.Objects)
            {
                if (bullet.CollidesWith(snakeSegment))
                {
                    this.snakeSegments.Remove(snakeSegment);
                    this.mushrooms.Add(new Mushroom(snakeSegment.Position));
                    bullet.Reset();
                    break;
                }
            }           
        }
    }
}
