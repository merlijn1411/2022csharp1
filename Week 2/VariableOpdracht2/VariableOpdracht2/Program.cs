using Microsoft.VisualBasic.FileIO;
using System;

namespace VariableOpdracht2
{
    internal class Program
    {
        //class variables & gebruik
        static void Main(string[] args)
        {

            //ga naar de file TwitchStream.cs in je solution explorer in visual studio
            TwitchStream twitchStream = new TwitchStream();



            twitchStream.twitchName = "Cyclops";
            twitchStream.lastreamName = "Smile you son of a ...";
            twitchStream.streamgame = new Game("SeaOfThieves") ;
            twitchStream.followers = 14;
            twitchStream.automod = true;

            Console.WriteLine(twitchStream.twitchName);
            Console.WriteLine(twitchStream.lastreamName);
            Console.WriteLine(twitchStream.streamgame);
            Console.WriteLine(twitchStream.followers);
            Console.WriteLine(twitchStream.automod);

        }
    }
}