namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     The abstract Decorator class.
    /// </summary>
    abstract class Decorator : RestaurantDish
    {
        protected RestaurantDish _dish;

        /// <summary>
        ///     Decorator method
        /// </summary>
        /// <param name="dish"></param>
        public Decorator(RestaurantDish dish)
        {
            _dish = dish;
        }

        public override void Display()
        {
            _dish.Display();
        }
    }
}
