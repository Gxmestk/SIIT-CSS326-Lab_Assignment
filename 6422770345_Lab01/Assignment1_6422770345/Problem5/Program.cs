//Let's create a C# program that simulates a shopping cart. We'll implement the
//basic functionalities of adding items to the cart, calculating the total price, and
//displaying the cart’s contents. Use classes to represent items and the shopping
//cart. (2.5 points)


using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Xml.Schema;

namespace prob5
{

    public class Item
    {
        public string name;
        public double price;
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public void info()
        {
            Console.WriteLine(this.name + " - $" + this.price);
        }
    }

    public class Cart
    {

        public Item[] arr;
        public double total_price;

        public Cart()
        {
            this.arr = new Item[] { };
            this.total_price = 0;
        }
        public void add2cart(Item item)
        {
            arr = arr.Append(item).ToArray();
            total_price += item.price;
        }
        public double get_total_price()
        {
            return total_price;
        }
        public void info()
        {
            Console.WriteLine("Shopping Cart Contents:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].name + " - ${0:F2}",arr[i].price);
            }
            Console.WriteLine("Total Price: ${0:F2}", this.total_price);
        }
    }
    class Prob5
    {
        static void Main(string[] args)
        {
            Cart cart = new Cart();
            Item shirt = new Item("Shirt", 25.99);
            cart.add2cart(shirt);
            cart.add2cart(new Item("Jeans", 25.99));
            cart.add2cart(new Item("Shoes", 25.99));
            cart.info();
        }
    }
}
