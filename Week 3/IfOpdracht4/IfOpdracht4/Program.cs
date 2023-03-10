using System;

namespace IfOpdracht4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Enemy walker = new Enemy();
            Enemy flyer = new Enemy() { flying = true };
            Enemy ghost = new Enemy() { incoporial = true };
            Enemy swimmer = new Enemy() { swimmer = true };
            Enemy subterranian = new Enemy() { subterranian = true };
            //we gaan de OR opertator (||) gebruiken

            EnemyCollider enemyCollider = new EnemyCollider();
            if (enemyCollider.CanPassWall(flyer))
            {
                Console.WriteLine("flew over the wall");
            }
             if (enemyCollider.CanPassWall(ghost))
            {
                Console.WriteLine("passed right through the wall");
            }
             if (swimmer == ghost || ghost == subterranian)
            {
                Console.WriteLine("swam through the wall?"); //deze zie je niet
            }
             if (enemyCollider.CanPassWall(subterranian))
            {
                Console.WriteLine("Went underneath the wall");
            }
             if (walker == swimmer || swimmer == subterranian)
            {
                Console.WriteLine("walked through the wall what???");//deze zie je niet
            }

            if (enemyCollider.CanPassWater(flyer))
            {
                Console.WriteLine("flew over the water");
            }
             if (enemyCollider.CanPassWater(ghost))
            {
                Console.WriteLine("flew over the water");
            }
             if (enemyCollider.CanPassWater(swimmer))
            {
                Console.WriteLine("swam through the water");
            }
             if (enemyCollider.CanPassWater(subterranian))
            {
                Console.WriteLine("Went underneath the water");
            }
             if (walker == swimmer || walker == swimmer)
            {
                Console.WriteLine("walked on water what???");//deze zie je niet
            }
        }
    }
}