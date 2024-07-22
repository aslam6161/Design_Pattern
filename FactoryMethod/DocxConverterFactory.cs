﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryMethod
{
    class DocxConverterFactory : DocumentConverterFactory
    {
        public override IDocumentConverter CreateDocumentConverter()
        {
            return new DocxConverter();
        }
    }
}