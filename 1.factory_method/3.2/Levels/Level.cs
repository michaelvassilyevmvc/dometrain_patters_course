using _3._2.Enemies;

namespace _3._2.Levels;

public abstract class Level
{
    public abstract IEnemy CreateEnemy();

    public void EncounterEnemy()
    {
        IEnemy enemy = CreateEnemy();
        enemy.Attack();
        enemy.Scream();
    }
}