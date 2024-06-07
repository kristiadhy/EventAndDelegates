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
```
