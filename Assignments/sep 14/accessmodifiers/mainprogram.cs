using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cricketlaeguedetails;

namespace accessmodifiers
{
   public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************welcome to sports championship*****************");

            Console.WriteLine("press any key to enter the details");

            CricketLeague cricketLeague = new CricketLeague(Console.ReadLine());

            /*********************Team 1 Details******************************/
            Team Team1 = new Team();
            Team1.AcceptTeamDetails();

            /********************Team 2 Details*********************************/
            Team Team2 = new Team();
            Team2.AcceptTeamDetails();

            Match Match1 = new Match();

            Console.WriteLine("----------------Match1 Starts-------------------");

            Match1.Team1Score = new TeamScore();
            Match1.Team1Score.GetTeamScoreDetails(Team1);

            Match1.Team2Score = new TeamScore();
            Match1.Team2Score.GetTeamScoreDetails(Team2);

            /*********************Team 1 and Team 2  Details******************************/
            //TeamObject.DisplayScoreDetails(Match1);

            /*****************************Display Highest Scorer of a match***************************/
            Match1.DisplayHighestScorerInMatch();

            //Match1.HighestScorerOfMatch();

            /**************************Display Man Of the Match*********************************/

            Match1.DisplayManOfTheMatch();

            /****************************Display Team Which Won The Match******************************/
            Match1.DisplayWinningTeam();



            Console.ReadKey();

        }
    }
}
