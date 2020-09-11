namespace DotNet.DesignPattern.Beginner
{
    using System;

    /// <summary>
    ///     Concrete class Honda
    /// </summary>
    class Honda : ICarSupplier
    {
        public string CarColor
        {
            get { return GlobalText.RedColorText; }
        }

        public void GetCarModel()
        {
            Console.WriteLine(GlobalText.HondaCarModelText);
        }
    }

    /// <summary>
    ///     Concrete class BMW
    /// </summary>
    class BMW : ICarSupplier
    {
        public string CarColor
        {
            get { return GlobalText.WhiteColorText; }
        }
        public void GetCarModel()
        {
            Console.WriteLine(GlobalText.BMWCarModelText);
        }
    }

    /// <summary>
    ///     Concrete class Nano
    /// </summary>
    class Nano : ICarSupplier
    {
        public string CarColor
        {
            get { return "YELLOW"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine(GlobalText.NanoCarModelText);
        }
    }

    /// <summary>
    ///     Concrete class Suzuki
    /// </summary>
    class Suzuki : ICarSupplier
    {
        public string CarColor
        {
            get { return "Orange"; }
        }
        public void GetCarModel()
        {
            Console.WriteLine(GlobalText.SuzukiCarModelText);
        }
    }

    /// <summary>
    ///     Factory class CarFactory
    /// </summary>
    static class CarFactory
    {
        public static ICarSupplier GetCarInstance(int Id)
        {
            switch (Id)
            {
                case 0:
                    return new Honda();
                case 1:
                    return new BMW();
                case 2:
                    return new Nano();
                case 3:
                    return new Suzuki();
                default:
                    return null;
            }
        }
    }
}
