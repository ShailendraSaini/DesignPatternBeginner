namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     Director class DrinkMaker
    /// </summary>
    class DrinkMaker
    {
        public void MakeDrink(IDrinkBuilder builder)
        {
            builder.AddWater();
            builder.AddPowder();
        }
    }

    /// <summary>
    ///     Concrete Class CoffeeBuilder
    /// </summary>
    class CoffeeBuilder : IDrinkBuilder
    {
        Drink drink;

        public CoffeeBuilder()
        {
            drink = new Drink("Coffee");
        }

        public void AddWater()
        {

        }

        public void AddPowder()
        {
            // Coffee powder
        }

        public Drink Drink
        {
            get { return drink; }
        }
    }

    /// <summary>
    ///     Concrete Class TeaBuilder
    /// </summary>
    class TeaBuilder : IDrinkBuilder
    {

        Drink drink;

        public TeaBuilder()
        {
            drink = new Drink("Tea");
        }

        public void AddWater()
        {

        }

        public void AddPowder()
        {
            //Tea Powder
        }

        public Drink Drink
        {
            get { return drink; }
        }
    }

    /// <summary>
    ///     End product Drink class
    /// </summary>
    class Drink
    {
        string _label;
        public Drink(string label)
        {
            this._label = label;
        }
        public override string ToString()
        {
            return this._label;
        }
    }
}
