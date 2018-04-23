Imports System.Windows.Forms
Imports DevExpress.Pdf

Namespace ExportAcroFormDocument
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()

            ' Load a PDF document with AcroForm data.  
            pdfViewer1.LoadDocument("..\..\AcroForm.pdf")

            ' Export the document to the xml format.
            pdfViewer1.Export("..\..\AcroForm.xml", PdfFormDataFormat.Xml)
        End Sub
    End Class
End Namespace
