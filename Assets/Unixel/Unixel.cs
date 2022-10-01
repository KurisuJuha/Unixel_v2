using UnityEngine;

namespace Unixel
{
    public class Unixel : MonoBehaviour
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Init()
        {
            GameObject go = new GameObject("Unixel");
            go.AddComponent<Unixel>();
        }

        private void Update()
        {
            
        }
    }
}
