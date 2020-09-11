namespace DotNet.DesignPattern.Beginner
{
    using System;
    using System.Threading.Tasks;

    /// <summary>
    /// Main Program Class
    /// </summary>
    class Program
    {
        /// <summary>
        ///     Main method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            #region Singleton Pattern
            Console.WriteLine("--------------------------Singleton Pattern--------------------------");
            ThreadSafePrinter firstPrinterObject = null;
            ThreadSafePrinter secondPrinterObject = null;
            ThreadSafePrinter thirdPrinterObject = null;
            Task task1 = Task.Factory.StartNew(() =>
            {
                firstPrinterObject = ThreadSafePrinter.GetThreadSafePrinterInstance(GlobalText.FirstLabel, GlobalText.FirstDocumentLabel);
            });
            Task task2 = Task.Factory.StartNew(() =>
            {
                secondPrinterObject = ThreadSafePrinter.GetThreadSafePrinterInstance(GlobalText.SecondLabel, GlobalText.SecondDocumentLabel);
            });
            Task task3 = Task.Factory.StartNew(() =>
            {
                thirdPrinterObject = ThreadSafePrinter.GetThreadSafePrinterInstance(GlobalText.ThirdLabel, GlobalText.ThirdDocumentLabel);
            });
            Task.WaitAll(task1, task2, task3);
            Console.WriteLine(GlobalText.AllThreadsCompleteText);
            Console.WriteLine(GlobalText.FirstPrinterAndSecondPrinterObjectSameText, firstPrinterObject.Equals(secondPrinterObject) ? "Yes" : "No");
            Console.WriteLine(GlobalText.FirstPrinterAndThirdPrinterObjectSameText, firstPrinterObject.Equals(thirdPrinterObject) ? "Yes" : "No");
            Console.WriteLine(GlobalText.SecondPrinterAndThirdPrinterObjectSameText, secondPrinterObject.Equals(thirdPrinterObject) ? "Yes" : "No");
            #endregion

            #region Factory Pattern
            Console.WriteLine("\r\n\r\n--------------------------Factory Pattern--------------------------");
            ICarSupplier objCarSupplier = CarFactory.GetCarInstance(3);
            objCarSupplier.GetCarModel();
            Console.WriteLine(GlobalText.AndColorIsText + objCarSupplier.CarColor);
            #endregion

            #region Abstract Factory Pattern
            Console.WriteLine("\r\n\r\n--------------------------Abstract Factory Pattern--------------------------");
            CarClient hondaClient;
            CarClient toyotaClient;
            Console.WriteLine(GlobalText.HondaCarFactoryText);
            hondaClient = new CarClient(new HondaFactory(), GlobalText.CompactText);
            Console.WriteLine(string.Format(GlobalText.ManufactureingCompactSedanText, hondaClient.GetManufacturedSedanName()));
            Console.WriteLine(string.Format(GlobalText.ManufactureingCompactSuvText, hondaClient.GetManufacturedSuvName()));
            hondaClient = new CarClient(new HondaFactory(), GlobalText.FullText);
            Console.WriteLine(string.Format(GlobalText.ManufactureingFullSedanText, hondaClient.GetManufacturedSedanName()));
            Console.WriteLine(string.Format(GlobalText.ManufactureingFullSuvText, hondaClient.GetManufacturedSuvName()));
            Console.WriteLine(GlobalText.ToyotaCarFactoryText);
            toyotaClient = new CarClient(new ToyotaFactory(), GlobalText.CompactText);
            Console.WriteLine(string.Format(GlobalText.ManufactureingCompactSedanText, toyotaClient.GetManufacturedSedanName()));
            Console.WriteLine(string.Format(GlobalText.ManufactureingCompactSuvText, toyotaClient.GetManufacturedSuvName()));
            toyotaClient = new CarClient(new ToyotaFactory(), GlobalText.FullText);
            Console.WriteLine(string.Format(GlobalText.ManufactureingFullSedanText, toyotaClient.GetManufacturedSedanName()));
            Console.WriteLine(string.Format(GlobalText.ManufactureingFullSuvText, toyotaClient.GetManufacturedSuvName()));
            #endregion

            #region Builder Pattern
            Console.WriteLine("\r\n\r\n--------------------------Builder Pattern--------------------------");
            DrinkMaker maker;
            IDrinkBuilder builder;
            Console.WriteLine(GlobalText.TeaCoffeeSelectText);
            maker = new DrinkMaker();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "T")
                {
                    builder = new TeaBuilder();
                    maker.MakeDrink(builder);
                    Console.WriteLine(builder.Drink.ToString() + GlobalText.IsReadyText);
                    Console.WriteLine(GlobalText.TeaCoffeeSelectText);
                }
                else if (input == "C")
                {
                    builder = new CoffeeBuilder();
                    maker.MakeDrink(builder);
                    Console.WriteLine(builder.Drink.ToString() + GlobalText.IsReadyText);
                    Console.WriteLine(GlobalText.TeaCoffeeSelectText);
                }
                else
                {
                    break;
                }
            }
            #endregion

            #region Decorator Pattern
            Console.WriteLine("\r\n\r\n--------------------------Decorator Pattern--------------------------");
            //Step 1: Define some dishes, and how many of each we can make
            FreshSalad caesarSalad = new FreshSalad(GlobalText.CrispRomaineLettuceText, GlobalText.FreshlyGratedParmesanCheeseText, GlobalText.HouseMadeCaesarDressingText);
            caesarSalad.Display();
            Pasta fettuccineAlfredo = new Pasta(GlobalText.FreshMadeDailyPastaText, GlobalText.CreamlyGarlicAlfredoSauceText);
            fettuccineAlfredo.Display();
            Console.WriteLine(GlobalText.MakingTheseDishesAvailableText);
            //Step 2: Decorate the dishes; now if we attempt to order them once we're out of ingredients, we can notify the customer
            Available caesarAvailable = new Available(caesarSalad, 3);
            Available alfredoAvailable = new Available(fettuccineAlfredo, 4);
            //Step 3: Order a bunch of dishes
            caesarAvailable.OrderItem("John");
            caesarAvailable.OrderItem("Sally");
            caesarAvailable.OrderItem("Manush");
            alfredoAvailable.OrderItem("Sally");
            alfredoAvailable.OrderItem("Francis");
            alfredoAvailable.OrderItem("Venkat");
            alfredoAvailable.OrderItem("Diana");
            alfredoAvailable.OrderItem("Dennis");
            caesarAvailable.Display();
            alfredoAvailable.Display();
            #endregion

            #region Facade Pattern
            Console.WriteLine("\r\n\r\n--------------------------Facade Pattern--------------------------");
            HomeFacade homeFacade = new HomeFacade();
            Console.WriteLine(GlobalText.LeaveHomeForOfficeControlText);
            homeFacade.LeaveHomeforOffice();
            Console.WriteLine(GlobalText.ArriveHomeFromOfficeControlText);
            homeFacade.ArriveHomefromOffice();
            Console.ReadLine();
            Console.ReadLine();
            #endregion
        }
    }
}
