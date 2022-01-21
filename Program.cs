// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
namespace Assignment
{
   public class Program
    {
        string ProdutName;
        double ProdutPrice;
        int ProdutQuantity;
        string ProdutType;

        public int Quantity
        {
            get { return ProdutQuantity; }
            set { ProdutQuantity = value; }
        }
        public string Name
        {
            get { return ProdutName; }
            set { ProdutName = value; }
        }
        public double Price
        {
            get { return ProdutPrice; }
            set { ProdutPrice = value; }
        }
        public string Type
        {
            get { return ProdutType; }
            set { ProdutType = value; }
        }
        public override string ToString()
        {
            return " Product Name:-" + Name + " " +"Product Price:-"+ Price+" "+"Prodct Quantity:-"+Quantity+" "+"Product Type:-"+Type;
            return " Product Name:-" + Name + " " +"Product Price:-"+ Price+" RS"+" "+"Prodct Quantity:-"+Quantity+" "+"Product Type:-"+Type;
        }
         static void Main(string[] args)
         {
             List<Program> newlist = new List<Program>() 
             {
                 new Program(){ Name="lettuce", Price=10.5,Quantity=50,Type="Leafy green"},
                 new Program(){ Name="cabbage", Price=20,Quantity=100,Type="Cruciferous"},
                 new Program(){ Name="pumpkin", Price=30,Quantity=30,Type="Marrow"},
                 new Program(){ Name="cauliflower", Price=10,Quantity=25,Type="Cruciferous"},
                 new Program(){ Name="zucchini", Price=20.5,Quantity=50,Type="Marrow"},
                 new Program(){ Name="yam", Price=30,Quantity=50,Type="Root"},
                 new Program(){ Name="spinach", Price=10,Quantity=100,Type="Leafy green"},
                 new Program(){ Name="broccoli", Price=20.2 ,Quantity=75,Type="Cruciferous"},
                 new Program(){ Name="Garlic", Price=30 ,Quantity=20,Type="Leafy green"},
                 new Program(){ Name="silverbeet", Price=10,Quantity=50,Type="Marrow"}
             };
             Console.WriteLine("1. Total number of Product in Product List: {0}", newlist.Count);
             Console.WriteLine("2. After Adding Product(Potato)");
             //newlist.Add(new Program() { Name = "Potato", Price = "10 RS", Quantity = 50, Type = "Root" } );
             newlist.Add(new Program() { Name = "Potato", Price = 10, Quantity = 50, Type = "Root" } );
            
             Console.WriteLine("3. Total number of Product in Product List: {0}", newlist.Count);
             Console.WriteLine("4. List of Products are: ");
             foreach (var item in newlist)
                Console.WriteLine(item);
             Console.WriteLine("5. Product which are Leafy Green Type: ");
             foreach (var item in newlist)
             {
                if (item.Type.Equals("Leafy green"))
                    Console.WriteLine(item);
             }
             newlist.RemoveAt(9);
             //newlist.Remove(new Program() { Name = "Garlic", Price = 30, Quantity = 20, Type = "Leafy Green" } );
             Console.WriteLine("6. As All Garlic are sold out & Now Total number of Product in Product List are :{0}", newlist.Count);

            
             Console.WriteLine("7. If the user adds 50 cabbages to the inventory, then Final Quantity of Cabbage is :");
             //var updatecab = newlist.Where(n => n.Name="Cabbage").Quantity = Quantity+50; return Quantity;
             //var updatecab=newlist.Where(c=>c.Name="Cabbage").Select(c=>{c.Quantity= Quantity+"50"; return Quantity;}).newlist();
             Console.WriteLine("8. If a user purchases 1kg lettuce, 2 kg zucchini, 1 kg broccoli the what is the round figure that the user needs to pay?");
             double total = 0;
             foreach (var item in newlist)
             {
                if (item.Name.Equals("lettuce"))
                {
                    total=total + (1)*item.Price;
                }
                if (item.Name.Equals("zucchini"))
                {
                    total = total + (2) * item.Price;
                }
                if (item.Name.Equals("broccoli"))
                {
                    total = total + (1) * item.Price;
                }
            }
            Console.WriteLine("Rounded Value user needs to pay is:-{0}",total);  
        }
    }
}    