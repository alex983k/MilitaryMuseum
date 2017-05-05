using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using iTextSharp.text.pdf;
using iTextSharp.text;
using Excel = Microsoft.Office.Interop.Excel;

namespace Logic
{
    class DataExport
    {
        public static void Print(List<Item> list, string format, string path)
        {
            switch (format)
            {
                case "Excel":
                    PrintExcel(list, path);
                    break;
                case "PDF":
                    PrintPDF(list, path);
                    break;
            }
        }
        public static void Print(List<Provider> list, string format, string path)
        {
            switch (format)
            {
                case "Excel":
                    PrintExcel(list, path);
                    break;
                case "PDF":
                    PrintPDF(list, path);
                    break;
            }
        }
        private static void PrintExcel(List<Item> v, string path)
        {
            var excelApp = new Excel.Application()
            {
                // Make the object visible.
                Visible = true
            };
            #region info
            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            #endregion
            excelApp.Workbooks.Add();
            #region info
            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            #endregion
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "ID";
            workSheet.Cells[1, "B"] = "Name";
            workSheet.Cells[1, "C"] = "Area";
            workSheet.Cells[1, "D"] = "Category";
            workSheet.Cells[1, "E"] = "Description";
            workSheet.Cells[1, "F"] = "IDLocation";
            workSheet.Cells[1, "G"] = "ProviderID";

            var row = 1;
            foreach (var item in v)
            {
                row++;
                workSheet.Cells[row, "A"] = item.ID;
                workSheet.Cells[row, "B"] = item.Name;
                workSheet.Cells[row, "C"] = item.Area;
                workSheet.Cells[row, "D"] = item.Category;
                workSheet.Cells[row, "E"] = item.Description;
                workSheet.Cells[row, "F"] = item.IDLocation;
                workSheet.Cells[row, "G"] = item.ProviderID;


            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();
            workSheet.Columns[5].AutoFit();
            workSheet.Columns[6].AutoFit();
            workSheet.Columns[7].AutoFit();
            Console.WriteLine("Done! Please check the solution folder. :)");
        }
        private static void PrintExcel(List<Provider> v, string path)
        {
            var excelApp = new Excel.Application()
            {
                // Make the object visible.
                Visible = true
            };
            #region info
            // Create a new, empty workbook and add it to the collection returned 
            // by property Workbooks. The new workbook becomes the active workbook.
            // Add has an optional parameter for specifying a praticular template. 
            // Because no argument is sent in this example, Add creates a new workbook. 
            #endregion
            excelApp.Workbooks.Add();
            #region info
            // This example uses a single workSheet. The explicit type casting is
            // removed in a later procedure.
            #endregion
            Excel._Worksheet workSheet = (Excel.Worksheet)excelApp.ActiveSheet;

            workSheet.Cells[1, "A"] = "ID";
            workSheet.Cells[1, "B"] = "Name";
            workSheet.Cells[1, "C"] = "Email";
            workSheet.Cells[1, "D"] = "Phone";
            var row = 1;
            foreach (var item in v)
            {
                row++;
                workSheet.Cells[row, "A"] = item.ID;
                workSheet.Cells[row, "B"] = item.Name;
                workSheet.Cells[row, "C"] = item.Email;
                workSheet.Cells[row, "D"] = item.Phone;
            }
            workSheet.Columns[1].AutoFit();
            workSheet.Columns[2].AutoFit();
            workSheet.Columns[3].AutoFit();
            workSheet.Columns[4].AutoFit();
            Console.WriteLine("Done! Please check the solution folder. :)");
        }
        private static void PrintPDF(List<Item> v, string path)
        {
            FileStream fs = new FileStream("TryingToDoSomethingSwifty.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            for (int i = 1; i < v.Count; i++)
            {
                string line = v[i].ID + " " + v[i].Name + " " + v[i].Area + " " + v[i].Category + " " + v[i].Description + " " + v[i].IDLocation + " " + v[i].ProviderID;
                doc.Add(new Paragraph(line));
            }
            doc.Close();
            Console.WriteLine("Done! Please check the solution folder. :)");
        }
        private static void PrintPDF(List<Provider> v, string path)
        {
            FileStream fs = new FileStream("TryingToDoSomethingSwifty.pdf", FileMode.Create, FileAccess.Write, FileShare.None);
            Document doc = new Document();
            PdfWriter writer = PdfWriter.GetInstance(doc, fs);
            doc.Open();
            for (int i = 1; i < v.Count; i++)
            {
                string line = v[i].ID + " " + v[i].Name + " " + v[i].Email + " " + v[i].Phone;
                doc.Add(new Paragraph(line));
            }
            doc.Close();
            Console.WriteLine("Done! Please check the solution folder. :)");
        }
    }
}
