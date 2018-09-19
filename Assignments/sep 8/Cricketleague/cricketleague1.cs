using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports
{
    class league
    {
        public string leaguename;
    }
    class Match
    {
        Teamscore manofmatch;
        Teamscore highestscorer;
        public string team1;
        public string team2;
        public void Display()
        {
            Console.WriteLine("the team1 name is\t" +team1 );
            Console.ReadLine();
            Console.WriteLine( "the team2 name is" + team2);
            Console.ReadLine();
        }

    }
    class Team
    {
        //public string _teamname;
        public string []Player = new string[3];
        
        public void Display()
        {
            for (int teamnum= 0; teamnum < 2; teamnum++)
            {

                for (int playernum = 0; playernum < Player.Length; playernum++)
                {
               
                
                    Console.WriteLine("the player" + (playernum + 1) +"  of team  " +(teamnum + 1));
                     Console.ReadLine();

                    //Console.WriteLine("the player {0} of team 2 ", (i + 1));
                    //Player[i] = Console.ReadLine();
                }
            }
        }
    }
    class Teamscore: Team
    {
        public int teamscore1,teamscore2,totalt1=0,totalt2=0;
        public bool teamwinner;
        public int []playerscore = new int[11];
        public void Display()
        {
            //for (int i = 0; i < 11; i++)
            //{
            //    totalt1 = totalt1 +
            //}

            Console.WriteLine(" the teamscore1 is:" + totalt1);
            Console.ReadLine();
            Console.WriteLine( " the teamscore2 is: " + totalt2);
            Console.ReadLine();
            if(teamscore1>teamscore2)
            {
                Console.WriteLine("Team1 is Winner");
            }else
                Console.WriteLine("Team2 is winner");
        }
    }
    class Player
    {
        public string playername;
        public int jerseynumber;
        public float strikerate;
        public void Display()
        {
            Console.WriteLine("enter the name of player" + playername);
        }  

      
    }
    class Playerscore
    {
        Player p = new Player();
        public int[] playerscore=new int [3];
        public int balls;
        public void Display()
        {
            for (int teamnum = 0; teamnum < 2; teamnum++)
            {
                for (int playernum = 0; playernum < playerscore.Length; playernum++)
                {
                    Console.WriteLine("enter the" + (playernum + 1) + "st playerscore of team" + (teamnum + 1)+":");
                    Console.ReadLine();
                }
            }
           
            Console.WriteLine("enter the balls:"+balls);
            Console.ReadLine();
        }
    }
     class program3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome to Cricket League----------");
            Match m = new Match();
            Console.WriteLine("enter the teams details");
            m.Display();
            Team t = new Team();
            t.Display();
            Playerscore ps = new Playerscore();
            ps.Display();
            Teamscore ts = new Teamscore();
            ts.Display();
           
            Player p = new Player();
            p.Display();
            Console.ReadLine();
        }

     }
    
}
