namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     concrete product X1
    /// </summary>
    public class HondaCompactSedan : ISedan
    {
        public string Name()
        {
            return GlobalText.HondaAmazeText;
        }
    }

    /// <summary>
    ///     concrete product X2
    /// </summary>
    public class HondaFullSedan : ISedan
    {
        public string Name()
        {
            return GlobalText.HondaAccordText;
        }
    }

    /// <summary>
    ///     concrete product Y1
    /// </summary>
    public class HondaCompactSuv : ISuv
    {
        public string Name()
        {
            return GlobalText.HondaCRVText;
        }
    }

    /// <summary>
    ///     concrete product Y2
    /// </summary>
    public class HondaFullSuv : ISuv
    {
        public string Name()
        {
            return GlobalText.HondaPilotText;
        }
    }

    /// <summary>
    ///     concrete product X11
    /// </summary>
    public class ToyotaCompactSedan : ISedan
    {
        public string Name()
        {
            return GlobalText.ToyotaYarisText;
        }
    }

    /// <summary>
    ///     concrete product X12
    /// </summary>
    public class ToyotaFullSedan : ISedan
    {
        public string Name()
        {
            return GlobalText.ToyotaCamryText;
        }
    }

    /// <summary>
    ///     concrete product Y11
    /// </summary>
    public class ToyotaCompactSuv : ISuv
    {
        public string Name()
        {
            return GlobalText.ToyotaRav4Text;
        }
    }

    /// <summary>
    ///     concrete product Y12
    /// </summary>
    public class ToyotaFullSuv : ISuv
    {
        public string Name()
        {
            return GlobalText.ToyotaHighlanderText;
        }
    }
}
