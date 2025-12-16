using _3._2.Enemies;

namespace _3._2.Levels;

public class CaveLevel : Level
{
    public override IEnemy? CreateEnemy()
    {
        return new Goblin();
    }
}