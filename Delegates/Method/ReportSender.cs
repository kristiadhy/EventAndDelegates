namespace Delegates.Method;
internal class ReportSender
{
    // Delegate declaration
    public delegate void BuildReportTextCallback(string media); //This is the delegate
    public event BuildReportTextCallback? BuildReportText; //This is the event

    public void BuildText(string media)
    {
        BuildReportText!.Invoke(media);
    }
}
