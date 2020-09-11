namespace DotNet.DesignPattern.Beginner
{
    using System;

    /// <summary>
    ///     Concrete Factory Class ToyotaFactory
    /// </summary>
    public class ToyotaFactory : ICarFactory
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
                    return new ToyotaCompactSedan();
                case "full":
                    return new ToyotaFullSedan();
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
                    return new ToyotaCompactSuv();
                case "full":
                    return new ToyotaFullSuv();
                default:
                    throw new Exception();
            }
        }
    }
}
