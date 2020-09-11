using System;

namespace DotNet.DesignPattern.Beginner
{
    /// <summary>
    ///     'SubsystemA' class - a single unit of complex subsystem
    /// </summary>
    public class Lights
    {
        public void switchOnLights()
        {
            Console.WriteLine("Lights - Switched ON");
        }
        public void switchOffLights()
        {
            Console.WriteLine("Lights - Switched OFF");
        }
    }

    /// <summary>
    ///     'SubsystemB' class - a single unit of complex subsystem
    /// </summary>
    public class MusicSystem
    {
        public void switchOnMusicSystem()
        {
            Console.WriteLine("Music System - Switched ON");
        }
        public void switchOffMusicSystem()
        {
            Console.WriteLine("Music System - Switched OFF");
        }
    }

    /// <summary>
    ///     'SubsystemC' class - a single unit of complex subsystem
    /// </summary>
    public class TV
    {
        public void switchOnTV()
        {
            Console.WriteLine("TV - Switched ON");
        }
        public void switchOffTV()
        {
            Console.WriteLine("TV - Switched OFF");
        }
    }

    /// <summary>
    ///     'SubsystemD' class - a single unit of complex subsystem
    /// </summary>
    public class HomeSecuritySystem
    {
        public void EnableSecuritySystem()
        {
            Console.WriteLine("Security System - Enabled");
        }
        public void DisableSecuritySystem()
        {
            Console.WriteLine("Security System - Disabled");
        }
    }

    /// <summary>
    ///     'SubsystemE' class - a single unit of complex subsystem
    /// </summary>
    public class PhoneAnsweringSystem
    {
        public void SetHomeMessage()
        {
            Console.WriteLine("Phone Answering System - Home custom Message set");
        }
        public void SetAwayMessage()
        {
            Console.WriteLine("Phone Answering System - Away custom Message set");
        }
    }

    /// <summary>
    ///     'Facade' class - will provide interface for client to access complex subsystem
    /// </summary>
    public class HomeFacade
    {
        Lights light;
        MusicSystem musicSystem;
        TV tv;
        HomeSecuritySystem securitySystem;
        PhoneAnsweringSystem phoneAnsweringSystem;
        public HomeFacade()
        {
            light = new Lights();
            musicSystem = new MusicSystem();
            tv = new TV();
            securitySystem = new HomeSecuritySystem();
            phoneAnsweringSystem = new PhoneAnsweringSystem();
        }

        /// <summary>
        ///     LeaveHomeforOffice
        /// </summary>
        public void LeaveHomeforOffice()
        {
            light.switchOffLights();
            musicSystem.switchOffMusicSystem();
            tv.switchOffTV();
            securitySystem.EnableSecuritySystem();
            phoneAnsweringSystem.SetAwayMessage();
        }

        /// <summary>
        ///     ArriveHomefromOffice
        /// </summary>
        public void ArriveHomefromOffice()
        {
            light.switchOnLights();
            musicSystem.switchOnMusicSystem();
            tv.switchOnTV();
            securitySystem.DisableSecuritySystem();
            phoneAnsweringSystem.SetHomeMessage();
        }
    }
}
