Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI

Namespace RepStoredProc

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            report.RequestParameters = False
            Call New ReportPrintTool(report).ShowPreview()
            report.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, New Object() {True})
        End Sub
    End Class
End Namespace
