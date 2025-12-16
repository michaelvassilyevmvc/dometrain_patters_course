using AbstractFactoryApp.Start.CavelLevel;
using AbstractFactoryApp.Start.Common;
using AbstractFactoryApp.Start.Factories;
using AbstractFactoryApp.Start.HauntedHouseLevel;

void SetEnvironment(LevelElementFactory levelFactory)
{
    var enemy = levelFactory.CreateEnemy();
    var weapon = levelFactory.CreateWeapon();
    var powerUp = levelFactory.CreatePowerUp();
}

SetEnvironment(new CavelLevelElementFactory());
SetEnvironment(new HauntedHouseLevelElementFactory());