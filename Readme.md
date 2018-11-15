<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ExportAcroFormDocument/Form1.cs) (VB: [Form1.vb](./VB/ExportAcroFormDocument/Form1.vb))
<!-- default file list end -->
# How to export AcroForm data to XML


This example shows how a PDF document with AcroForm data (interactive forms) can be exported to an XML format.<br /><br />You can also export the AcroForm data document to FDF, XFDF, and TXT formats using the approach described below.


<h3>Description</h3>

To export&nbsp;a document to&nbsp;XML format: <br />- load a document containing interactive forms (e.g., from a file path)&nbsp;into the PDF Viewer using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPdfViewerPdfViewer_LoadDocumenttopic">PdfViewer.LoadDocument</a> method;<br />- call the&nbsp;<strong>PdfViewer.Export</strong> extension method with a &nbsp;specified&nbsp;XML&nbsp;file&nbsp;name&nbsp;including a file path,&nbsp;where the exported&nbsp;document will be located,&nbsp;and&nbsp;an XML data format.<br /><br />Note that&nbsp;you may need to add&nbsp;the <strong>DevExpress.Docs</strong> reference&nbsp;to your application to access the<strong> PdfViewer.Export</strong> extension&nbsp;method.

<br/>


