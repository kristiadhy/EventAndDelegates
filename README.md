# Event and Delegates
This project runs in C# WinForm.

### Delegates
This line will help you understand the basic principle of delegate : **_Delegate is just a variable that holds a method instead of data_**

I use event and delegate in a different class called ReportSender.cs for this project.
Here is the declaration of the event and delegate.
```cs
    // Delegate declaration
    public delegate void BuildReportTextCallback(string media); //This is the delegate
    public event BuildReportTextCallback? BuildReportText; //This is the event

    public void BuildText(string media)
    {
        BuildReportText!.Invoke(media);
    }
```

I declare the class where the delegates are placed on the Form1.cs page.
```cs
private ReportSender reportSender = new();
```

And then I subscribe the event delegates with 3 methods inside Form1.cs. It will make the method executed 3 times. 
```cs
reportSender.BuildReportText += SetReceivingText;
reportSender.BuildReportText += SetSendingText;
reportSender.BuildReportText += SetReceivedText;

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
```

Here is how I call the method inside the ReportSender class and display the result
```cs
private void BtnSendByEmail_Click(object? sender, EventArgs e)
{
    messageList.Clear();
    reportSender.BuildText("Email");
    DisplayResult(messageList);
}

private void DisplayResult(List<string> messageList)
{
    txtResult.ResetText();
    foreach (string message in messageList)
        txtResult.Text += message;
}
```
