namespace DotNet.DesignPattern.Beginner
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    ///     Sealed Class ThreadSafePrinter
    /// </summary>
    public sealed class ThreadSafePrinter
    {
        private static ThreadSafePrinter _threadSafePrinterInstance;
        private Queue<String> _queue = new Queue<string>();
        private static string _instanceName;
        private static object _syncRoot = new object();

        ///<summary>  
        ///     private and parameterless constructor that prevents other classes from instantiating it
        ///</summary>  
        private ThreadSafePrinter() { }

        /// <summary>
        ///     This method is to get the instance of Printer class  
        /// </summary>
        /// <param name="instanceName"></param>
        /// <returns></returns>
        public static ThreadSafePrinter GetPrinterInstance(string instanceName)
        {
            if (_threadSafePrinterInstance == null)
            {
                lock (_syncRoot)
                {
                    if (_threadSafePrinterInstance == null)
                    {
                        _instanceName = instanceName;
                        Console.WriteLine($"{instanceName} printer object created");
                        _threadSafePrinterInstance = new ThreadSafePrinter();
                    }
                }
            }
            return _threadSafePrinterInstance;
        }

        public static ThreadSafePrinter GetThreadSafePrinterInstance(string instanceName, string documentName)
        {
            var printerObject = ThreadSafePrinter.GetPrinterInstance(instanceName);
            printerObject.AddDocument(documentName);
            printerObject.PrintDocument();
            return printerObject;
        }

        /// <summary>
        ///     AddDocument
        /// </summary>
        /// <param name="documentName"></param>
        public void AddDocument(string documentName) { }

        /// <summary>
        ///     PrintDocument
        /// </summary>
        public void PrintDocument() { }
    }
}
