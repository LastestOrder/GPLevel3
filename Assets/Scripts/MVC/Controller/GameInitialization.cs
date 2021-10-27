using UnityEngine;

namespace FirstGame
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data)
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            //var spawnLocation = new LocationData();
            var playerInitialization = new PlayerInitialization(playerFactory, data.Player.ExtractPosition());
            var enemyFactory = new EnemyFactory(data.Enemy);
            var enemyInitialization = new EnemyInitialization(enemyFactory);
            var bonusesFactory = new BonusesFactory(data.Bonuses);
            var bonusesInitialization = new BonusesInitialization(bonusesFactory);
            //var bonusesPoints = new BonusesSpawnLocation(data.Bonuses);


            controllers.Add(inputInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(enemyInitialization);
            //controllers.Add(bonusesInitialization);
            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MoveController(inputInitialization.GetInput(), playerInitialization.GetPlayer(),
                data.Player));
            //controllers.Add(new BonusesSpawn())
            controllers.Add(new CameraController(playerInitialization.GetPlayer(), camera.transform));
            controllers.Add(new EndGameController(enemyInitialization.GetEnemies(),
                playerInitialization.GetPlayer().gameObject.GetInstanceID()));


        }
    }
}