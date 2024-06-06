namespace Delegates;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btnSendByEmail = new Button();
        btnSendByWhatsapp = new Button();
        btnExportToPdf = new Button();
        txtResult = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // btnSendByEmail
        // 
        btnSendByEmail.Location = new Point(11, 11);
        btnSendByEmail.Margin = new Padding(2);
        btnSendByEmail.Name = "btnSendByEmail";
        btnSendByEmail.Size = new Size(118, 32);
        btnSendByEmail.TabIndex = 2;
        btnSendByEmail.Text = "Send by Email";
        btnSendByEmail.UseVisualStyleBackColor = true;
        // 
        // btnSendByWhatsapp
        // 
        btnSendByWhatsapp.Location = new Point(133, 11);
        btnSendByWhatsapp.Margin = new Padding(2);
        btnSendByWhatsapp.Name = "btnSendByWhatsapp";
        btnSendByWhatsapp.Size = new Size(118, 32);
        btnSendByWhatsapp.TabIndex = 3;
        btnSendByWhatsapp.Text = "Send by Whatsapp";
        btnSendByWhatsapp.UseVisualStyleBackColor = true;
        // 
        // btnExportToPdf
        // 
        btnExportToPdf.Location = new Point(255, 11);
        btnExportToPdf.Margin = new Padding(2);
        btnExportToPdf.Name = "btnExportToPdf";
        btnExportToPdf.Size = new Size(118, 32);
        btnExportToPdf.TabIndex = 4;
        btnExportToPdf.Text = "Export to Pdf";
        btnExportToPdf.UseVisualStyleBackColor = true;
        // 
        // txtResult
        // 
        txtResult.Location = new Point(11, 47);
        txtResult.Margin = new Padding(2);
        txtResult.Multiline = true;
        txtResult.Name = "txtResult";
        txtResult.Size = new Size(538, 127);
        txtResult.TabIndex = 5;
        // 
        // button1
        // 
        button1.Location = new Point(377, 11);
        button1.Margin = new Padding(2);
        button1.Name = "button1";
        button1.Size = new Size(172, 32);
        button1.TabIndex = 6;
        button1.Text = "Execute All Methods";
        button1.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(560, 270);
        Controls.Add(button1);
        Controls.Add(txtResult);
        Controls.Add(btnExportToPdf);
        Controls.Add(btnSendByWhatsapp);
        Controls.Add(btnSendByEmail);
        Name = "Form1";
        Text = "Delegates";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnSendByEmail;
    private Button btnSendByWhatsapp;
    private Button btnExportToPdf;
    private TextBox txtResult;
    private Button button1;
}
