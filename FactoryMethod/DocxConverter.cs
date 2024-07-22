using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class DocxConverter : IDocumentConverter
    {
        public void Convert(string inputFile, string outputFile)
        {
            Console.WriteLine($"Converting {inputFile} to PDF and saving as {outputFile}.");
        }
    }
}
