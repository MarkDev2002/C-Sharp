using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ImportDetailBUS
    {
        private ImportDetailDAO importDetailDAO;
        private List<ImportDetailDTO> listImportDetailDTO;

        public ImportDetailBUS()
        {
            importDetailDAO = new ImportDetailDAO();
        }

        public List<ImportDetailDTO> GetList()
        {
            listImportDetailDTO = new List<ImportDetailDTO>();
            listImportDetailDTO = importDetailDAO.GetAll();
            return listImportDetailDTO;
        }
		public List<ImportDetailDTO> GetListById(string id)
		{
            return importDetailDAO.GetById(id);
		}
		public bool Insert(string importID, string productID, int quantity, double unitPrice)
        {
            return this.importDetailDAO.Insert(importID, productID,quantity, unitPrice);

        }
        public bool Delete(string importID)
        {
            return importDetailDAO.Delete(importID);
        }
    }
}
