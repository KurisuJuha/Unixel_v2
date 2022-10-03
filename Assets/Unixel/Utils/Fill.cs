using UnityEngine;

namespace unixel.v2
{
    public class Fill : GraphicElement
    {
        private Vector2Int pos;
        private Vector2Int size;
        private Color color;

        public Fill(Vector2Int pos, Vector2Int size, Color color)
        {
            this.pos = pos;
            this.size = size;
            this.color = color;
        }

        public override Color[] Draw(Color[] pixels)
        {
            for (int y = 0; y < size.y; y++)
            {
                for (int x = 0; x < size.x; x++)
                {
                    Vector2Int p = new Vector2Int(x, y) + pos;
                    if (InTexture(p)) pixels[p.y * Unixel.size.x + p.x] += color * color.a;
                }
            }

            return pixels;
        }
    }
}
