using UnityEngine;

namespace unixel.v2
{
    public static class Utils
    {
        /// <summary>
        /// �w�肵���ʒu�A�w�肵���T�C�Y���w�肵���F�œh��Ԃ��܂��B
        /// </summary>
        public static void Fill(Vector2Int pos, Vector2Int size, Color color) => Unixel.AddGraphicElements(new Fill(pos, size, color));
        /// <summary>
        /// �w�肵���ʒu�A�w�肵���T�C�Y�𔒐F�œh��Ԃ��܂��B
        /// </summary>
        public static void Fill(Vector2Int pos, Vector2Int size) => Fill(pos, size, Color.white);

        /// <summary>
        /// �w�肵���F�œh��Ԃ��܂��B
        /// </summary>
        public static void Clear(Color color) => Unixel.AddGraphicElements(new Clear(color));
        /// <summary>
        /// �w�肵���F�œh��Ԃ��܂��B
        /// </summary>
        public static void Clear() => Clear(Color.black);

        /// <summary>
        /// �w�肵���ʒu�Ɏw�肵���e�N�X�`����`�悵�܂�
        /// </summary>
        public static void Sprite(Vector2Int pos, Texture2D texture) => Unixel.AddGraphicElements(new Sprite(pos, texture));

        /// <summary>
        /// �w�肵���ʒu�Ɏw�肵���F��`�悵�܂��B
        /// </summary>
        public static void Point(Vector2Int pos, Color color) => Unixel.AddGraphicElements(new Point(pos, color));
        /// <summary>
        /// �w�肵���ʒu�𔒐F�ɂ��܂��B
        /// </summary>
        /// <param name="pos"></param>
        public static void Point(Vector2Int pos) => Point(pos, Color.white);
    }
}
