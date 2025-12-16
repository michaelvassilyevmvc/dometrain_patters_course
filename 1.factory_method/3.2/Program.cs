using _3._2.Enemies;
using _3._2.Levels;

Level level1 = LevelFactory.CreateLevel(levelNumber: 1);
level1.EncounterEnemy();

Level level2 = new HuntedHouseLevel();
level2.EncounterEnemy();