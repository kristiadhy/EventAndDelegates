using Delegates.Method;

namespace Delegates;

public partial class Form1 : Form
{
    private ReportSender reportSender = new();
    private List<string> messageList = [];

    public Form1()
    {
        InitializeComponent();

        StartPosition = FormStartPosition.CenterScreen;

        reportSender.BuildReportText += SetReceivingText;
        reportSender.BuildReportText += SetSendingText;
        reportSender.BuildReportText += SetReceivedText;

        btnSendByEmail.Click += BtnSendByEmail_Click;
        btnSendByWhatsapp.Click += BtnSendByWhatsapp_Click;
    }

    private void BtnSendByEmail_Click(object? sender, EventArgs e)
    {
        messageList.Clear();
        reportSender.BuildText("Email");
        DisplayResult(messageList);
    }

    private void BtnSendByWhatsapp_Click(object? sender, EventArgs e)
    {
        messageList.Clear();
        reportSender.BuildText("Whatsapp");
        DisplayResult(messageList);
    }

    private void SetReceivingText(string media)
    {
        messageList.Add($"Receiving file(s) from {media} account {Environment.NewLine}");
    }

    private void SetSendingText(string media)
    {
        messageList.Add($"Sending file(s) to another {media} account {Environment.NewLine}");
    }

    private void SetReceivedText(string media)
    {
        messageList.Add($"File(s) received in the destination {media} account {Environment.NewLine}");
    }

    private void DisplayResult(List<string> messageList)
    {
        txtResult.ResetText();
        foreach (string message in messageList)
            txtResult.Text += message;
    }
}