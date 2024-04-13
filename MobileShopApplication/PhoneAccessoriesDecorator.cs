using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    abstract class PhoneAccessoriesDecorator : IPhoneComponent
    {
        private IPhoneComponent phoneComponent;

        public PhoneAccessoriesDecorator(IPhoneComponent phoneComponent)
        {
            this.phoneComponent = phoneComponent;
        }

        public string GetBrand()
        {
            return phoneComponent.GetBrand();
        }

        public string GetDetails()
        {
            return phoneComponent.GetDetails();
        }

        public string GetModel()
        {
            return phoneComponent.GetModel();
        }

        public virtual string Contents()
        {
            return phoneComponent.Contents();
        }
    }

    class PhoneCover : PhoneAccessoriesDecorator
    {
        public PhoneCover(IPhoneComponent phoneComponent) : base(phoneComponent)
        {
        }

        public override string Contents()
        {
            return base.Contents() + ", Phone Cover";
        }
    }

    class PhoneCharger : PhoneAccessoriesDecorator
    {
        public PhoneCharger(IPhoneComponent phoneComponent) : base(phoneComponent)
        {
        }

        public override string Contents()
        {
            return base.Contents() + ", Phone Charger";
        }
    }

    class ScreenGuard : PhoneAccessoriesDecorator
    {
        public ScreenGuard(IPhoneComponent phoneComponent) : base(phoneComponent)
        {
        }

        public override string Contents()
        {
            return base.Contents() + ", Screen Guard";
        }
    }

    class Earphones : PhoneAccessoriesDecorator
    {
        public Earphones(IPhoneComponent phoneComponent) : base(phoneComponent)
        {
        }

        public override string Contents()
        {
            return base.Contents() + ", Earphones";
        }
    }

}
