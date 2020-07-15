
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTi1MenaxhimiDepos.BO;
using PTi1MenaxhimiDepos.DAL.Interface;

namespace PTi1MenaxhimiDepos.DAL
{
    public class ItemRepository : ICrud<Item>,IGetObject<Item>
    {
        public bool Add(Item obj)
        {
            try
            {
                if (!DataConnection.DoesExist("sp_DoesExist_Item", "Name", obj.Name))
                {
                    int val = 0;
                    using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("sp_Insert_Item", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Barcode", obj.Barcode);
                        cmd.Parameters.AddWithValue("@Name", obj.Name);
                        cmd.Parameters.AddWithValue("@UnitID", obj.UnitID);
                        cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryId);
                        cmd.Parameters.AddWithValue("@TypeID", obj.TypeID);
                        cmd.Parameters.AddWithValue("@SupplierID", obj.SupplierID);
                        cmd.Parameters.AddWithValue("@Active", obj.Active);
                        cmd.Parameters.AddWithValue("@PurchasePrice", obj.PurchasePrice);
                        cmd.Parameters.AddWithValue("@SalePrice", obj.SalePrice);
                        cmd.Parameters.AddWithValue("@StockQuantity", obj.StockQuantity);
                        cmd.Parameters.AddWithValue("@Description", obj.Description);
                        cmd.Parameters.AddWithValue("@InsertByUsername", obj.Username);
                        val = DataConnection.GetValue(cmd);
                    }
                    return HelperClass.GetValue(val, "Register");
                }
                else
                {
                    MessageBox.Show("Item Exist!", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new Exception("Can not delete by id, try to delete by barcode");
        }

        public bool Delete(string barcode)
        {
            try
            {
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Delete_Item", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    val = DataConnection.GetValue(cmd);
                }
                return HelperClass.GetValue(val, "Delete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Item> ReadAll()
        {
            try
            {
                List<Item> dt = new List<Item>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Item", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        dt.Add(Get(sdr));
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
        public List<Item> ReadAllToday()
        {
            try
            {
                List<Item> dt = new List<Item>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetTodayRegistred_Items", CommandType.StoredProcedure);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        dt.Add(Get(sdr));
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }


        public Item ReadById(int id)
        {
            try
            {
                Item obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Item_ByBarcode", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Barcode", id);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        obj = Get(sdr);
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public bool Update(int id, Item obj)
        {
            try
            {
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_Update_Item", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemID", id);
                    cmd.Parameters.AddWithValue("@Barcode", obj.Barcode);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@UnitID", obj.UnitID);
                    cmd.Parameters.AddWithValue("@CategoryID", obj.CategoryId);
                    cmd.Parameters.AddWithValue("@TypeID", obj.TypeID);
                    cmd.Parameters.AddWithValue("@SupplierID", obj.SupplierID);
                    cmd.Parameters.AddWithValue("@Activ", obj.Active);
                    cmd.Parameters.AddWithValue("@StockQuantity", obj.StockQuantity);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@UpdateBy", obj.Username);
                    val = DataConnection.GetValue(cmd);
                }
                return HelperClass.GetValue(val, "Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }
        }

        public Item ReadByName(string name)
        {
            try
            {
                Item obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Item_ByName", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Name", name);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        obj = Get(sdr);
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Item ReadByBarcode(string barcode)
        {
            try
            {
                Item obj = null;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Item_ByBarcode", CommandType.StoredProcedure);
                    DataConnection.AddParameter(cmd, "@Barcode", barcode);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        obj = Get(sdr);
                    }
                }
                return obj;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public Item Get(SqlDataReader sdr)
        {
            Item obj = new Item(int.Parse(sdr["ITEMID"].ToString()),sdr["BARCODE"].ToString(), sdr["NAME"].ToString(),bool.Parse(sdr["ACTIV"].ToString()), 
                double.Parse(sdr["PURCHASEPRICE"].ToString()),double.Parse(sdr["SALEPRICE"].ToString()),int.Parse(sdr["STOCKQUANTITY"].ToString()), sdr["DESCRIPTION"].ToString());
            obj.Category = new ItemCategory(sdr["CATEGORY"].ToString());
            obj.Type = new ItemType(sdr["TYPE"].ToString());
            obj.Supplier = new Supplier(sdr["SUPPLIER"].ToString());
            obj.Unit = new ItemUnit(sdr["UNIT"].ToString());
            return obj;
        }

        public List<Item> ReadAllLike(string name)
        {
            try
            {
                List<Item> dt = new List<Item>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Item_Like", CommandType.StoredProcedure);
                    cmd.Parameters.AddWithValue("@Name", name);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        dt.Add(Get(sdr));
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public List<Item> ReadAllByBarcodeLike(string barcode)
        {
            try
            {
                List<Item> dt = new List<Item>();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    var cmd = DataConnection.Command(con, "sp_GetAll_Item_ByBarcodeLike", CommandType.StoredProcedure);
                    cmd.Parameters.AddWithValue("@Barcode", barcode);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    while (sdr.Read())
                    {
                        dt.Add(Get(sdr));
                    }
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
