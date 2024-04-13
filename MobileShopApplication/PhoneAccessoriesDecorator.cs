using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    // Abstract decorator class that adds functionality to IPhoneComponent objects
    abstract class PhoneAccessoriesDecorator : PhoneComponent, IPhoneComponent
    {
        // The IPhoneComponent object that this decorator is decorating
        private IPhoneComponent phoneComponent;

        // Constructor that takes an IPhoneComponent object
        public PhoneAccessoriesDecorator(IPhoneComponent phoneComponent)
        {
            this.phoneComponent = phoneComponent;
        }

        // Methods that call the corresponding methods of the decorated IPhoneComponent object
        public override string GetBrand()
        {
            return phoneComponent.GetBrand();
        }

        public override string GetDetails()
        {
            return phoneComponent.GetDetails();
        }

        public override string GetModel()
        {
            return phoneComponent.GetModel();
        }

        public override string Contents()
        {
            return phoneComponent.Contents();
        }
    }

    // Concrete decorator classes that add specific functionality to IPhoneComponent objects

    class PhoneCover : PhoneAccessoriesDecorator
    {
        public PhoneCover(IPhoneComponent phoneComponent) : base(phoneComponent)
        {
        }

        // Add "Phone Cover" to the contents of the phone
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

        // Add "Phone Charger" to the contents of the phone
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

        // Add "Screen Guard" to the contents of the phone
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

        // Add "Earphones" to the contents of the phone
        public override string Contents()
        {
            return base.Contents() + ", Earphones";
        }
    }

}
