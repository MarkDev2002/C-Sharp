﻿using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class SupplierBUSs
    {
        private SupplierDAOs supplierDAO;
        private List<SupplierDTOs> listSupplierDTO;
		private static SupplierBUSs instance;

		public static SupplierBUSs Instance
		{
			get { if (instance == null) instance = new SupplierBUSs(); return SupplierBUSs.instance; }
			private set { SupplierBUSs.instance = value; }
		}
		public SupplierBUSs()
        {
            supplierDAO = new SupplierDAOs();
        }
        public List<SupplierDTOs> GetList()
        {
            listSupplierDTO = new List<SupplierDTOs>();
            listSupplierDTO = supplierDAO.GetAll();

            return listSupplierDTO;
        }

    }
}
