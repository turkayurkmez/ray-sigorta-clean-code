// See https://aka.ms/new-console-template for more information
using OpenClosedPrinciple;


Console.WriteLine("Hello, World!");
/*
 * Bir nesne, .....gelişime..... AÇIK ......değişime..... KAPALI olmalı
 * 
 */
Document pdfDocument = new Document() { DocumentType = new XMLType() };
DocumentManagement documentManagement  = new DocumentManagement() { Document = pdfDocument };
documentManagement.Save();