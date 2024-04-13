namespace MobileShopApplication
{
    /// <summary>
    /// Interface for phone components
    /// </summary>
    public interface IPhoneComponent
    {
        /// <summary>
        /// Get the brand of the phone
        /// </summary>
        /// <returns>string</returns>
        string GetBrand();

        /// <summary>
        /// Get the model of the phone
        /// </summary>
        /// <returns>string</returns>
        string GetModel();

        /// <summary>
        /// Get the details of the phone
        /// </summary>
        /// <returns>string</returns>
        string GetDetails();

        /// <summary>
        /// Get the contents of the phone
        /// </summary>
        /// <returns>string</returns>
        string Contents();

        /// <summary>
        /// Get the warranty details
        /// </summary>
        /// <returns>string</returns>
        string GetWarrantyDetails();
    }

    public abstract class PhoneComponent : IPhoneComponent
    {
        protected IExtendedWarranty? extendedWarranty;
        public abstract string GetBrand();
        public abstract string GetModel();
        public abstract string GetDetails();
        public abstract string Contents();

        /// <summary>
        /// set the extended warranty
        /// </summary>
        /// <param name="extendedWarranty"></param>
        public void SetExtendedWarranty(IExtendedWarranty extendedWarranty)
        {
            this.extendedWarranty = extendedWarranty;
        }

        /// <summary>
        /// Get the warranty details
        /// </summary>
        /// <returns>string</returns>
        public string GetWarrantyDetails()
        {
            return "1 year manufacturer's warranty" + (extendedWarranty != null ? " plus " + extendedWarranty.GetExtendedWarrantyDetails(): "");
        }
    }

}