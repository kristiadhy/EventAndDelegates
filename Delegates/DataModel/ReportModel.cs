namespace Delegates.DataModel;
internal class ReportModel
{
    public string FilePath { get; set; } = string.Empty;
    public string FileName { get; set; } = string.Empty;
    public ReportDeliveryModel DeliveryModel { get; set; } = new();
}
