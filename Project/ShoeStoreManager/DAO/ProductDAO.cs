using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class ProductDAO : DataConection
    {
        public ProductDAO() { }


        private static ProductDAO _instance;

        public static ProductDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new ProductDAO();
                return _instance;
            }
            set { _instance = value; }
        }

        public List<ProductDTO> GetAll()
        {
            DataTable _dt = new DataTable();
            string query = "select * from Product where status = 'ACT'";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<ProductDTO> list = new List<ProductDTO>();

            foreach (DataRow row in _dt.Rows)
            {
                list.Add(new ProductDTO(row));
            }

            return list;
        }
		public List<ProductDTO> GetAllStatus()
		{
			DataTable _dt = new DataTable();
			string query = "select * from Product";
			_dt = DataProvider.Instance.ExecuteQuery(query);

			List<ProductDTO> list = new List<ProductDTO>();

			foreach (DataRow row in _dt.Rows)
			{
				list.Add(new ProductDTO(row));
			}

			return list;
		}
		public DataTable GetByImportID(string id)
		{
			DataTable _dt = new DataTable();
            string query = "Select Product.ProductID, ProductName, Size, UnitPrice, ImportDetail.Quantity, IMG from Product,ImportDetail where Product.ProductID = ImportDetail.ProductID AND ImportDetail.ImportID = '"+id+"';";
			_dt = DataProvider.Instance.ExecuteQuery(query);

            return _dt;
		}
		public DataTable GetByBillID(string id)
		{
			DataTable _dt = new DataTable();
			string query = "Select Product.ProductID, ProductName, Size, UnitPrice, BillDetail.Quantity, IMG from Product,BillDetail where Product.ProductID = BillDetail.ProductID AND BillDetail.BillID = '" + id + "';";
			_dt = DataProvider.Instance.ExecuteQuery(query);

			return _dt;
		}
		public List<ProductDTO> GetAllByAmount()
		{
			DataTable _dt = new DataTable();
			string query = "select * from Product where quantity > 0 and status = 'ACT'";
			_dt = DataProvider.Instance.ExecuteQuery(query);

			List<ProductDTO> list = new List<ProductDTO>();

			foreach (DataRow row in _dt.Rows)
			{
				list.Add(new ProductDTO(row));
			}

			return list;
		}
		public bool Insert(ProductDTO productDTO)
        {
          

            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Product(ProductID, ProductName, Size, Quantity, ProductPrice, TypeID, ProducerID, Img, Color, Description, status) Values(@idProduct,@productName,@size,@quantity,@productPrice,@typeId,@producerId,@img,@color,@description,@status)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idProduct", MySqlDbType.VarString).Value = productDTO.IdProduct;
            cmd.Parameters.Add("@typeId", MySqlDbType.VarString).Value = productDTO.IdCategory;
            cmd.Parameters.Add("@productName", MySqlDbType.VarString).Value = productDTO.NameProduct;
            cmd.Parameters.Add("@size", MySqlDbType.VarString).Value = productDTO.Size;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = productDTO.Amount;
            cmd.Parameters.Add("@productPrice", MySqlDbType.Int64).Value = productDTO.Price;
            cmd.Parameters.Add("@producerId", MySqlDbType.VarString).Value = productDTO.IdProducer;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = productDTO.Image;
            cmd.Parameters.Add("@color", MySqlDbType.VarString).Value = productDTO.Color;
            cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = productDTO.Description;
            cmd.Parameters.Add("@status", MySqlDbType.VarString).Value = "ACT";
            int kq = cmd.ExecuteNonQuery();

            return kq > 0;
        }

        public bool UpdateQuantity(int quantity, string id)
        {
			string query = "select * from Product where ProductID = '"+id+"' AND status = 'ACT'";
            DataTable savedAmount = new DataTable();
            savedAmount=DataProvider.Instance.ExecuteQuery(query);

            string query_1 = string.Format("update Product set Quantity = '{0}' where ProductID = '{1}'", int.Parse(savedAmount.Rows[0]["Quantity"].ToString()) + quantity, id);
			int kq = DataProvider.Instance.ExecuteNonQuery(query_1);


			return kq > 0;
		}
        public bool Update(ProductDTO productDTO)
        {
           

            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Product set ProductName = @productName, Size = @size, Quantity = @quantity, ProductPrice = @productPrice, TypeID = @typeId, ProducerID = producerId, Img = @img, Color = @color, Description = @description where ProductID = @idProduct";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idProduct", MySqlDbType.VarString).Value = productDTO.IdProduct;
            cmd.Parameters.Add("@typeId", MySqlDbType.VarString).Value = productDTO.IdCategory;
            cmd.Parameters.Add("@productName", MySqlDbType.VarString).Value = productDTO.NameProduct;
            cmd.Parameters.Add("@size", MySqlDbType.VarString).Value = productDTO.Size;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = productDTO.Amount;
            cmd.Parameters.Add("@productPrice", MySqlDbType.Int64).Value = productDTO.Price;
            cmd.Parameters.Add("@producerId", MySqlDbType.VarString).Value = productDTO.IdProducer;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = productDTO.Image;
            cmd.Parameters.Add("@color", MySqlDbType.VarString).Value = productDTO.Color;
            cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = productDTO.Description;
            int kq = cmd.ExecuteNonQuery();


            return kq > 0;
        }
        public bool UpdateQuantity(string idProduct, int quantity)
        {
            string query = string.Format("update Product set Quantity = {1} where ProductID = '{0}'", idProduct, quantity);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            try
            {
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(ProductDTO productDTO)
        {
			Moketnoi();
			MySqlCommand cmd = new MySqlCommand();
			cmd.CommandType = CommandType.Text;
			cmd.CommandText = "update Product set Status = 'DEL' where ProductID = @idProduct";
			cmd.Connection = conn;
			cmd.Parameters.Add("@idProduct", MySqlDbType.VarString).Value = productDTO.IdProduct;
			int kq = cmd.ExecuteNonQuery();
			return kq > 0;
		}

        //public DataTable FindName(string name)
        //{
        //    DataTable _dt = new DataTable();
        //    try
        //    {
        //        string query = string.Format("select * from Product where ProductName like N'%{0}%'", name);
        //        _dt = DataProvider.Instance.ExecuteQuery(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return _dt;
        //}
        public List<ProductDTO> FilterPrice(string name)
        {
            DataTable _dt = new DataTable();
            try
            {
                if (name == "< 5000")
                {
                    string query = string.Format("select * from Product where ProductPrice between 0 and 5000 AND Status = 'ACT'");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }
                else if (name == "5000 - 10000")
                {
                    string query = string.Format("select * from Product where ProductPrice between 5000 and 10000 and Status = 'ACT'");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }
                else if (name == "> 10000")
                {
                    string query = string.Format("select * from Product where ProductPrice > 10000 AND Status = 'ACT'");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }
                else
                {
                    string query = string.Format("select * from Product where Status = 'ACT'");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<ProductDTO> list = new List<ProductDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new ProductDTO(dr));
            }

            return list;
        }

        public List<ProductDTO> FindName(string name)
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = string.Format("select * from Product where ProductName like N'%{0}%' and Status = 'ACT'", name);
                _dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<ProductDTO> list = new List<ProductDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new ProductDTO(dr));
            }

            return list;
        }

        public DataTable getCategory()
        {
            string query = string.Format("select * from Category");

            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getProducer()
        {
            string query = string.Format("select * from Producer");

            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

    }
}
