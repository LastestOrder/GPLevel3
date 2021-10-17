using System;
using UnityEngine;
using UnityEngine.UI;

namespace FirstGame
{
    public sealed class GameController:MonoBehaviour, IDisposable
    {
        public Text _finishGameLabel;
        private ListInteractableObject _interactiveObject;
        private DispalyEndGame _displayEndGame;
        
        private void Awake()
        {
            _interactiveObject = new ListInteractableObject();
            _displayEndGame = new DispalyEndGame(_finishGameLabel);
            foreach (var o in _interactiveObject)
            {
                if (o is BadBonus badBonus)
                {
                    badBonus.CaughtPlayer += CaughtPlayer;
                    badBonus.CaughtPlayer += _displayEndGame.GameOver;
                    badBonus.CaughtPlayer += delegate (object sender, CaughtPlayerEventArgs args)
                    {
                        Debug.Log($"Вы проиграли. Вас убил {((GameObject)o).name} {args.Color} цвета");
                    };  
                }
            }
        }

        private void CaughtPlayer(object value, CaughtPlayerEventArgs args)
        {
            Time.timeScale = 0.0f;
        }
        private void Update()
        {
            for (int i = 0; i < _interactiveObject.Count; i++)
            {
                var interactiveObject = _interactiveObject[i];

                if( interactiveObject == null)
                {
                    continue;
                }
                if (interactiveObject is IFlay flay)
                {
                    flay.Flay();
                }
                if (interactiveObject is IFlicker flicker)
                {
                    flicker.Flicker();
                }
                if(interactiveObject is IRotation rotation)
                {
                    rotation.Rotation();
                }
            }
        }

        public void Dispose()
        {
            foreach (var o in _interactiveObject)
            {
                if (o is InteractiveObject interactiveObject)
                {
                    Destroy(interactiveObject.gameObject);
                    if (o is BadBonus badBonus)
                    {
                        badBonus.CaughtPlayer -= CaughtPlayer;
                        badBonus.CaughtPlayer -= _displayEndGame.GameOver;
                    }
                }
            }
        }
    }
}
