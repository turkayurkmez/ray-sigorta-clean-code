using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciple
{
    //public enum DocumentType
    //{
    //    Word,
    //    Excel,
    //    PDF
    //}

    public interface IDocumentType
    {
        public void Save();
        
    }

    public class ExcelType : IDocumentType
    {
        public void Save()
        {
            string path = "Excel konumu";
            Console.WriteLine($"{path} adresine kaydedildi");
        }
    }

    public class WordType : IDocumentType
    {
        public void Save()
        {
            string path = "Word konumu";

            Console.WriteLine($"{path} adresine kaydedildi");
        }
    }

    public class PDFType : IDocumentType
    {
        public void Save()
        {
            string path = "PDF konumu";

            Console.WriteLine($"{path} adresine kaydedildi");
        }
    }

    public class PowerPointType : IDocumentType
    {
        string path = "PDF konumu";

        public void Save()
        {
            Console.WriteLine($"{path} adresine kaydedildi");

        }
    }

    public class XMLType : IDocumentType
    {
        public void Save()
        {
            string path = "XML";
            Console.WriteLine($"{path} adresine kaydedildi");
        }
    }
    public class Document
    {
        public IDocumentType DocumentType { get; set; }
    }
    public class DocumentManagement
    {
        public Document Document { get; set; }
        public void Save()
        {
            //switch (Document.DocumentType)
            //{
            //    case DocumentType.Word:
            //        Console.WriteLine("Word sunucusuna kaydedildi");
            //        break;
            //    case DocumentType.Excel:
            //        Console.WriteLine("Excel sunucusuna kaydedildi");

            //        break;
            //    case DocumentType.PDF:
            //        Console.WriteLine("PDF sunucusuna kaydedildi");

            //        break;
            //    default:
            //        break;
            //}
            Document.DocumentType.Save();
        }
    }

}
