using System;
using System.Diagnostics.Contracts;

namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            enemy.flying = true;
            enemy.incoporial= false;
            return enemy.flying || enemy.incoporial;//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            enemy.swimmer = false;
            enemy.subterranian = true;
            return enemy.subterranian || enemy.swimmer;//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
        }
    }
}