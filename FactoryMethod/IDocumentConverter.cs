using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    public interface IDocumentConverter
    {
        void Convert(string inputFile, string outputFile);
    }
}
