using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    abstract class DocumentConverterFactory
    {
       public abstract IDocumentConverter CreateDocumentConverter();
    }
}
