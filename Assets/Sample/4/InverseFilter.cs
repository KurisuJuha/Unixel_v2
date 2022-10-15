using unixel.v2;
using UnityEngine;

namespace JuhaKurisu
{
    public class InverseFilter : GraphicElement
    {
        public override Color[] Draw(Color[] pixels)
        {
            for (int i = 0; i < pixels.Length; i++)
            {
                pixels[i] = new Color(1 - pixels[i].r, 1 - pixels[i].g, 1 - pixels[i].b, pixels[i].a);
            }

            return pixels;
        }
    }
}
