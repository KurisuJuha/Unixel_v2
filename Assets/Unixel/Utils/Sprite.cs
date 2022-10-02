using UnityEngine;

namespace unixel.v2
{
    public class Sprite : GraphicElement
    {
        private Vector2Int pos;
        private Texture2D texture;

        public Sprite(Vector2Int pos, Texture2D texture)
        {
            this.pos = pos;
            this.texture = texture;
        }

        public override Color[] Draw(Color[] pixels)
        {
            int i = 0;
            Color[] p = texture.GetPixels();

            for (int y = 0; y < texture.height; y++)
            {
                for (int x = 0; x < texture.width; x++)
                {
                    Vector2Int position = new Vector2Int(x + pos.x, y + pos.y);
                    if (InTexture(position)) pixels[position.y * Unixel.size.x + position.x] += p[i];
                    i++;
                }
            }

            return pixels;
        }
    }
}