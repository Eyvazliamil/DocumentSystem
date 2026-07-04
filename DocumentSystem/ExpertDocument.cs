using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentSystem
{
    public class ExpertDocument : ProDocumentProgram
    { 
        public void OpenDocument() => Console.WriteLine("Expert Document Opened");
        public new void EditDocument() => Console.WriteLine("Expert Document Edited");
        public override void SaveDocument() => Console.WriteLine("Expert Document Saved in pdf format");
    }
}
