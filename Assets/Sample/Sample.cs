using unixel.v2;

namespace JuhaKurisu
{
    public class Sample : UnityEngine.MonoBehaviour, GameBase
    {
        public void Awake()
        {
            Unixel.AddGameBase(this);
        }

        public void Init()
        {
            UnityEngine.Debug.Log("Init!!!!!!");
        }

        public void Draw()
        {
            UnityEngine.Debug.Log("Draw!!!!!!");
        }
    }
}