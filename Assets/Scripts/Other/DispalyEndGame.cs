using System;
using UnityEngine;
using UnityEngine.UI;

namespace FirstGame
{
    public sealed class DispalyEndGame
    {
        private Text _finishGameLabel;

        public DispalyEndGame(Text finishGameLabel)
        {
            _finishGameLabel = finishGameLabel;
            _finishGameLabel.text = string.Empty;
        }

        public void GameOver(object o, CaughtPlayerEventArgs args)
        {
            _finishGameLabel.text = $"Вы проиграли. Вас убил {((GameObject)o).name} {args.Color} цвета";
        }

    }
}
