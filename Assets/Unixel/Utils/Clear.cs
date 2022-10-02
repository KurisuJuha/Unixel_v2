

using UnityEngine;

namespace unixel.v2
{
    public class Clear : GraphicElement
    {
        public Color color;

        public Clear(Color color)
        {
            this.color = color;
        }

        public override Color[] Draw(Color[] pixels)
        {
            for (int y = 0; y < Unixel.size.y; y++)
            {
                for (int x = 0; x < Unixel.size.x; x++)
                {
                    if (InTexture(new Vector2Int(x, y))) pixels[y * Unixel.size.x + x] = color;
                }
            }

            return pixels;
        }
    }
}
