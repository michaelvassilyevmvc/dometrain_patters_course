using AbstractFactoryApp.Start.Common;

namespace AbstractFactoryApp.Start.CavelLevel;

public class CavelLevelElementFactory : LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Goblin();
    }

    public override IWeapon CreateWeapon()
    {
        return new Crystal();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Axe();
    }
}