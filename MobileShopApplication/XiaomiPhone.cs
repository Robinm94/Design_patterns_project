using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    internal class XiaomiPhone : PhoneComponent, IPhoneComponent
    {
        public override string GetBrand()
        {
            return "Xiaomi";
        }
        public override string GetDetails()
        {
            return "Default details for Xiaomi Phone";
        }
        public override string GetModel()
        {
            return "Default model for Xiaomi Phone";
        }
        public override string Contents()
        {
            return "Phone";
        }

    }

    internal class Mi11 : XiaomiPhone
    {
        public override string GetDetails()
        {
            return "Xiaomi Mi 11 has 6.81 inch display, 8GB RAM, 128GB storage, 108MP camera, 4600mAh battery";
        }

        public override string GetModel()
        {
            return "Xiaomi Mi 11";
        }
    }

    internal class RedmiNote10 : XiaomiPhone
    {
        public override string GetDetails()
        {
            return "Xiaomi Redmi Note 10 has 6.43 inch display, 4GB RAM, 64GB storage, 48MP camera, 5000mAh battery";
        }

        public override string GetModel()
        {
            return "Xiaomi Redmi Note 10";
        }
    }

    internal class PocoX3 : XiaomiPhone
    {
        public override string GetDetails()
        {
            return "Xiaomi Poco X3 has 6.67 inch display, 6GB RAM, 64GB storage, 64MP camera, 6000mAh battery";
        }

        public override string GetModel()
        {
            return "Xiaomi Poco X3";
        }
    }
}
