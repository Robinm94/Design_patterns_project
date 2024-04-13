using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    public class ApplePhone : PhoneComponent, IPhoneComponent
    {
        public override string Contents()
        {
            return "Phone";
        }

        public override string GetBrand()
        {
            return "Apple";
        }

        public override string GetDetails()
        {
            return "Default details for Apple Phone";
        }

        public override string GetModel()
        {
            return "Default model for Apple Phone";
        }
    }
    
    public class IPhone14ProMax: ApplePhone
    {
        public override string GetDetails()
        {
            return "Apple iPhone 14 Pro Max has 6.7 inch display, 6GB RAM, 128GB storage, 12MP camera, 3687mAh battery";
        }

        public override string GetModel()
        {
            return "Apple iPhone 14 Pro Max";
        }
    }

    public class IPhone12: ApplePhone
    {
        public override string GetDetails()
        {
            return "Apple iPhone 12 has 6.1 inch display, 4GB RAM, 64GB storage, 12MP camera, 2815mAh battery";
        }

        public override string GetModel()
        {
            return "Apple iPhone 12";
        }
    }

    public class IPhone12Pro: ApplePhone
    {
        public override string GetDetails()
        {
            return "Apple iPhone 12 Pro has 6.1 inch display, 6GB RAM, 128GB storage, 12MP camera, 2815mAh battery";
        }

        public override string GetModel()
        {
            return "Apple iPhone 12 Pro";
        }
    }
}
