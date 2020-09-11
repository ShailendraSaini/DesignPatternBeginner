namespace DotNet.DesignPattern.Beginner
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     A Concrete component class
    /// </summary>
    class FreshSalad : RestaurantDish
    {
        private string _greens;
        private string _cheese;
        private string _dressing;

        /// <summary>
        ///     FreshSalad method
        /// </summary>
        /// <param name="greens"></param>
        /// <param name="cheese"></param>
        /// <param name="dressing"></param>
        public FreshSalad(string greens, string cheese, string dressing)
        {
            _greens = greens;
            _cheese = cheese;
            _dressing = dressing;
        }

        public override void Display()
        {
            Console.WriteLine(GlobalText.FreshSaladLabel);
            Console.WriteLine(GlobalText.GreensLabel, _greens);
            Console.WriteLine(GlobalText.CheeseLabel, _cheese);
            Console.WriteLine(GlobalText.DressingLabel, _dressing);
        }
    }

    /// <summary>
    ///     A Concrete component class
    /// </summary>
    class Pasta : RestaurantDish
    {
        private string _pastaType;
        private string _sauce;

        public Pasta(string pastaType, string sauce)
        {
            _pastaType = pastaType;
            _sauce = sauce;
        }

        public override void Display()
        {
            Console.WriteLine(GlobalText.ClassicPastaLabel);
            Console.WriteLine(GlobalText.PastaLabel, _pastaType);
            Console.WriteLine(GlobalText.SauceLabel, _sauce);
        }
    }

    /// <summary>
    ///     A concrete Decorator. This class will impart "responsibilities" onto the dishes (e.g. whether or not those dishes have enough ingredients left to order them)
    /// </summary>
    class Available : Decorator
    {
        public int NumAvailable { get; set; } //How many can we make?
        protected List<string> customers = new List<string>();
        public Available(RestaurantDish dish, int numAvailable) : base(dish)
        {
            NumAvailable = numAvailable;
        }

        /// <summary>
        ///     OrderItem method
        /// </summary>
        /// <param name="name"></param>
        public void OrderItem(string name)
        {
            if (NumAvailable > 0)
            {
                customers.Add(name);
                NumAvailable--;
            }
            else
            {
                Console.WriteLine(string.Format(GlobalText.NotEnoughIngredientsText, name));
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (var customer in customers)
            {
                Console.WriteLine("Ordered by " + customer);
            }
        }
    }
}
