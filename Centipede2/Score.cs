using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Centipede2
{
    class Score : TextGameObject
    {
        private int score;

        public Score(string assetname = "GameFont", int layer = 0, string id = "") : base(assetname, layer, id)
        {
            this.Text = "Score: 0";
            this.Position = new Vector2(0, 0);
        }

        public int ScoreValue
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
                this.Text = "Score: " + value;
            }
        }
    }
}
