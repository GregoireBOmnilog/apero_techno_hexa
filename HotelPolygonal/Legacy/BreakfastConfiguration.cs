namespace Legacy;

public interface IBreakfastConfiguration
{
    public string GetChbCvrFilePath();
}

public class BreakfastConfiguration : IBreakfastConfiguration
{
    public string GetChbCvrFilePath() => "data/chbcvr.csv";
}
