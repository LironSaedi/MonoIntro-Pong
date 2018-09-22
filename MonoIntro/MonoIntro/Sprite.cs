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
        Texture2D image;
        Vector2 position;
        Color tint;


        public Sprite(Texture2D image, Vector2 position, Color tint)
        {
            this.image = image;
            this.position = position;
            this.tint = tint;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, position, tint);
        }
    }
}