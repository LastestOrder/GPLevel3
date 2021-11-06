using UnityEngine;
using UnityEngine.UI;

namespace FirstGame
{
    public sealed class DisplayBonuses
    {
        private Text _text;
        private int _point;

        public DisplayBonuses()
        {
            _text = Object.FindObjectOfType<Text>();
        }

        public void Display(int value)
        {
            _point += value;
            _text.text = $"Вы набрали: {_point}";
        }
    }
}