Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports RepStoredProc.NorthwindDataSetTableAdapters

Namespace RepStoredProc
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
			custOrdersDetailTableAdapter.Fill((TryCast(Me.DataSource, NorthwindDataSet)).CustOrdersDetail, Convert.ToInt32(Parameters("OrderId").Value))
		End Sub
	End Class
End Namespace
