namespace GregYoung
{
    public class AppendToLog
    {
        public static void Append(LogRepo repo, AppendToLogCommand c)
        {
            repo.Log(c.Id);
        }
    }
}