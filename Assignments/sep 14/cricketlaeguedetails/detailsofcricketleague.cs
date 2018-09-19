using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cricketlaeguedetails
{
    public static class StaticCount
    {
        public static int NoOfPlayers = 11;
        public static readonly int MaxBalls = 120;
    }
   public class CricketLeague
    {
        private string Name { get; set; }
        //public static int totalBalls = 120;

        public CricketLeague(string LeagueName)
        {
            Console.Write("Enter League Name :");
            this.Name = Console.ReadLine();
            Console.WriteLine("Welcome to\t" + this.Name + "\tLeague");
        }

    }


    public class Player
    {
        internal string PlayerName { get; set; }
        internal float StrikeRate { get; set; }
        //public PlayerScore PlayerScorePerMatch { get; set; }
    }

    public class PlayerScore //: Player
    {
        protected internal float Score { get; set; }
        protected internal float Balls { get; set; }

       protected internal Player PlayerDetail { get; set; }
    }
   public class Team
    {
         internal string Name { get; set; }
         internal Player[] Players = new Player[StaticCount.NoOfPlayers]; //{ get; set; }

        public void AcceptTeamDetails()
        {
            Console.WriteLine("Enter Team Name :");

            Name = Console.ReadLine();
            //Match1.Team1Score.PlayerScorer = new PlayerScore();
            for (int PlayerCount = 0; PlayerCount < Players.Length; PlayerCount++)
            {
                Players[PlayerCount] = new Player();
                //Match1.Team1Score.PlayerScorer[PlayerCount] = new PlayerScore();
                Console.Write("Enter Player " + (PlayerCount + 1) + " Name :");
                Players[PlayerCount].PlayerName = Console.ReadLine();
            }
        }
    }

   public class TeamScore : Team
    {
         internal PlayerScore[] PlayerScorer = new PlayerScore[StaticCount.NoOfPlayers]; //{ get; set; }
         internal bool IsWinner { get; set; }
         internal float TotalScore { get; set; }
         internal PlayerScore HighetScorer { get; set; }

        public void GetTeamScoreDetails(Team team)
        {
            int RemainingBalls = StaticCount.MaxBalls;
            HighetScorer = new PlayerScore();
            Name = team.Name;
            for (int PlayerCount = 0; PlayerCount < PlayerScorer.Length; PlayerCount++)
            {
                PlayerScorer[PlayerCount] = new PlayerScore();
                if (RemainingBalls > 0)
                {
                    PlayerScorer[PlayerCount].PlayerDetail = team.Players[PlayerCount];
                    Console.Write("Enter " + PlayerScorer[PlayerCount].PlayerDetail.PlayerName + " Score :");

                    PlayerScorer[PlayerCount].Score = Int32.Parse(Console.ReadLine());

                    Console.Write("Enter Number of Balls Played by " + PlayerScorer[PlayerCount].PlayerDetail.PlayerName + " :");
                    int PlayedBalls = Int32.Parse(Console.ReadLine());
                    while (PlayedBalls > RemainingBalls)
                    {
                        Console.Write("Remaining Balls :" + RemainingBalls);
                        Console.WriteLine("Enter Valid number of balls played");
                        PlayedBalls = Int32.Parse(Console.ReadLine());
                    }

                    team.Players[PlayerCount].StrikeRate = (PlayerScorer[PlayerCount].Score / PlayedBalls) * 100;

                    RemainingBalls = RemainingBalls - PlayedBalls;
                    PlayerScorer[PlayerCount].Balls = PlayedBalls;
                }

                else
                {
                    PlayerScorer[PlayerCount].Score = 0;
                    PlayerScorer[PlayerCount].Balls = 0;
                }

                if (PlayerCount == 0)
                {
                    HighetScorer = PlayerScorer[PlayerCount];
                }
                else
                {
                    if (HighetScorer.Score < PlayerScorer[PlayerCount].Score)
                    {
                        HighetScorer = PlayerScorer[PlayerCount];
                    }
                }

                TotalScore += PlayerScorer[PlayerCount].Score;
            }
            Console.WriteLine("Total Score by team " + Name + " :" + TotalScore);
        }

    }


    public class Match
    {
        public PlayerScore ManOfTheMatch { get; set; }
        public PlayerScore HighestScorer { get; set; }
        public TeamScore Team1Score { get; set; }
        public TeamScore Team2Score { get; set; }

        public void DisplayHighestScorerInMatch()
        {
            HighestScorer = new PlayerScore();
            HighestScorer = Team1Score.PlayerScorer[0];

            for (int Team1Players = 0; Team1Players < Team1Score.PlayerScorer.Length; Team1Players++)
            {
                if (HighestScorer.Score < Team1Score.PlayerScorer[Team1Players].Score)
                {
                    HighestScorer = Team1Score.PlayerScorer[Team1Players];
                }
            }

            for (int Team2Players = 0; Team2Players < Team2Score.PlayerScorer.Length; Team2Players++)
            {
                if (HighestScorer.Score < Team2Score.PlayerScorer[Team2Players].Score)
                {
                    HighestScorer = Team1Score.PlayerScorer[Team2Players];
                }
            }

            Console.WriteLine("Highest Scorer is :" + HighestScorer.PlayerDetail.PlayerName + " with strike rate of :" + HighestScorer.PlayerDetail.StrikeRate);

        }

        //public void GetTeamScoreDetails(Team team1)
        //{

        //}

        public void DisplayWinningTeam()
        {
            Team1Score.IsWinner = false;
            Team2Score.IsWinner = false;
            if (Team1Score.TotalScore > Team2Score.TotalScore)
            {
                Team1Score.IsWinner = true;
                // Team1Score.TeamDetails = matc
                Console.WriteLine("Team :" + Team1Score.Name + " :WON!!!!!!!!!");
                ManOfTheMatch = Team1Score.HighetScorer;
            }
            else
            {
                Team2Score.IsWinner = true;
                Console.WriteLine("Team :" + Team2Score.Name + " :WON!!!!!!!!!");
                ManOfTheMatch = Team2Score.HighetScorer;
            }
            Console.WriteLine("Man of the match is :" + ManOfTheMatch.PlayerDetail.PlayerName);

        }

        public void DisplayManOfTheMatch()
        {

        }

        //public void HighestScorerOfMatch()
        //{
        //    if(Team1Score.IsWinner == true)
        //    {
        //        Console.WriteLine("Highest Scorer of the Match :" + Team1Score.HighetScorer.PlayerDetail.PlayerName);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Highest Scorer of the Match :" + Team2Score.HighetScorer.PlayerDetail.PlayerName);
        //    }
        //}

    }
   

}
