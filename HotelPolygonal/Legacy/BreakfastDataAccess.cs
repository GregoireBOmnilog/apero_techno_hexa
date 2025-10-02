using System.Globalization;

namespace Legacy;

public interface IBreakfastDataAccess
{
    public ChbCvrModel[] GetChbCvrData(string suffix);
}

public class BreakfastDataAccess(IBreakfastConfiguration conf)
    : IBreakfastDataAccess
{
    public ChbCvrModel[] GetChbCvrData(string suffix)
    {
        try
        {
            string filePath = conf.GetChbCvrFilePath() + suffix;
            ChbCvrModel[] covers = ParseChbCvrCsv(filePath);

            return covers;
        }
        catch (Exception e)
        {
            BreakfastLogger.LogError(e.Message, e.StackTrace);
            throw;
        }
    }

    private ChbCvrModel[] ParseChbCvrCsv(string filePath)
    {
        var items = new List<ChbCvrModel>();
        foreach (var line in File.ReadLines(filePath))
        {
            var parts = line.Split(';');
            if (parts.Length == 3 &&
                int.TryParse(parts[1], NumberStyles.Integer, CultureInfo.InvariantCulture, out int nbCvrtOrd) &&
                int.TryParse(parts[2], NumberStyles.Integer, CultureInfo.InvariantCulture, out int nbCvrtSrv))
            {
                items.Add(new ChbCvrModel(parts[0], nbCvrtOrd, nbCvrtSrv));
            }
        }
        return items.ToArray();
    }
}

