using GregYoung;

static internal class Bootstrap
{
    public static Dispatcher Configure()
    {
        var dispatcher = new Dispatcher();
        dispatcher.Register<AppendToLogCommand>(q =>
            {
                var repo = new LogRepo();
                AppendToLog.Append(repo, q);
            });

        return dispatcher;
    }
}