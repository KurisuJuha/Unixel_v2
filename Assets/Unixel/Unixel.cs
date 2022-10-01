using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace unixel.v2
{
    [DefaultExecutionOrder(-1000)]
    public class Unixel : MonoBehaviour
    {
        private static Unixel Instance;

        private List<GraphicElement> graphicElements = new();
        private List<GameBase> gameBases = new();

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        private static void Init()
        {
            GameObject go = new GameObject("Unixel");
            go.AddComponent<Unixel>();
        }

        private void Start()
        {
            StartCoroutine(MainLoopCoroutine());
        }

        private void Update()
        {
            foreach (var graphicElement in graphicElements)
            {
                graphicElement.Draw();
            }
        }

        private IEnumerator MainLoopCoroutine()
        {
            while (true)
            {
                graphicElements.Clear();

                foreach (var gameBase in gameBases)
                {
                    gameBase.Draw();
                }

                yield return new WaitForSecondsRealtime(1 / 60f);
            }
        }

        public static void AddGraphicElements(GraphicElement element)
        {
            Instance.graphicElements.Add(element);
        }

        public static void AddGameBase(GameBase gameBase)
        {
            Instance.gameBases.Add(gameBase);
            gameBase.Init();
        }
    }
}
