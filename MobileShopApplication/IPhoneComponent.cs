namespace MobileShopApplication
{
    public interface IPhoneComponent
    {
        string GetBrand();
        string GetModel();
        string GetDetails();
        string Contents();
    }

    public abstract class PhoneComponent : IPhoneComponent
    {
        protected IExtendedWarranty? extendedWarranty;
        public abstract string GetBrand();
        public abstract string GetModel();
        public abstract string GetDetails();
        public abstract string Contents();
        public void SetExtendedWarranty(IExtendedWarranty extendedWarranty)
        {
            this.extendedWarranty = extendedWarranty;
        }
        public string GetWarrantyDetails()
        {
            return "1 year manufacturer's warranty" + (extendedWarranty != null ? " plus " + extendedWarranty.GetExtendedWarrantyDetails(): "");
        }
    }

}