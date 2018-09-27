using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MonoIntro
{
    public class Sprite
    {
        public Texture2D Image { get; set; }
        public Vector2 Position { get; set; }
        public Color Tint { get; set; }

        public Sprite(Texture2D image, Vector2 position, Color tint)
        {
            this.Image = image;
            this.Position = position;
            this.Tint = tint;
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Image, Position, Tint);
        }
    }
}