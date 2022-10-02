using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace unixel.v2
{
    [DefaultExecutionOrder(-1000)]
    public class Unixel : MonoBehaviour
    {
        public static Vector2Int size;
        
        private static Unixel Instance;

        private List<GraphicElement> graphicElements = new();
        private List<GameBase> gameBases = new();
        private bool started;
        private Mesh mesh;
        private Material material;
        private Texture2D texture;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else Destroy(gameObject);
        }

        private void Start()
        {
            Instance.texture = new Texture2D(size.x, size.y);
            Instance.texture.filterMode = FilterMode.Point;
            mesh = new Mesh();
            mesh.name = "mesh";
            material = new Material(Shader.Find("Sprites/Default"));
            material.mainTexture = Instance.texture;
            Instance.texture.SetPixel(10, 10, Color.black);
            Instance.texture.Apply();
            StartCoroutine(MainLoopCoroutine());
        }

        private void Update()
        {
            MeshGenerate();
            Graphics.DrawMesh(mesh, Vector3.zero, Quaternion.identity, material, 0);
        }

        private void MeshGenerate()
        {
            float height = size.y / (float)size.x;
            float width = 1;

            float m = width / height > Camera.main.aspect ? Camera.main.orthographicSize * Camera.main.aspect : Camera.main.orthographicSize / height;

            width *= m;
            height *= m;

            mesh.Clear();
            mesh.SetVertices(new Vector3[]
            {
                new Vector3(-width,-height),
                new Vector3(-width,height),
                new Vector3(width,height),
                new Vector3(width,-height),
            });
            mesh.SetTriangles(new int[]
            {
                0,1,2,
                0,2,3,
            }, 0);
            mesh.SetUVs(0, new List<Vector2>()
            {
                new Vector2(0,0),
                new Vector2(0,1),
                new Vector2(1,1),
                new Vector2(1,0),
            });
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

                Color[] pixels = texture.GetPixels();

                foreach (var graphicElement in graphicElements)
                {
                    pixels = graphicElement.Draw(pixels);
                }

                texture.SetPixels(pixels);

                texture.Apply();

                yield return new WaitForSecondsRealtime(1 / 60f);
            }
        }

        /// <summary>
        /// 初期化します。
        /// </summary>
        public static void Init(int width, int height)
        {
            GameObject go = new GameObject("Unixel");
            go.AddComponent<Unixel>();
            size = new Vector2Int(width, height);

            Instance.started = true;
        }

        /// <summary>
        /// GraphicElementを追加します。
        /// </summary>
        public static void AddGraphicElements(GraphicElement element)
        {
            Instance.graphicElements.Add(element);
        }

        /// <summary>
        /// GameBaseを追加します。
        /// </summary>
        public static void AddGameBase(GameBase gameBase)
        {
            if (!Instance.started)
            {
                Debug.LogError("Initしていません。");
                return;
            }

            Instance.gameBases.Add(gameBase);
            gameBase.Setup();
        }
    }
}
