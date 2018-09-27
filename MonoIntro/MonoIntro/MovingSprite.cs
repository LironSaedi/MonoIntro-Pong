using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoIntro
{
    public class MovingSprite : Sprite
    {
        Vector2 Speed;

        public MovingSprite(Texture2D image, Vector2 position, Color tint, Vector2 speed)
            : base(image, position, tint)
        {
            this.Speed = speed;
        }

        public void Update(Rectangle Screen)
        {
            Position += Speed;
            if (Position.X + Image.Width > Screen.Width)
            {
                Speed.X = -Math.Abs(Speed.X);
            }
        }
    }
}
