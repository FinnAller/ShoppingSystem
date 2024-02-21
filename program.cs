using Items;
using System;
class Program{
  static List<Items> cart = new List<Items>;
  static void Main(string[] args){
      Console.Title = "Shopping cart";
      cart.Clear();
      while(true){
          Console.Clear();
      }
  }
  static void Shopping(){
    Console.Clear();
    while(true){
      Console.Clear();
      Console.WriteLine("Cola - 1.99$");
      Console.WriteLine("Auto - 20.000$");
      Console.WriteLine("Deutschlandticket - 50$");
      Console.WriteLine("Kopfhörer - 90$");
      Console.Write("Select Item!");
    }
  }

}
