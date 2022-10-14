using unixel.v2;
using UnityEngine;

namespace JuhaKurisu
{
    public class Sample : MonoBehaviour, GameBase
    {
        public Vector2 pos;
        public float speed;
        public Texture2D texture;
        private bool start;

        private void Awake()
        {
            Unixel.Init(256, 256);
            Unixel.AddGameBase(this);
        }

        public void Setup()
        {

        }

        public void Draw()
        {
            for (int i = 0; i < 6000; i++)
            {
                Utils.Point(new Vector2Int(Random.Range(0, 256), Random.Range(0, 256)), Color.black);
            }

            pos += Vector2.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), 1) * speed;
            Utils.Sprite(Vector2Int.FloorToInt(pos), texture);
        }
    }
}
