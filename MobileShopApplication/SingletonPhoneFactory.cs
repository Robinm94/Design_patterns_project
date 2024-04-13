using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{

    public enum PhoneType
    {
        Apple,
        Samsung,
        Xiaomi,
        Oppo
    }

    public class SingletonPhoneFactory
    {
        private static SingletonPhoneFactory? instance;

        private SingletonPhoneFactory()
        {
        }
        
        public static SingletonPhoneFactory GetInstance()
        {
            instance ??= new SingletonPhoneFactory();
            return instance;
        }

        public IPhoneComponent CreatePhone(PhoneType phoneType, String modelName)
        {
            switch (phoneType)
            {
                case PhoneType.Apple:
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
                    throw new ArgumentException("Invalid phone type or model name");
            }
        }
    }
}
