using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legacy;

public static class BreakfastFormulaHelper
{
    public static int ComputeMargin(int ordered, int served)
    {
        return (int)Math.Ceiling((double)(ordered - served) / 2 * BreakfastConstants.SECURITY_MARGIN_PERCENTS);
    }
}
