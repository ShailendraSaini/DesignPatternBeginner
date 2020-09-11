namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     Interface IDrinkBuilder
    /// </summary>
    interface IDrinkBuilder
    {
        void AddWater();
        void AddPowder();
        Drink Drink { get; }
    }
}
