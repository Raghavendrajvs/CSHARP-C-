using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sep_8_2018
{
    static class CricketProperty
    {
        public static int NoOfPlayers = 2;
        public static int MaxBalls = 300;
        //public static int NoOfTeams;

    }
    class League
    {
        public string Leaguename;
    }
    class Player
    {

        public string Name;
        public int Jerseynumber;
        public float Strikerate;
    }
    class Playerscore
    {
        public Player Player;
        public float RunScored;
        // public int[] PlayerScore = new int[CricketProperty.NoOfPlayers];
        public float BallsPlayed;
        
    }
    class Team
    {
        public string Name;
        Player Player;
    }
    class Teamscore : Team
    {
        Playerscore PlayerScore;
        public bool IsWinner = true;
    }

    class Match
    {
        Teamscore ManofMatch;
        Teamscore HighestScorer;
        Player Team1;
        Player Team2;
    }
    class program4
    {
        public static void Main(string[] args)
        {
            Match m = new Match();
            Team[] t = new Team[2];
            Teamscore ts = new Teamscore();
            Player p = new Player();
            Player[] players = new Player[CricketProperty.NoOfPlayers];
            Playerscore ps = new Playerscore();
            Playerscore[] playerscores = new Playerscore[11];

            Console.WriteLine("-----Welcome to Cricket League----------");
            Console.WriteLine("enter the teams details");

            for (int teamcount = 0; teamcount < t.Length; teamcount++)
            {
                t[teamcount] = new Team();
                Console.WriteLine("enter the team " + (teamcount + 1) + " name:");
                t[teamcount].Name = Console.ReadLine();
            
                for (int playercount = 0; playercount < players.Length; playercount++)
                {
                    players[playercount] = new Player();
                    Console.WriteLine("enter the player" + (playercount + 1) + " of team" + t[teamcount].Name);
                    players[playercount].Name = Console.ReadLine();
                    Console.WriteLine("enter the jersey num:" + players[playercount].Name);
                    players[playercount].Jerseynumber = int.Parse(Console.ReadLine());
                }

                for (int playercount = 0; playercount < players.Length; playercount++)
                {

                        Console.WriteLine("the players of team " + t[teamcount].Name +"\tare");
                    Console.WriteLine("\t\t"+ players[playercount].Name + "\t\t" + t[teamcount].Name);
                }

            }
            for (int teamcount = 0; teamcount < 2; teamcount++)
            {
                for (int playercount = 0; playercount < playerscores.Length; playercount++)
                {
                    
                    playerscores[playercount] = new Playerscore();
                    Console.WriteLine("enter the score of" + t[teamcount].Name + "of" + players[playercount].Name);
                    playerscores[playercount].RunScored = int.Parse(Console.ReadLine());
                    Console.WriteLine("number of  balls :" + playerscores[playercount].BallsPlayed);

                    playerscores[playercount].BallsPlayed = int.Parse(Console.ReadLine());


                    //if (CricketProperty.MaxBalls > playerscores[300].BallsPlayed)
                    //{
                    //    Console.WriteLine("the strike rate is" + players[CricketProperty.NoOfPlayers].Strikerate);
                    //    players[CricketProperty.NoOfPlayers].Strikerate = ((playerscores[300].RunScored / playerscores[300].BallsPlayed) * 100);

                    //}
                    //else
                    //{
                    //    Console.WriteLine("enter a valid number of balls");
                    //}
                    Console.WriteLine("the strike rate of" + players[playercount].Name);
                    players[CricketProperty.NoOfPlayers].Strikerate = ((playerscores[playercount].RunScored / playerscores[playercount].BallsPlayed) * 100);
                    players[CricketProperty.NoOfPlayers].Strikerate = float.Parse(Console.ReadLine());
                    float total = 0;
                    Console.WriteLine("the total score of team"+t[teamcount].Name+"is");
                    total = total + playerscores[playercount].RunScored;
                    total = float.Parse(Console.ReadLine());
                    


                 }
            }
            
        }
}   }
