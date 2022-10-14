using unixel.v2;
using UnityEngine;

namespace JuhaKurisu
{
    public class Sample2 : MonoBehaviour , GameBase
    {
        public Texture2D tex;
        public Texture2D tex2;
        public Texture2D bigtex;
        public Vector2 pos;

        private Texture2D mainTex;

        private void Awake()
        {
            Unixel.Init(128, 128);
            Unixel.AddGameBase(this);
        }

        public void Setup()
        {
            mainTex = tex;
        }

        public void Draw()
        {
            Utils.Clear();

            Vector2Int vec = new Vector2Int();

            if (UnixelInput.right) vec.x++;
            if (UnixelInput.left) vec.x--;
            if (UnixelInput.up) vec.y++;
            if (UnixelInput.down) vec.y--;

            if (UnixelInput.click) mainTex = tex;
            if (UnixelInput.leftclick) mainTex = tex2;

            pos += (Vector2)vec / 1.3f;

            Utils.Sprite(Vector2Int.FloorToInt(pos), mainTex);
            Utils.Sprite(UnixelInput.cursorPosition - new Vector2Int(bigtex.width,bigtex.height) / 2, bigtex);
        }
    }
}
