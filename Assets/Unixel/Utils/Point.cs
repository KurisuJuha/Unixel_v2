using UnityEngine;

namespace unixel.v2
{
    public class Point : GraphicElement
    {
        private Vector2Int pos;
        private Color color;

        public Point(Vector2Int pos, Color color)
        {
            this.pos = pos;
            this.color = color;
        }

        public override Color[] Draw(Color[] pixels)
        {
            if (InTexture(pos)) pixels[pos.y * Unixel.size.x + pos.x] = AlphaBlend(pixels[pos.y * Unixel.size.x + pos.x], color);
            return pixels;
        }
    }
}
