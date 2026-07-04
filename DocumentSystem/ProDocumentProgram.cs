using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class ProDocumentProgram : DocumentProgram
    {
       public new void OpenDocument() => Console.WriteLine("Pro Document Opened");
        public sealed override void EditDocument() => Console.WriteLine("Pro Document Edited");
        public override void SaveDocument() => Console.WriteLine("Pro Document Saved in doc format, for pdf format buy Expert packet");

    }
}
