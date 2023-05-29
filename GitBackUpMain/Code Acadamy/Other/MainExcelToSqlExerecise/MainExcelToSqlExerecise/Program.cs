using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace MainExcelToSqlExerecise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sqlConnectionString = "Data Source=DESKTOP-9OSB66T;Initial Catalog=Excel;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(sqlConnectionString);
            connection.Open();


            string excelConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\Lenovo\\Desktop\\Code Acadamy\\MainExcelToSqlExerecise\\MainExcelToSqlExerecise\\example_data.xlsx;Extended Properties='Excel 12.0;HDR=YES;'";
            OleDbConnection excelConnection = new OleDbConnection(excelConnectionString);
            excelConnection.Open();


            string selectQuery = "SELECT * FROM [Sheet1$]";
            OleDbCommand command = new OleDbCommand(selectQuery, excelConnection);
            OleDbDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string column1Value = reader["Segment"].ToString();
                string column2Value = reader["Country"].ToString();
                string column3Value = reader["Product"].ToString();
                string column4Value = reader["Discount Band"].ToString();
                string column5Value = reader["Units Sold"].ToString();
                string column6Value = reader["Manufacturing Price"].ToString();
                string column7Value = reader["Sale Price"].ToString();
                string column8Value = reader["Gross Sales"].ToString();
                string column9Value = reader["Discounts"].ToString();
                string column10Value = reader["Sales"].ToString();
                string column11Value = reader["COGS"].ToString();
                string column12Value = reader["Profit"].ToString();
                string column13Value = reader["Date"].ToString();

                string insertQuery = $"INSERT INTO ExcelSql (Segment, Country, Product, Discount_Band, Units_Sold, Manufacturing_Price, Sale_Price, Gross_Sales, Discounts, Sales, COGS, Profit, Date) VALUES ('{column1Value}', '{column2Value}', '{column3Value}', '{column4Value}', '{column5Value}', '{column6Value}', '{column7Value}', '{column8Value}', '{column9Value}', '{column10Value}', '{column11Value}', '{column12Value}', '{column13Value}')";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.ExecuteNonQuery();
            }


            reader.Close();
            excelConnection.Close();
            connection.Close();

        }
    }
}