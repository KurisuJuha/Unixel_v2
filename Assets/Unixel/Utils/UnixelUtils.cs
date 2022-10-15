using UnityEngine;

namespace unixel.v2
{
    public static class Utils
    {
        /// <summary>
        /// 指定した位置、指定したサイズを指定した色で塗りつぶします。
        /// </summary>
        public static void Fill(Vector2Int pos, Vector2Int size, Color color) => Unixel.AddGraphicElements(new Fill(pos, size, color));
        /// <summary>
        /// 指定した位置、指定したサイズを白色で塗りつぶします。
        /// </summary>
        public static void Fill(Vector2Int pos, Vector2Int size) => Fill(pos, size, Color.white);

        /// <summary>
        /// 指定した色で塗りつぶします。
        /// </summary>
        public static void Clear(Color color) => Unixel.AddGraphicElements(new Clear(color));
        /// <summary>
        /// 黒色で塗りつぶします。
        /// </summary>
        public static void Clear() => Clear(Color.black);

        /// <summary>
        /// 指定した位置に指定したテクスチャを描画します
        /// </summary>
        public static void Sprite(Vector2Int pos, Texture2D texture) => Unixel.AddGraphicElements(new Sprite(pos, texture));

        /// <summary>
        /// 指定した位置に指定した色を描画します。
        /// </summary>
        public static void Point(Vector2Int pos, Color color) => Unixel.AddGraphicElements(new Point(pos, color));
        /// <summary>
        /// 指定した位置を白色にします。
        /// </summary>
        /// <param name="pos"></param>
        public static void Point(Vector2Int pos) => Point(pos, Color.white);
    }
}
