using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopApplication
{
    public interface IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails();
    }

    public class OneYearExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "One year extended warranty";
        }
    }

    public class TwoYearExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "Two year extended warranty";
        }
    }
}
