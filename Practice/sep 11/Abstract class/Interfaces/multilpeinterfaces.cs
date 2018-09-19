using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IShop
    {
          void Name();
    }
    public interface IItems
    {
          void Number();
    }
    class Shop:IShop,IItems
    {
       public string ShopName { get; set; }
       public float Rating { get; set; }
       public void Name()
        {
            Console.WriteLine("the name is lassi shop with rating 4 ");
        }
       public void  Number()
        {
            Console.WriteLine("the number of sweets are 50");
        }

    }
    class Sweet:Shop, IShop, IItems
    {
        public string Colour { get; set; }
        public int SweetNumber { get; set; }
    }
    class Drink:Shop, IShop, IItems
    {
        public string DrinkName { get; set; }
        public float Quantity { get; set; }
    }
    class program
    {
        public static void Main(string[] args)
        {
            Shop s1 = new Shop();
            s1.Name();
            Sweet s2 = new Sweet();
            Console.WriteLine("enter the colour of sweet:");
            s2.Colour = Console.ReadLine();
            Console.WriteLine("the colour of sweet is"+s2.Colour);
            s2.Number();
            Drink d1 = new Drink();
            Console.WriteLine("enter the drink name:" );
            d1.DrinkName = Console.ReadLine();
            d1.Quantity = 50;
            Console.WriteLine("the drink name is\t"+d1.DrinkName+"\twith quantity of\t"+d1.Quantity);
            Console.ReadKey();
        }
    }
}
