using System.Data.OleDb;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Office.Interop.Excel;
using static System.Runtime.InteropServices.JavaScript.JSType;
using ExcelApp = Microsoft.Office.Interop.Excel;




namespace NewProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Application excelApp = new Application();


            //if (excelApp == null)
            //{
            //    Console.WriteLine("Excel is not installed!!");
            //    return;
            //}

            //Workbook excelBook = excelApp.Workbooks.Open(@"C:\Users\Lenovo\Desktop\Code Acadamy\NewProject\NewProject\RNET102-ExcelReportingProject-main\example_data.xlsx");
            //_Worksheet excelSheet = excelBook.Sheets[1];
            //ExcelApp.Range excelRange = excelSheet.UsedRange;



            //int rowCount = excelRange.Rows.Count;
            //int colCount = excelRange.Columns.Count;

            //for (int i = 1; i <= rowCount; i++)
            //{
            //    //create new line
            //    Console.Write("\r\n");
            //    for (int j = 1; j <= colCount; j++)
            //    {

            //        //write the console
            //        if (excelRange.Cells[i, j] != null && excelRange.Cells[i, j].Value2 != null)
            //            Console.Write(excelRange.Cells[i, j].Value2.ToString() + "\t");
            //    }
            //}


            //excelApp.Quit();
            //System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
            //Console.ReadLine();


            //OLEDB

            //        // if the File extension is .XLSX using below connection string
    //        string connString = "Provider= Microsoft.ACE.OLEDB.12.0;" + "Data Source=C:\\Users\\Lenovo\\Desktop\\Code Acadamy\\NewProject\\NewProject\\RNET102-ExcelReportingProject-main\\example_data.xlsx" + ";Extended Properties='Excel 8.0;HDR=Yes'";


    //        // Create the connection object
    //        OleDbConnection oledbConn = new OleDbConnection(connString);
    //        try
    //        {
    //            // Open connection
    //            oledbConn.Open();

    //            // Create OleDbCommand object and select data from worksheet Sample-spreadsheet-file
    //            //here sheet name is Sample-spreadsheet-file, usually it is Sheet1, Sheet2 etc..
    //            OleDbCommand cmd = new OleDbCommand("SELECT * FROM [Sheet1$]", oledbConn);

    //            // Create new OleDbDataAdapter
    //            OleDbDataAdapter oleda = new OleDbDataAdapter();

    //            oleda.SelectCommand = cmd;

    //            // Create a DataSet which will hold the data extracted from the worksheet.
    //            DataSet ds = new DataSet();

    //            // Fill the DataSet from the data extracted from the worksheet.
    //            oleda.Fill(ds, "Employees");

    //            //loop through each row
    //            foreach (var m in ds.Tables[0].DefaultView)
    //            {
    //                Console.WriteLine(((System.Data.DataRowView)m).Row.ItemArray[0] + " " + ((System.Data.DataRowView)m).Row.ItemArray[1] + " " + ((System.Data.DataRowView)m).Row.ItemArray[2] + " " + ((System.Data.DataRowView)m).Row.ItemArray[3] + " " + ((System.Data.DataRowView)m).Row.ItemArray[4] + " " + ((System.Data.DataRowView)m).Row.ItemArray[5] + ((System.Data.DataRowView)m).Row.ItemArray[6] + " " + ((System.Data.DataRowView)m).Row.ItemArray[7] + " " + ((System.Data.DataRowView)m).Row.ItemArray[8] + " " + ((System.Data.DataRowView)m).Row.ItemArray[9] + " " + ((System.Data.DataRowView)m).Row.ItemArray[10] + " " + ((System.Data.DataRowView)m).Row.ItemArray[11] + " " + ((System.Data.DataRowView)m).Row.ItemArray[12]);

    //            }

    //        }
    //        catch (Exception e)
    //        {
    //            Console.WriteLine("Error :" + e.Message);
    //        }
    //        finally
    //        {
    //            // Close connection
    //            oledbConn.Close();
    //        }
        }
    }


}
    