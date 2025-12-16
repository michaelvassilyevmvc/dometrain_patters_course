using AbstractFactoryApp.Start.Common;
using AbstractFactoryApp.Start.Products;

namespace AbstractFactoryApp.Start.Factories;

public class ConcreteFactory: LevelElementFactory
{
    public override IEnemy CreateEnemy()
    {
        return new ConcreteEnemy();
    }

    public override IWeapon CreateWeapon()
    {
        return new ConcreteWeapon();
    }
    
    public override IPowerUp CreatePowerUp()
    {
        return new ConcretePowerUp();
    }
}