﻿
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
                    cmd.Parameters.AddWithValue("@StockQuantity", obj.StockQuantity);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@InsertByUsername", obj.Username);
                    val = DataConnection.GetValue(cmd);
                }
                if (val == 1)
                {
                    MessageBox.Show("Register Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Register Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
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
            try
            {
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_DeleteItem", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Barcode", id.ToString());
                    cmd.ExecuteNonQuery();
                    val = DataConnection.GetValue(cmd);
                }
                if (val == 1)
                {
                    MessageBox.Show("Delete Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Delete Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
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
                    SqlCommand cmd = new SqlCommand("sp_UpdateItem", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@ItemID", id);
                    cmd.Parameters.AddWithValue("@Barcode", obj.Barcode);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@UnitID", obj.Unit.ID);
                    cmd.Parameters.AddWithValue("@CategoryID", obj.Category.ID);
                    cmd.Parameters.AddWithValue("@TypeID", obj.Type.ID);
                    cmd.Parameters.AddWithValue("@SupplierID", obj.Supplier.ID);
                    cmd.Parameters.AddWithValue("@Active", obj.Active);
                    cmd.Parameters.AddWithValue("@StockQuantity", obj.StockQuantity);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@UpdateBy", obj.Username);
                    val = DataConnection.GetValue(cmd);
                }
                if (val == 1)
                {
                    MessageBox.Show("Register Successful", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("Register Failed", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }
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
            Item obj = new Item(sdr["BARCODE"].ToString(), sdr["NAME"].ToString(),bool.Parse(sdr["ACTIV"].ToString()), int.Parse(sdr["STOCKQUANTITY"].ToString()), sdr["DESCRIPTION"].ToString());
            obj.Category = new ItemCategory(sdr["CATEGORY"].ToString());
            obj.Type = new ItemType(sdr["TYPE"].ToString());
            obj.Supplier = new Supplier(sdr["SUPPLIER"].ToString());
            obj.Unit = new ItemUnit(sdr["UNIT"].ToString());
            return obj;
        }
    }
}
