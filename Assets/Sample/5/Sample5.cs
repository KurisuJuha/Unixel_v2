using unixel.v2;
using UnityEngine;

namespace JuhaKurisu
{
    public class Sample5 : MonoBehaviour, GameBase
    {
        [SerializeField] Texture2D[] textures;
        [SerializeField] int[] tiles;
        [SerializeField] Color backGroundColor;
        [SerializeField] Color boardColor;
        [SerializeField] Vector2Int DisplaySize;

        private void Awake()
        {
            Unixel.Init(DisplaySize.x, DisplaySize.y);
            Unixel.AddGameBase(this);
        }

        public void Setup()
        {
            tiles = new int[16];
        }

        public void Draw()
        {
            Utils.Clear(backGroundColor);
            DrawTiles(DisplaySize / 2 - new Vector2Int(35, 35));
        }

        private void DrawTile(int t, Vector2Int pos)
        {
            Utils.Sprite(pos, textures[t]);
        }

        private void DrawTiles(Vector2Int pos)
        {
            Utils.Fill(pos - new Vector2Int(2, 2), new Vector2Int(74, 74), boardColor);

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    DrawTile(tiles[y * 4 + x], new Vector2Int(x, y) * 18 + pos);
                }
            }
        }
    }
}
