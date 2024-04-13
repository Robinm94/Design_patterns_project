using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    public class SamsungPhone : PhoneComponent, IPhoneComponent
    {
        public override string GetBrand()
        {
            return "Samsung";
        }

        public override string GetDetails()
        {
            return "Default details for Samsung Phone";
        }

        public override string GetModel()
        {
            return "Default model for Samsung Phone";
        }
        public override string Contents()
        {
            return "Phone";
        }

    }

    public class GalaxyS21Ultra : SamsungPhone
    {
        public override string GetDetails()
        {
            return "Samsung Galaxy S21 Ultra has 6.8 inch display, 12GB RAM, 128GB storage, 108MP camera, 5000mAh battery";
        }

        public override string GetModel()
        {
            return "Samsung Galaxy S21 Ultra";
        }
    }

    public class GalaxyS21 : SamsungPhone
    {
        public override string GetDetails()
        {
            return "Samsung Galaxy S21 has 6.2 inch display, 8GB RAM, 128GB storage, 64MP camera, 4000mAh battery";
        }

        public override string GetModel()
        {
            return "Samsung Galaxy S21";
        }
    }

    public class GalaxyNote20Ultra : SamsungPhone
    {
        public override string GetDetails()
        {
            return "Samsung Galaxy Note20 Ultra has 6.9 inch display, 12GB RAM, 128GB storage, 108MP camera, 4500mAh battery";
        }

        public override string GetModel()
        {
            return "Samsung Galaxy Note20 Ultra";
        }
    }
}
