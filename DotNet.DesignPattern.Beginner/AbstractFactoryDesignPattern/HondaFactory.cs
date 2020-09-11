namespace DotNet.DesignPattern.Beginner
{
    using System;

    /// <summary>
    ///     Concrete Factory Class HondaFactory
    /// </summary>
    public class HondaFactory : ICarFactory
    {
        /// <summary>
        ///     ManufactureSedan method
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public ISedan ManufactureSedan(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSedan();
                case "full":
                    return new HondaFullSedan();
                default:
                    throw new Exception();
            }
        }

        /// <summary>
        ///     ManufactureSuv method
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        public ISuv ManufactureSuv(string segment)
        {
            switch (segment)
            {
                case "compact":
                    return new HondaCompactSuv();
                case "full":
                    return new HondaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }
}
