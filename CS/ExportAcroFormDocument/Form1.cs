using System.Windows.Forms;
using DevExpress.Pdf;

namespace ExportAcroFormDocument {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // Load a PDF document with AcroForm data.  
            pdfViewer1.LoadDocument("..\\..\\AcroForm.pdf");

            // Export the document to the xml format.
            pdfViewer1.Export("..\\..\\AcroForm.xml", PdfFormDataFormat.Xml);
        }
    }
}
