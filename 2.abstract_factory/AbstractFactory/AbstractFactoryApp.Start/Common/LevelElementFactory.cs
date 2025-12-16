namespace AbstractFactoryApp.Start.Common;

public abstract class LevelElementFactory
{
    public abstract IEnemy CreateEnemy();
    public abstract IWeapon  CreateWeapon();
    public abstract IPowerUp CreatePowerUp();   
    
    
    public void SetEnvironment()
    {
        var enemy = CreateEnemy();
        var weapon = CreateWeapon();
        var powerUp = CreatePowerUp();
    }
}