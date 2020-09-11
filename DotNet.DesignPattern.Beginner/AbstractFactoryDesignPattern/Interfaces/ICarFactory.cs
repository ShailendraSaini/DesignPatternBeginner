namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     Interface ICarFactory
    /// </summary>
    public interface ICarFactory
    {
        /// <summary>
        ///     ManufactureSedan
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        ISedan ManufactureSedan(string segment);

        /// <summary>
        ///     ManufactureSuv
        /// </summary>
        /// <param name="segment"></param>
        /// <returns></returns>
        ISuv ManufactureSuv(string segment);
    }
}
