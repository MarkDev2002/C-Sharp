using BUS;
using DAO;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Sale : Form
    {
        private BillDTO billDTO = new BillDTO();
        private BillDetailDTO billDetailDTO;
        private BillBUS billBUS = new BillBUS();
        private BillDetailBUS billDetailBUS = new BillDetailBUS();
        private List<BillDTO> billDTOs = new List<BillDTO>();
        private List<BillDetailDTO> billDetailDTOs = new List<BillDetailDTO>();
        private ProductDAO productDAO= new ProductDAO();
        private StaffDTO staff = new StaffDTO();
        public string customerID;
        public string staffID;

        public Sale(StaffDTO staffDTO)
        {
            InitializeComponent();
            lbNameStaff.Text = staffDTO.LastName +" "+staffDTO.FirstName;
            lbStaffID.Text = staffDTO.IdStaff;
            lbPhoneStaff.Text = staffDTO.Phone;
            staff = staffDTO;
            staffID = staffDTO.IdStaff;
        }


        private void label12_Click(object sender, EventArgs e)
        {
            ListStaff ls = new ListStaff(this);
            ls.Show();
        }

        private void lbNameStaff_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
            ListProduct ls = new ListProduct(this);
            ls.Show();
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int n = 0;
			if (dtgv.Rows[e.RowIndex].Cells[2].Value == null)
			{
				MessageBox.Show("Giá trị nhập không hợp lệ!");
				dtgv.Rows[e.RowIndex].Cells[2].Value = "0"; // Fix
            }
            else if (dtgv.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
			{
				if (!int.TryParse(dtgv.Rows[e.RowIndex].Cells[2].Value.ToString(), out n))
				{
					MessageBox.Show("Giá trị nhập không hợp lệ!");
					dtgv.Rows[e.RowIndex].Cells[1].Value = "0";
				}else
				if (int.Parse(dtgv.Rows[e.RowIndex].Cells[2].Value.ToString()) > int.Parse(dtgv.Rows[e.RowIndex].Cells[3].Value.ToString()))
				{
					MessageBox.Show("Số lượng mua không đủ");  // Fix
					dtgv.Rows[e.RowIndex].Cells[2].Value = "0"; // Fix
                }
                else
                {
					double subTotal = 0;

					foreach (DataGridViewRow row in dtgv.Rows)
					{
						row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
							Convert.ToDouble(row.Cells["Price"].Value);

						subTotal += double.Parse(row.Cells["Total"].Value.ToString());
						lbSubTotal.Text = subTotal.ToString();
					}
					lbTotal.Text = ((subTotal * 1.05) + 9).ToString();
				}

			}

				
			

        }

        private void dtgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

		}

		private void dtgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double subTotal = 0;
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["Price"].Value);

                subTotal += double.Parse(row.Cells["Total"].Value.ToString());
                lbSubTotal.Text = subTotal.ToString();
            }

            lbTotal.Text = ((subTotal * 1.05) + 9).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ListCustomer lc = new ListCustomer(this);
            lc.Show();

        }

        private void Sale_Load(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
			bool flag = false;
			string billOrder = billBUS.getIDBill();
			if (dtgv.Rows.Count == 0)
            {
				MessageBox.Show("Bạn chưa chọn sản phẩm ");
				return;
            }else if(String.IsNullOrEmpty(txtDeliver.Text))
			{
				MessageBox.Show("Please enter place of delivery!");
				return;
			}else if (String.IsNullOrEmpty(lbID.Text))
            {
                string id = CustomerBUS.Instance.SetAutoIDForGuest();
                CustomerBUS.Instance.AddGuest(id);
				billDTO.BillID = billOrder;
				billDTO.CustomerID = id;
				billDTO.StaffID = lbStaffID.Text;
				billDTO.Total = double.Parse(lbTotal.Text.ToString());
                billDTO.Delivery = txtDeliver.Text;
				foreach (DataGridViewRow row in dtgv.Rows)
				{

					billDetailDTOs.Add(new BillDetailDTO(billOrder,
						row.Cells["IDProduct"].Value.ToString(),
						int.Parse(row.Cells["Quantity"].Value.ToString()),
						double.Parse(row.Cells["Price"].Value.ToString())
					));

					productDAO.UpdateQuantity(row.Cells["IDProduct"].Value.ToString(),
						int.Parse(row.Cells["Inventory"].Value.ToString()) - int.Parse(row.Cells["Quantity"].Value.ToString())
						);
				}

				billBUS.Insert(billDTO.BillID, billDTO.CustomerID, billDTO.StaffID, billDTO.Total, billDTO.Delivery);

				foreach (BillDetailDTO billDetail in billDetailDTOs)
				{
					if (billDetailBUS.Insert(billDetail.BillID, billDetail.ProductID, billDetail.Quantity, billDetail.UnitPrice))
					{
						flag = true;
					}
					else
					{
						MessageBox.Show("Xu ly hoa don truoc");
					}
				}

				if (flag)
				{
					printPreviewDialog1.Document = printDocument1;
					printPreviewDialog1.ShowDialog();
					Clear();
					MessageBox.Show("Successfully!");
				}
			}
            else
            {
				billDTO.BillID = billOrder;
				billDTO.CustomerID = lbID.Text;
				billDTO.StaffID = lbStaffID.Text;
				billDTO.Total = double.Parse(lbTotal.Text.ToString());
                billDTO.Delivery = txtDeliver.Text;
				foreach (DataGridViewRow row in dtgv.Rows)
				{

					billDetailDTOs.Add(new BillDetailDTO(billOrder,
						row.Cells["IDProduct"].Value.ToString(),
						int.Parse(row.Cells["Quantity"].Value.ToString()),
						double.Parse(row.Cells["Price"].Value.ToString())
					));

					productDAO.UpdateQuantity(row.Cells["IDProduct"].Value.ToString(),
						int.Parse(row.Cells["Inventory"].Value.ToString()) - int.Parse(row.Cells["Quantity"].Value.ToString())
						);
				}

				billBUS.Insert(billDTO.BillID, billDTO.CustomerID, billDTO.StaffID, billDTO.Total, billDTO.Delivery);

				foreach (BillDetailDTO billDetail in billDetailDTOs)
				{
					if (billDetailBUS.Insert(billDetail.BillID, billDetail.ProductID, billDetail.Quantity, billDetail.UnitPrice))
					{
						flag = true;
					}
					else
					{
						MessageBox.Show("Xu ly hoa don truoc");
					}
				}

				if (flag)
				{
					printPreviewDialog1.Document = printDocument1;
					printPreviewDialog1.ShowDialog();
					Clear();
					MessageBox.Show("Successfully!");
				}
			}
			
		}

        private void printInvoice_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 30;

            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("WELCOME TO SNIT SHOP", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            string top = "DATE:" + lbDateTime.Text.PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)FontHeight+35;
            graphics.DrawString("============================================================", font, new SolidBrush(Color.Black), 20, starty + offset);
            //graphics.DrawString("Name Product\t\t\t\t\tQuantity\tPrice\tTotal", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + (int)FontHeight+5;

            foreach (DataGridViewRow row in dtgv.Rows)
            {
				graphics.DrawString("----------------------------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
				graphics.DrawString("\nName:"+row.Cells["NameProduct"].Value.ToString() + "\nAmount:" +row.Cells["Quantity"].Value.ToString() + "\nPrice:" + row.Cells["Price"].Value.ToString() + "\nTotal:" + row.Cells["Total"].Value.ToString(), new Font("Courier New", 14), new SolidBrush(Color.Black), 20, starty + offset);
                offset = offset + 105;
				graphics.DrawString("----------------------------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
				
			}



			

			offset = offset + (int)FontHeight + 5;
			graphics.DrawString("============================================================", font, new SolidBrush(Color.Black), 20, starty + offset);
			offset = offset + 35;

			graphics.DrawString("Tổng tiền: " + lbSubTotal.Text + ".00", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;

            graphics.DrawString("VAT (0.05%) ", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;

            graphics.DrawString("Tổng tiền(Bao gồm các loại thuế): " + lbTotal.Text + ".00", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;

            graphics.DrawString("============================================================", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;
            graphics.DrawString("Thanks for buying!", font, new SolidBrush(Color.Black), 20, starty + offset);
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
			this.Controls.Clear();
			this.InitializeComponent();
			lbNameStaff.Text = staff.LastName + " " + staff.FirstName;
			lbStaffID.Text = staff.IdStaff;
			lbPhoneStaff.Text = staff.Phone;
            label1.Text = "CUSTOMER: GUEST";
		}

       
        private void btnAddCus_Click_1(object sender, EventArgs e)
        {
            AddCus f = new AddCus(); // Truyền tham chiếu của form Sale vào CustomerGUI
            f.txtID.Text = CustomerBUS.Instance.SetAutoID();
            f.ShowDialog();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

		private void guna2Button1_Click(object sender, EventArgs e)
		{
            label1.Text = "CUSTOMER: GUEST";
            lbID.Text = "";
            lbName.Text = "";
            lbPhone.Text = "";
		}

        private void lbDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
