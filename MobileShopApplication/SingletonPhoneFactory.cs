using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{

    // Enum for the different types of phones
    public enum PhoneType
    {
        Apple,
        Samsung,
        Xiaomi,
        Oppo
    }

    // Singleton factory class for creating phone objects
    public class SingletonPhoneFactory
    {
        // Single instance of the factory
        private static SingletonPhoneFactory? instance;

        // Private constructor to prevent direct instantiation
        private SingletonPhoneFactory()
        {
        }

        // Method to get the single instance of the factory
        public static SingletonPhoneFactory GetInstance()
        {
            // Create a new instance if one doesn't exist
            instance ??= new SingletonPhoneFactory();
            return instance;
        }

        // Method to create a phone object based on the type and model
        public IPhoneComponent CreatePhone(PhoneType phoneType, String modelName)
        {
            // Create a different type of phone based on the phoneType
            switch (phoneType)
            {
                case PhoneType.Apple:
                    // Create a different model of Apple phone based on the modelName
                    switch (modelName)
                    {
                        case "IPhone14ProMax":
                            return new IPhone14ProMax();
                        case "IPhone12":
                            return new IPhone12();
                        case "IPhone12Pro":
                            return new IPhone12Pro();
                        default:
                            return new ApplePhone();
                    }
                case PhoneType.Samsung:
                    // Create a different model of Samsung phone based on the modelName
                    switch (modelName)
                    {
                        case "GalaxyS21Ultra":
                            return new GalaxyS21Ultra();
                        case "GalaxyS21":
                            return new GalaxyS21();
                        case "GalaxyNote20Ultra":
                            return new GalaxyNote20Ultra();
                        default:
                            return new SamsungPhone();
                    }
                case PhoneType.Xiaomi:
                    // Create a different model of Xiaomi phone based on the modelName
                    switch (modelName)
                    {
                        case "Mi11":
                            return new Mi11();
                        case "RedmiNote10":
                            return new RedmiNote10();
                        case "PocoX3":
                            return new PocoX3();
                        default:
                            return new XiaomiPhone();
                    }
                case PhoneType.Oppo:
                    // Create a different model of Oppo phone based on the modelName
                    switch (modelName)
                    {
                        case "FindX3Pro":
                            return new FindX3Pro();
                        case "Reno5Pro":
                            return new Reno5Pro();
                        case "A74":
                            return new A74();
                        default:
                            return new OppoPhone();
                    }
                default:
                    // Throw an exception if the phoneType is not recognized
                    throw new ArgumentException("Invalid phone type or model name");
            }
        }
    }
}
