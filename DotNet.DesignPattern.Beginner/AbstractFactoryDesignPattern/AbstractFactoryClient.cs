namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     Abstract Factory class CarClient
    /// </summary>
    public class CarClient
    {
        private ISedan sedan;
        private ISuv suv;

        /// <summary>
        ///     Paramerized Constructor of CarClient Class
        /// </summary>
        /// <param name="factory"></param>
        /// <param name="segment"></param>
        public CarClient(ICarFactory factory, string segment)
        {
            sedan = factory.ManufactureSedan(segment);
            suv = factory.ManufactureSuv(segment);
        }

        /// <summary>
        ///     Get Manufactured Sedan Name
        /// </summary>
        /// <returns></returns>
        public string GetManufacturedSedanName()
        {
            return sedan.Name();
        }

        /// <summary>
        ///     Get Manufactured Suv Name
        /// </summary>
        /// <returns></returns>
        public string GetManufacturedSuvName()
        {
            return suv.Name();
        }
    }
}
