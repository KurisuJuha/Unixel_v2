using UnityEngine;

namespace unixel.v2
{
    public class UnixelInput
    {
        public static bool right { get; private set; }
        public static bool right_Down { get; private set; }
        public static bool right_Up { get; private set; }

        public static bool left { get; private set; }
        public static bool left_Down { get; private set; }
        public static bool left_Up { get; private set; }

        public static bool up { get; private set; }
        public static bool up_Down { get; private set; }
        public static bool up_Up { get; private set; }

        public static bool down { get; private set; }
        public static bool down_Down { get; private set; }
        public static bool down_Up { get; private set; }

        public static bool click { get; private set; }
        public static bool click_Down { get; private set; }
        public static bool click_Up { get; private set; }

        public static bool leftclick { get; private set; }
        public static bool leftclick_Down { get; private set; }
        public static bool leftclick_Up { get; private set; }

        public static Vector2Int cursorPosition { get; private set; }

        public void Set()
        {
            right = Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow);
            right_Down = Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow);
            right_Up = Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow);

            left = Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow);
            left_Down = Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow);
            left_Up = Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow);

            up = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow);
            up_Down = Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
            up_Up = Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow);

            down = Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow);
            down_Down = Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow);
            down_Up = Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow);

            click = Input.GetMouseButton(1);
            click_Down = Input.GetMouseButtonDown(1);
            click_Up = Input.GetMouseButtonUp(1);

            leftclick = Input.GetMouseButton(0);
            leftclick_Down = Input.GetMouseButtonDown(0);
            leftclick_Up = Input.GetMouseButtonUp(0);

            Vector2 pos = Input.mousePosition;
            pos = new Vector2(pos.x / Screen.width, pos.y / Screen.height);
            pos = new Vector2(Unixel.size.x * pos.x, Unixel.size.y * pos.y);
            cursorPosition = Vector2Int.FloorToInt(pos);
        }
    }
}
