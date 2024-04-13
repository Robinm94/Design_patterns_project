namespace MobileShopApplication
{
    /// <summary>
    /// Interface for phone components
    /// </summary>
    public interface IPhoneComponent
    {
        // Methods that all phone components must implement
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

    // Abstract class that implements the IPhoneComponent interface
    public abstract class PhoneComponent : IPhoneComponent
    {
        // Optional bridge extended warranty for the phone component
        protected IExtendedWarranty? extendedWarranty;

        // Abstract methods that subclasses must implement
        public abstract string GetBrand();
        public abstract string GetModel();
        public abstract string GetDetails();
        public abstract string Contents();

        /// <summary>
        /// Set the extended warranty for the phone component
        /// </summary>
        /// <param name="extendedWarranty">The extended warranty to set</param>
        public void SetExtendedWarranty(IExtendedWarranty extendedWarranty)
        {
            this.extendedWarranty = extendedWarranty;
        }

        /// <summary>
        /// Get the warranty details for the phone component
        /// </summary>
        /// <returns>A string describing the warranty</returns>
        public string GetWarrantyDetails()
        {
            // Return the standard warranty details, plus the extended warranty details if available
            return "1 year manufacturer's warranty" + (extendedWarranty != null ? " plus " + extendedWarranty.GetExtendedWarrantyDetails() : "");
        }
    }

}