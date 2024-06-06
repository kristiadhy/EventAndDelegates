namespace Delegates.DataModel;
internal class ReportDeliveryModel
{
    public string Message { get; set; } = string.Empty;
    public SendingMethod SendingMethod { get; set; } = SendingMethod.Email;
    public ReportStatus Status { get; set; } = ReportStatus.Unsend;
}

enum ReportStatus
{
    Unsend,
    Success,
    Failed
}

enum SendingMethod
{
    Email,
    Whatsapp,
    ExportPdf
}