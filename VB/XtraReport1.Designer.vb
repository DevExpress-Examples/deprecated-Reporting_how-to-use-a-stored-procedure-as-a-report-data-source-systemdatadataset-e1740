Namespace RepStoredProc

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.northwindDataSet1 = New NorthwindDataSet()
            Me.custOrdersDetailTableAdapter = New NorthwindDataSetTableAdapters.CustOrdersDetailTableAdapter()
            Me.OrderId = New DevExpress.XtraReports.Parameters.Parameter()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.bottomMarginBand1 = New DevExpress.XtraReports.UI.BottomMarginBand()
            CType((Me.northwindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel2, Me.xrLabel1})
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersDetail.UnitPrice")})
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(483F, 33F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersDetail.Quantity")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(333F, 33F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(100F, 25F)
            Me.xrLabel2.Text = "xrLabel2"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "CustOrdersDetail.ProductName")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(50F, 33F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(242F, 25F)
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.HeightF = 30F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.HeightF = 30F
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' northwindDataSet1
            ' 
            Me.northwindDataSet1.DataSetName = "NorthwindDataSet"
            Me.northwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' custOrdersDetailTableAdapter
            ' 
            Me.custOrdersDetailTableAdapter.ClearBeforeFill = True
            ' 
            ' OrderId
            ' 
            Me.OrderId.Name = "OrderId"
            Me.OrderId.Type = GetType(Integer)
            Me.OrderId.Value = 10248
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' bottomMarginBand1
            ' 
            Me.bottomMarginBand1.Name = "bottomMarginBand1"
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter, Me.topMarginBand1, Me.bottomMarginBand1})
            Me.DataMember = "CustOrdersDetail"
            Me.DataSource = Me.northwindDataSet1
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.OrderId})
            Me.Version = "10.2"
            AddHandler Me.BeforePrint, New DevExpress.XtraReports.UI.BeforePrintEventHandler(AddressOf Me.XtraReport1_BeforePrint)
            CType((Me.northwindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand

        Private northwindDataSet1 As NorthwindDataSet

        Private custOrdersDetailTableAdapter As NorthwindDataSetTableAdapters.CustOrdersDetailTableAdapter

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private OrderId As DevExpress.XtraReports.Parameters.Parameter

        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand

        Private bottomMarginBand1 As DevExpress.XtraReports.UI.BottomMarginBand
    End Class
End Namespace
