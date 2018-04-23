Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms

Namespace RepStoredProc
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Dim report As New XtraReport1()

			report.RequestParameters = False
			report.ShowPreview()
			report.PrintingSystem.ExecCommand(DevExpress.XtraPrinting.PrintingSystemCommand.Parameters, New Object() { True })
		End Sub
	End Class
End Namespace