using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace DAO
{
    public class StatisticDAO
    {
        private static StatisticDAO instance;

        public static StatisticDAO Instance
        {
            get { if (instance == null) instance = new StatisticDAO(); return StatisticDAO.instance; }
            private set { StatisticDAO.instance = value; }
        }

        public StatisticDAO() { }

        public string StatisticProduct(List<BillDTO> listBill, List<ImportDTO> listImport, string productID)
        {
            string s = "";
            int amountIn = 0, amountOut = 0;
            double sumIn = 0, sumOut = 0;
            try
            {
                if (listBill != null)
                {
                    string sqlBill = "SELECT SUM(Quantity) AS AmountOut, SUM(Quantity * Unitprice) AS SumOut FROM BillDetail WHERE ";
                    sqlBill += "ProductID = '" + productID + "' ";
                    sqlBill += "GROUP BY BillID";
                    DataTable dt = DataProvider.Instance.ExecuteQuery(sqlBill);
                    foreach (DataRow dr in dt.Rows)
                    {
                        amountOut += int.Parse(dr["AmountOut"].ToString());
                        sumOut += double.Parse(dr["SumOut"].ToString());
                    }
                }
                if (listImport != null)
                {
                    string sqlImport = "SELECT SUM(Quantity) AS AmountIn, SUM(Quantity * Unitprice) AS SumIn FROM ImportDetail WHERE ";
                    sqlImport += "ProductID = '" + productID + "' ";
                    sqlImport += "GROUP BY ImportID";
                    DataTable dt = DataProvider.Instance.ExecuteQuery(sqlImport);
                    foreach (DataRow dr in dt.Rows)
                    {
                        amountIn += int.Parse(dr["AmountIn"].ToString());
                        sumIn += double.Parse(dr["SumIn"].ToString());
                    }
                }
                s += "Amount Out: " + string.Format("{0:#,0}", amountOut) + "\t||\t" + "Amount In: " + string.Format("{0:#,0}", amountIn) + "\r\n";
                s += "Sum Out: " + string.Format("{0:#,0}", sumOut) + "\t||\t" + "Sum In: " + string.Format("{0:#,0}", sumIn) + "\r\n";
                s += "--------------------------------------------------" + "\r\n";
                s += "TOTAL: " + string.Format("{0:#,0}", sumOut - sumIn) + " VND";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        public string StatisticStaff(List<BillDTO> listBill, string staffID)
        {
            string s = "";
            double sum = 0;
            string listItem = string.Format("|\t{0}\t|\t{1}\t\t|\r\n", "ProductID", "Amount");
            try
            {
                if (listBill != null)
                {
                    string sqlStaff = "SELECT SUM(Total) AS Total FROM Bill WHERE (";
                    for (int i = 0; i < listBill.Count; i++)
                    {
                        string billID = listBill[i].BillID.ToString();
                        if (i == (listBill.Count) - 1)
                        {
                            sqlStaff += "BillID = '" + billID + "') ";
                            break;
                        }
                        sqlStaff += "BillID = '" + billID + "' OR ";
                    }
                    sqlStaff += "AND StaffID = '" + staffID + "' ";
                    sqlStaff += "GROUP BY StaffID";
                    DataTable dt1 = DataProvider.Instance.ExecuteQuery(sqlStaff);
                    foreach (DataRow dr in dt1.Rows)
                    {
                        sum += double.Parse(dr["Total"].ToString());
                    }
                    string sqlProduct = "SELECT ProductID, SUM(BillDetail.Quantity) AS Amount FROM BillDetail WHERE BillDetail.BillID IN(SELECT BillID FROM Bill WHERE (";
                    for (int i = 0; i < listBill.Count; i++)
                    {
                        string billID = listBill[i].BillID.ToString();
                        if (i == (listBill.Count - 1))
                        {
                            sqlProduct += "BillID = '" + billID + "') ";
                            break;
                        }
                        sqlProduct += "BillID = '" + billID + "' OR ";
                    }
                    sqlProduct += "AND StaffID = '" + staffID + "') ";
                    sqlProduct += "GROUP BY ProductID";
                    DataTable dt2 = DataProvider.Instance.ExecuteQuery(sqlProduct);
                    foreach (DataRow dr in dt2.Rows)
                    {
                        listItem += string.Format("|\t{0}\t|\t{1}\t\t|\r\n", dr["ProductID"].ToString(), dr["Amount"].ToString());
                    }
                    s += listItem;
                    s += "--------------------------------------------\r\n";
                    s += "TOTAL: " + string.Format("{0:#,0}", sum) + " VND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        public string StatisticCustomer(List<BillDTO> listBill, string customerID)
        {
            string s = "";
            double sum = 0;
            string listItem = string.Format("|\t{0}\t|\t{1}\t\t|\r\n", "ProductID", "Amount");
            try
            {
                if (listBill != null)
                {
                    string sqlCustomer = "SELECT SUM(Total) AS Total FROM Bill WHERE (";
                    for (int i = 0; i < listBill.Count; i++)
                    {
                        string billID = listBill[i].BillID.ToString();
                        if (i == (listBill.Count - 1))
                        {
                            sqlCustomer += "BillID = '" + billID + "') ";
                            break;
                        }
                        sqlCustomer += "BillID = '" + billID + "' OR ";
                    }
                    sqlCustomer += "AND CustomerID = '" + customerID + "' ";
                    sqlCustomer += "GROUP BY CustomerID";
                    DataTable dt1 = DataProvider.Instance.ExecuteQuery(sqlCustomer);
                    foreach (DataRow dr in dt1.Rows)
                    {
                        sum += double.Parse(dr["Total"].ToString());
                    }
                    string sqlProduct = "SELECT ProductID, SUM(BillDetail.Quantity) AS Amount FROM BillDetail WHERE BillDetail.BillID IN(SELECT BillID FROM Bill WHERE (";
                    for (int i = 0; i < listBill.Count; i++)
                    {
                        string billID = listBill[i].BillID.ToString();
                        if (i == (listBill.Count - 1))
                        {
                            sqlProduct += "BillID = '" + billID + "') ";
                            break;
                        }
                        sqlProduct += "BillID = '" + billID + "' OR ";
                    }
                    sqlProduct += "AND CustomerID = '" + customerID + "') ";
                    sqlProduct += "GROUP BY ProductID";
                    DataTable dt2 = DataProvider.Instance.ExecuteQuery(sqlProduct);
                    foreach (DataRow dr in dt2.Rows)
                    {
                        listItem += string.Format("|\t{0}\t|\t{1}\t\t|\r\n", dr["ProductID"].ToString(), dr["Amount"].ToString());
                    }
                    s += listItem;
                    s += "--------------------------------------------\r\n";
                    s += "TOTAL: " + string.Format("{0:#,0}", sum) + " VND";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        public string StatisticAllProduct(List<BillDTO> listBill, List<ImportDTO> listImport)
        {
            string s = "";
            string productID = "";
            int amountIn = 0, amountOut = 0;
            double sumIn = 0, sumOut = 0;
            double overall = 0;
            double overall_in = 0;
            double overall_out = 0;
            try
            {
                if (listBill != null)
                {
                    string sqlBill = "SELECT Product.ProductID AS ProductID, Product.ProductName AS ProductName, SUM(BillDetail.Quantity) AS AmountOut, SUM(BillDetail.Quantity * Unitprice) AS SumOut FROM Product LEFT JOIN BillDetail ON Product.ProductID = BillDetail.ProductID GROUP BY Product.ProductID";
                    DataTable dt1 = DataProvider.Instance.ExecuteQuery(sqlBill);
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        s += "Product ID : " + dr1["ProductID"].ToString() + "\r\n";
                        s += "Product Name : " + dr1["ProductName"].ToString() + "\r\n";
                        amountOut = dr1["AmountOut"].ToString() == "" ? 0 : int.Parse(dr1["AmountOut"].ToString());
                        sumOut = dr1["SumOut"].ToString() == "" ? 0 : double.Parse(dr1["SumOut"].ToString());
                        productID = dr1["ProductID"].ToString();
                        if (listImport != null)
                        {
                            string sqlImport = "SELECT SUM(Quantity) AS AmountIn, SUM(Quantity * Unitprice) AS SumIn FROM ImportDetail WHERE ";
                            sqlImport += "ProductID = '" + productID + "' ";
                            sqlImport += "GROUP BY ProductID";
                            DataTable dt2 = DataProvider.Instance.ExecuteQuery(sqlImport);
                            foreach (DataRow dr2 in dt2.Rows)
                            {
                                amountIn = int.Parse(dr2["AmountIn"].ToString());
                                sumIn = double.Parse(dr2["SumIn"].ToString());
                            }
                        }
                        s += "Amount Out: " + string.Format("{0:#,0}", amountOut) + "\r\n" + "Sum Out: " + string.Format("{0:#,0}", sumOut) + "\r\n";
                        s += "Amount In: " + string.Format("{0:#,0}", amountIn) + "\r\n" + "Sum In: " + string.Format("{0:#,0}", sumIn) + "\r\n";
                        s += "TOTAL: " + string.Format("{0:#,0}", sumOut - sumIn) + " VND" + "\r\n";
                        overall_in += sumIn;
                        overall_out += sumOut;
                        overall += (sumOut - sumIn);
                        s += "-----------------------------------------------------------" + "\r\n";
                    }
					s += "OVERALL OUT: \t\t\t" + string.Format("{0:#,0}", overall_out) + " VNĐ\r\n";
					s += "OVERALL IN: \t\t\t" + string.Format("{0:#,0}", overall_in) + " VNĐ\r\n";
					s += "-----------------------------------------------------------" + "\r\n";
					s += "OVERALL TOTAL: \t\t\t"+string.Format("{0:#,0}", overall) +" VNĐ";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        public string StatisticAllStaff(List<BillDTO> listBill)
        {
            string s = "";
            string staffID = "";
            double sum = 0;
            try
            {
                if (listBill != null)
                {
                    string sqlStaff = "SELECT StaffID, SUM(Total) AS Total FROM Bill WHERE (";
                    for (int i = 0; i < listBill.Count; i++)
                    {
                        string billID = listBill[i].BillID.ToString();
                        if (i == (listBill.Count) - 1)
                        {
                            sqlStaff += "BillID = '" + billID + "') ";
                            break;
                        }
                        sqlStaff += "BillID = '" + billID + "' OR ";
                    }
                    sqlStaff += "GROUP BY StaffID";
                    DataTable dt1 = DataProvider.Instance.ExecuteQuery(sqlStaff);
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        s += "Staff ID: " + dr1["StaffID"] + "\r\n";
                        staffID = dr1["StaffID"].ToString();
                        sum += double.Parse(dr1["Total"].ToString());
                        string sqlProduct = "SELECT ProductID, SUM(BillDetail.Quantity) AS Amount FROM BillDetail WHERE BillDetail.BillID IN(SELECT BillID FROM Bill WHERE (";
                        for (int i = 0; i < listBill.Count; i++)
                        {
                            string billID = listBill[i].BillID.ToString();
                            if (i == (listBill.Count - 1))
                            {
                                sqlProduct += "BillID = '" + billID + "') ";
                                break;
                            }
                            sqlProduct += "BillID = '" + billID + "' OR ";
                        }
                        sqlProduct += "AND StaffID = '" + staffID + "') ";
                        sqlProduct += "GROUP BY ProductID";
                        DataTable dt2 = DataProvider.Instance.ExecuteQuery(sqlProduct);
                        string listItem = string.Format("|\t{0}\t|\t{1}\t\t|\r\n", "ProductID", "Amount");
                        foreach (DataRow dr2 in dt2.Rows)
                        {
                            listItem += string.Format("|\t{0}\t\t|\t{1}\t\t|\r\n", dr2["ProductID"].ToString(), dr2["Amount"].ToString());
                        }
                        s += listItem;
                        s += "TOTAL: " + string.Format("{0:#,0}", sum) + " VND" + "\r\n";
                        s += "-----------------------------------------------------\r\n";
                        sum = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        public string StatisticAllCustomer(List<BillDTO> listBill)
        {
            string s = "";
            string customerID = "";
            double sum = 0;
            try
            {
                if (listBill != null)
                {
                    string sqlStaff = "SELECT CustomerID, SUM(Total) AS Total FROM Bill WHERE (";
                    for (int i = 0; i < listBill.Count; i++)
                    {
                        string billID = listBill[i].BillID.ToString();
                        if (i == (listBill.Count) - 1)
                        {
                            sqlStaff += "BillID = '" + billID + "') ";
                            break;
                        }
                        sqlStaff += "BillID = '" + billID + "' OR ";
                    }
                    sqlStaff += "GROUP BY CustomerID";
                    DataTable dt1 = DataProvider.Instance.ExecuteQuery(sqlStaff);
                    foreach (DataRow dr1 in dt1.Rows)
                    {
                        s += "Customer ID: " + dr1["CustomerID"] + "\r\n";
                        customerID = dr1["CustomerID"].ToString();
                        sum += double.Parse(dr1["Total"].ToString());
                        string sqlProduct = "SELECT ProductID, SUM(BillDetail.Quantity) AS Amount FROM BillDetail WHERE BillDetail.BillID IN(SELECT BillID FROM Bill WHERE (";
                        for (int i = 0; i < listBill.Count; i++)
                        {
                            string billID = listBill[i].BillID.ToString();
                            if (i == (listBill.Count - 1))
                            {
                                sqlProduct += "BillID = '" + billID + "') ";
                                break;
                            }
                            sqlProduct += "BillID = '" + billID + "' OR ";
                        }
                        sqlProduct += "AND CustomerID = '" + customerID + "') ";
                        sqlProduct += "GROUP BY ProductID";
                        DataTable dt2 = DataProvider.Instance.ExecuteQuery(sqlProduct);
                        string listItem = string.Format("|\t{0}\t|\t{1}\t\t|\r\n", "ProductID", "Amount");
                        foreach (DataRow dr2 in dt2.Rows)
                        {
                            listItem += string.Format("|\t{0}\t\t|\t{1}\t\t|\r\n", dr2["ProductID"].ToString(), dr2["Amount"].ToString());
                        }
                        s += listItem;
                        s += "TOTAL: " + string.Format("{0:#,0}", sum) + " VND" + "\r\n";
                        s += "-----------------------------------------------------\r\n";
                        sum = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return s;
        }

        public DataTable StatisticTopProduct(List<BillDTO> listBill)
        {
            DataTable dt = new DataTable();
            try
            {
                if (listBill != null)
                {
                    string sql = "SELECT BillDetail.ProductID, Product.ProductName, SUM(BillDetail.Quantity) AS Amount FROM BillDetail, Product WHERE ";
                    sql += "BillDetail.ProductID = Product.ProductID ";
                    sql += "GROUP BY BillDetail.ProductID ";
                    sql += "ORDER BY Amount DESC ";
                    sql += "LIMIT 5";
                    dt = DataProvider.Instance.ExecuteQuery(sql);

                    //s = string.Format("|\t{0}\t|\t{1}\t|\t{2}\t\t|\r\n", "Product ID", "Product Name", "Amount");
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    string productID = dr["ProductID"].ToString();
                    //    string productName = dr["ProductName"].ToString();
                    //    int amount = int.Parse(dr["Amount"].ToString());
                    //    s += string.Format("|\t{0}\t|\t{1}\t|\t{2}\t\t|\r\n", productID, productName, amount);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable StatisticTopStaff(List<BillDTO> listBill)
        {
            DataTable dt = new DataTable();
            string s = "";
            try
            {
                if (listBill != null)
                {
                    string sql = "SELECT Staff.StaffID, CONCAT(Staff.FirstName,' ',Staff.LastName) AS FullName ,SUM(Total) AS Total FROM Bill,Staff where Bill.StaffID = Staff.StaffID ";
                    sql += "GROUP BY Staff.StaffID ";
                    sql += "ORDER BY Total DESC ";
                    sql += "LIMIT 5";
                    dt = DataProvider.Instance.ExecuteQuery(sql);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        //dt.Rows[i]["Total"] = string.Format("{0:#,0}", dt.Rows[i]["Total"]);
                        //dt.Rows[i]["Total"] = Convert.ToDouble(string.Format("{0:#,0}", 11111111));
                        //dt.Rows[i]["Total"] = string.Format("{0:#,0}", 11111111);
                    }
                    dt.AcceptChanges();

                    //s = string.Format("|\t{0}\t\t|\t{1}\t|\t{2}\t\t|\r\n", "Staff ID", "Staff Name", "Total");
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    string staffID = dr["StaffID"].ToString();
                    //    string fullName = dr["FullName"].ToString();
                    //    double total = double.Parse(dr["Total"].ToString());
                    //    s += string.Format("|\t{0}\t\t|\t{1}\t\t|\t{2}\t\t|\r\n", staffID, fullName, total);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable StatisticTopCustomer(List<BillDTO> listBill)
        {
            DataTable dt = new DataTable();
            string s = "";
            try
            {
                if (listBill != null)
                {
                    string sql = "SELECT Customer.CustomerID, CONCAT(Customer.CustomerSurName,' ',Customer.CustomerName) AS FullName ,SUM(Total) AS Total FROM Bill,Customer Where Bill.CustomerID = Customer.CustomerID ";
                    
                    sql += "GROUP BY Customer.CustomerID ";
                    sql += "ORDER BY Total DESC ";
                    sql += "LIMIT 5";
                    dt = DataProvider.Instance.ExecuteQuery(sql);

                    //s = string.Format("|\t{0}\t|\t{1}\t\t|\t{2}\t\t|\r\n", "Customer ID", "Customer Name", "Total");
                    //foreach (DataRow dr in dt.Rows)
                    //{
                    //    string customerID = dr["CustomerID"].ToString();
                    //    string fullName = dr["FullName"].ToString();
                    //    double total = double.Parse(dr["Total"].ToString());
                    //    s += string.Format("|\t{0}\t\t|\t{1}\t\t|\t{2}\t\t|\r\n", customerID, fullName, total);
                    //}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable StatisticAllProductByChart(List<BillDTO> listBill, List<ImportDTO> listImport)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                if (listBill != null)
                {
                    string sqlBill = "SELECT Product.ProductID AS ProductID, Product.ProductName AS ProductName, SUM(BillDetail.Quantity) AS AmountOut, SUM(BillDetail.Quantity * Unitprice) AS SumOut FROM Product LEFT JOIN BillDetail ON Product.ProductID = BillDetail.ProductID GROUP BY Product.ProductID";
                    dt1 = DataProvider.Instance.ExecuteQuery(sqlBill);
                }
                if (listImport != null)
                {
                    string sqlImport = "SELECT Product.ProductID AS ProductID, Product.ProductName AS ProductName, SUM(ImportDetail.Quantity) AS AmountIn, SUM(ImportDetail.Quantity * Unitprice) AS SumIn FROM Product LEFT JOIN ImportDetail ON Product.ProductID = ImportDetail.ProductID GROUP BY Product.ProductID ";
                    dt2 = DataProvider.Instance.ExecuteQuery(sqlImport);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return MergeTwoDataTable(dt1, dt2);
        }

        public DataTable StatisticEachProductByChart(List<BillDTO> listBill, List<ImportDTO> listImport, string productID, string dateFrom, string dateTo)
        {
			DataTable dt1 = new DataTable();
			DataTable dt2 = new DataTable();
			if (listBill != null)
			{
				string sqlBill = "SELECT SUM(Quantity) AS AmountOut, SUM(Quantity * Unitprice) AS SumOut FROM BillDetail, bill WHERE bill.BillID = billdetail.BillID AND ProductID = '"+productID+"' AND bill.CreateTime BETWEEN '"+dateFrom+"' AND '"+dateTo+"';";
				//for (int i = 0; i < listBill.Count; i++)
				//{
				//    string billID = listBill[i].BillID.ToString();
				//    if (i == (listBill.Count - 1))
				//    {
				//        sqlBill += "BillID = '" + billID + "') ";
				//        break;
				//    }
				//    sqlBill += "BillID = '" + billID + "' OR ";
				//}
				//sqlBill += "AND ProductID = '" + productID + "' ";
				//sqlBill += "GROUP BY ProductID";
				dt1 = DataProvider.Instance.ExecuteQuery(sqlBill);
                
			}
			if (listImport != null)
			{
				string sqlImport = "SELECT SUM(Quantity) AS AmountIn, SUM(Quantity * Unitprice) AS SumIn FROM ImportDetail, Import WHERE import.ImportID = importdetail.ImportID AND ProductID = '" + productID + "' AND import.CreateTime BETWEEN '" + dateFrom + "' AND '" + dateTo + "';";
				//for (int i = 0; i < listImport.Count; i++)
				//{
				//    string importID = listImport[i].ImportID.ToString();
				//    if (i == (listImport.Count - 1))
				//    {
				//        sqlImport += "ImportID = '" + importID + "') ";
				//        break;
				//    }
				//    sqlImport += "ImportID = '" + importID + "' OR ";
				//}
				//sqlImport += "AND ProductID = '" + productID + "' ";
				//sqlImport += "GROUP BY ProductID";
				dt2 = DataProvider.Instance.ExecuteQuery(sqlImport);
			}
			return MergeTwoDataTable(dt1, dt2);
            
        }

        public DataTable StatisticEachStaffByChart(string staffID, string dateTo, string dateFrom)
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlBill = "SELECT CONCAT(FirstName,\" \",LastName, \" ( \",Staff.StaffID,\" ) \"), SUM(Quantity) AS AmountOut FROM Bill, BillDetail, Staff WHERE staff.StaffID = bill.StaffID AND Bill.BillID = BillDetail.BillID AND Bill.StaffID = '" + staffID + "' GROUP BY Bill.StaffID AND bill.CreateTime BETWEEN '"+dateFrom+"' AND '"+dateTo+"';";
                dt = DataProvider.Instance.ExecuteQuery(sqlBill);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        public DataTable StatisticEachCustomerByChart(string customerID, string dateTo, string dateFrom)
        {
            DataTable dt = new DataTable();
            try
            {
                string sqlBill = "SELECT CONCAT(CustomerSurname,\" \",CustomerName, \" ( \",Customer.CustomerID,\" ) \") AS Name, SUM(Quantity) AS AmountOut FROM Bill, BillDetail, Customer WHERE Bill.CustomerID = Customer.CustomerID AND Bill.BillID = BillDetail.BillID AND Bill.CustomerID = '" + customerID + "' GROUP BY Bill.CustomerID AND bill.CreateTime BETWEEN '" + dateFrom + "' AND '" + dateTo + "';";
                dt = DataProvider.Instance.ExecuteQuery(sqlBill);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }
		public DataTable StatisticMoneyProductEachMonthByChart(List<BillDTO> listBill, List<ImportDTO> listImport, string year)
		{
			DataTable dt = new DataTable();
			DataTable dt1 = new DataTable();
			DataTable dt2 = new DataTable();
			try
			{
				if (listBill != null)
				{
					string sqlBill = "SELECT SUM(Quantity * UnitPrice), MONTH(CreateTime) FROM Bill, BillDetail WHERE Bill.BillID = Billdetail.BillID AND YEAR(CreateTime) = '" + year + "' GROUP BY MONTH(CreateTime)";
					dt1 = DataProvider.Instance.ExecuteQuery(sqlBill);
				}
				if (listImport != null)
				{
					string sqlImport = "SELECT SUM(Quantity * UnitPrice), MONTH(CreateTime) FROM Import, ImportDetail WHERE Import.ImportID = ImportDetail.ImportID AND YEAR(CreateTime) = '" + year + "' GROUP BY MONTH(CreateTime)";
					dt2 = DataProvider.Instance.ExecuteQuery(sqlImport);
				}
				dt.Columns.Add("Month");
				dt.Columns.Add("AmountOut");
				dt.Columns.Add("AmountIn");
				DataRow dr;
				for (int i = 1; i <= 12; i++)
				{
					dr = dt.NewRow();
					dr["Month"] = i;
					dt.Rows.Add(dr);
				}
				foreach (DataRow dr1 in dt1.Rows)
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						if (dt.Rows[i]["Month"].ToString() == dr1["MONTH(CreateTime)"].ToString())
						{
							dt.Rows[i]["AmountOut"] = dr1["SUM(Quantity * UnitPrice)"];
						}
					}
				}
				foreach (DataRow dr2 in dt2.Rows)
				{
					for (int i = 0; i < dt.Rows.Count; i++)
					{
						if (dt.Rows[i]["Month"].ToString() == dr2["MONTH(CreateTime)"].ToString())
						{
							dt.Rows[i]["AmountIn"] = dr2["SUM(Quantity * UnitPrice)"];
						}
					}
				}
				dt.AcceptChanges();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return dt;
		}
		public DataTable StatisticAmountProductEachMonthByChart(List<BillDTO> listBill, List<ImportDTO> listImport, string year)
        {
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            try
            {
                if (listBill != null)
                {
                    string sqlBill = "SELECT SUM(Quantity), MONTH(CreateTime) FROM Bill, BillDetail WHERE Bill.BillID = Billdetail.BillID AND YEAR(CreateTime) = '"+year+"' GROUP BY MONTH(CreateTime)";
                    dt1 = DataProvider.Instance.ExecuteQuery(sqlBill);
                }
                if (listImport != null)
                {
                    string sqlImport = "SELECT SUM(Quantity), MONTH(CreateTime) FROM Import, ImportDetail WHERE Import.ImportID = ImportDetail.ImportID AND YEAR(CreateTime) = '"+year+"' GROUP BY MONTH(CreateTime)";
                    dt2 = DataProvider.Instance.ExecuteQuery(sqlImport);
                }
                dt.Columns.Add("Month");
                dt.Columns.Add("AmountOut");
                dt.Columns.Add("AmountIn");
                DataRow dr;
                for (int i = 1; i <= 12; i++)
                {
                    dr = dt.NewRow();
                    dr["Month"] = i;
                    dt.Rows.Add(dr);
                }
                foreach (DataRow dr1 in dt1.Rows)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["Month"].ToString() == dr1["MONTH(CreateTime)"].ToString())
                        {
                            dt.Rows[i]["AmountOut"] = dr1["SUM(Quantity)"];
                        }
                    }
                }
                foreach (DataRow dr2 in dt2.Rows)
                {
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        if (dt.Rows[i]["Month"].ToString() == dr2["MONTH(CreateTime)"].ToString())
                        {
                            dt.Rows[i]["AmountIn"] = dr2["SUM(Quantity)"];
                        }
                    }
                }
                dt.AcceptChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dt;
        }

        private DataTable MergeTwoDataTable(DataTable dt1, DataTable dt2)
        {
			DataTable dt = new DataTable();
				
			foreach (DataColumn col in dt1.Columns)
			{
				dt.Columns.Add(col.ColumnName);
			}
			foreach (DataColumn col in dt2.Columns)
			{
				if (!dt.Columns.Contains(col.ColumnName))
				{
					dt.Columns.Add(col.ColumnName);
				}
			}
			for (int i = 0; i < dt1.Rows.Count; i++)
			{
				DataRow dr = dt.NewRow();
				foreach (DataColumn col in dt1.Columns)
				{
					dr[col.ColumnName] = dt1.Rows[i][col.ColumnName];
				}
				foreach (DataColumn col in dt2.Columns)
				{
					dr[col.ColumnName] = dt2.Rows[i][col.ColumnName];
				}
				dt.Rows.Add(dr);
				dt.AcceptChanges();
			}
			return dt;
        }
    }
}
