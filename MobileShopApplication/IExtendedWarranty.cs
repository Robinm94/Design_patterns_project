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

    public class SixMonthsExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "Six months extended warranty";
        }
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

    public class ThreeYearExtendedWarranty : IExtendedWarranty
    {
        public string GetExtendedWarrantyDetails()
        {
            return "Three year extended warranty";
        }
    }
}
