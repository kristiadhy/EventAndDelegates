namespace Delegates.Method;
internal class ReportSender
{
    // delegate declaration
    public delegate void BuildReportTextCallback(string media);
    public event BuildReportTextCallback? BuildReportText;

    public void BuildText(string media)
    {
        BuildReportText!.Invoke(media);
    }
}
