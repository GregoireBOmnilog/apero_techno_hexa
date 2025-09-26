namespace Legacy;

public interface IBreakfastService
{
    public int ComputeBreakfastCovers();
}
public class BreakfastService(IBreakfastDataAccess breakfastDao)
    : IBreakfastService
{
    public int ComputeBreakfastCovers()
    {
        ChbCvrModel[] yesterdayData = breakfastDao.GetChbCvrData(".old");
        ChbCvrModel[] todayData = breakfastDao.GetChbCvrData("");

        int orderedYesterday = yesterdayData.Sum(x => x.nbCvrOrd);
        int servedYesterday = yesterdayData.Sum(x => x.nbCvrSrv);
        int orderedToday = todayData.Sum(x => x.nbCvrOrd);

        return orderedToday + BreakfastFormulaHelper
            .ComputeMargin(orderedYesterday, servedYesterday);
    }
}
