using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    internal class OppoPhone : PhoneComponent, IPhoneComponent
    {
        public override string GetBrand()
        {
            return "Oppo";
        }

        public override string GetDetails()
        {
            return "Default details for Oppo Phone";
        }

        public override string GetModel()
        {
            return "Default model for Oppo Phone";
        }

        public override string Contents()
        {
            return "Phone";
        }

    }

    internal class FindX3Pro : OppoPhone
    {
        public override string GetDetails()
        {
            return "Oppo Find X3 Pro has 6.7 inch display, 12GB RAM, 256GB storage, 50MP camera, 4500mAh battery";
        }

        public override string GetModel()
        {
            return "Oppo Find X3 Pro";
        }
    }

    internal class Reno5Pro : OppoPhone
    {
        public override string GetDetails()
        {
            return "Oppo Reno5 Pro has 6.55 inch display, 8GB RAM, 128GB storage, 64MP camera, 4350mAh battery";
        }

        public override string GetModel()
        {
            return "Oppo Reno5 Pro";
        }
    }

    internal class A74 : OppoPhone
    {
        public override string GetDetails()
        {
            return "Oppo A74 has 6.43 inch display, 6GB RAM, 128GB storage, 48MP camera, 5000mAh battery";
        }

        public override string GetModel()
        {
            return "Oppo A74";
        }
    }
}
