using UnityEditor;

namespace FirstGame
{
    public class MenuItems
    {
        [MenuItem("FirstGame/♛Пункт меню №0")]
        private static void MenuOption()
        {
            EditorWindow.GetWindow(typeof(MyWindow), false, "FirsGame");
        }
    }
}