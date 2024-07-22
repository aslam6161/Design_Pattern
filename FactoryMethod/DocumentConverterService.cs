using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class DocumentConverterService
    {
        public void ExportDocument(DocumentConverterFactory factory, string inputFile, string outputFile)
        {
            IDocumentConverter documentConverter = factory.CreateDocumentConverter();
            documentConverter.Convert(inputFile, outputFile);
        }
    }
}
