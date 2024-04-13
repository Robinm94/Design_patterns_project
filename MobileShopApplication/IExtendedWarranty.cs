using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    // Interface for bridge extended warranties
    public interface IExtendedWarranty
    {
        // Method to get the details of the extended warranty
        public string GetExtendedWarrantyDetails();
    }

    // Concrete classes that implement the IExtendedWarranty interface

    // Six months extended warranty
    public class SixMonthsExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "Six months extended warranty";
        }
    }

    // One year extended warranty
    public class OneYearExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "One year extended warranty";
        }
    }

    // Two year extended warranty
    public class TwoYearExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "Two year extended warranty";
        }
    }

    // Three year extended warranty
    public class ThreeYearExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "Three year extended warranty";
        }
    }
}
