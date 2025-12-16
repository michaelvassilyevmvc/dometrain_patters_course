using AbstractFactoryApp.Start.Common;

namespace AbstractFactoryApp.Start.HauntedHouseLevel;

public class HauntedHouseLevelElementFactory: LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new Ghost();
    }

    public override IWeapon CreateWeapon()
    {
        return new Orb();
    }

    public override IPowerUp CreatePowerUp()
    {
        return new Staff();
    }
}