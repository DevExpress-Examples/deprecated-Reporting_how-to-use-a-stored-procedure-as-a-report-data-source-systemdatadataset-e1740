Imports System
Imports System.Drawing
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI
Imports RepStoredProc.NorthwindDataSetTableAdapters

Namespace RepStoredProc

    Public Partial Class XtraReport1
        Inherits XtraReport

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub XtraReport1_BeforePrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
            custOrdersDetailTableAdapter.Fill(TryCast(DataSource, NorthwindDataSet).CustOrdersDetail, Convert.ToInt32(Parameters(CStr("OrderId")).Value))
        End Sub
    End Class
End Namespace
