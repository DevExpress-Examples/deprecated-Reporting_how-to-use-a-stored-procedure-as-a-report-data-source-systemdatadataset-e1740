<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603789/12.2.11%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1740)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
* [XtraReport1.cs](./CS/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/XtraReport1.vb))
<!-- default file list end -->
# How to use a stored procedure as a report data source (System.Data.DataSet)


<p><strong>This approach is actual prior to version 14.1. Starting with version 14.1, use the approach illustrated in the following example: <a href="https://github.com/DevExpress-Examples/Reporting_how-to-bind-a-report-to-a-stored-procedure-provided-by-the-sql-data-source-in-a-t227366">How How to bind a report to a stored procedure provided by the SQL Data Source in a WinForms application</a>.</strong>
</p>


<p>The simplest method to use a stored procedure with parameters as a report data source is to create a corresponding TableAdapter in the VS DataSet designer.</p>
<p>To avoid the "Expected parameter was not supplied" error, when using parameterized stored procedure, please make certain whether the corresponding TableAdapter is detached from the XtraReport.DataAdapter property and the necessary parameter value is manually provided. You can use the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument4812">Report Parameters</a> for this purpose. Finally, fill the report's data source in the XtraReport.BeforePrint event handler by the TableAdapter.Fill() method call.</p>

<br/>


