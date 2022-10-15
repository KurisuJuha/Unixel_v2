using unixel.v2;
using UnityEngine;

namespace JuhaKurisu
{
    public class Sample : MonoBehaviour, GameBase
    {
        [SerializeField] Vector2 pos;
        [SerializeField] float speed;
        [SerializeField] Texture2D texture;

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
            Utils.Clear();

            Utils.Fill(new Vector2Int(10, 10), new Vector2Int(30, 30), Color.blue);
            Utils.Point(new Vector2Int(200, 200), Color.green);

            pos += Vector2.ClampMagnitude(new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")), 1) * speed;
            Utils.Sprite(Vector2Int.FloorToInt(pos), texture);
        }
    }
}
