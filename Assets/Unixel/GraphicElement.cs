using UnityEngine;

namespace unixel.v2
{
    public abstract class GraphicElement
    {
        public abstract Color[] Draw(Color[] pixels);

        protected bool InTexture(Vector2Int Pos)
        {
            return Pos.x >= 0 && Pos.y >= 0 && Pos.x < Unixel.size.x && Pos.y < Unixel.size.y;
        }

        protected Color AlphaBlend(Color backColor, Color overColor)
        {
            return backColor + (overColor - backColor) * overColor.a;

        }
    }
}