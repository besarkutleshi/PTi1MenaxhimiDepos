
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PTi1MenaxhimiDepos.BO;
namespace PTi1MenaxhimiDepos.DAL
{
    public class ItemRepository : ICrud<Item>
    {
        public bool Add(Item obj)
        {
            try
            {
                int val = 0;
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_CreateProduct", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Barcode", obj.Barcode);
                    cmd.Parameters.AddWithValue("@Name", obj.Name);
                    cmd.Parameters.AddWithValue("@UnitID", obj.Unit.ID);
                    cmd.Parameters.AddWithValue("@CategoryID", obj.Category.ID);
                    cmd.Parameters.AddWithValue("@TypeID", obj.Type.ID);
                    cmd.Parameters.AddWithValue("@SupplierID", obj.Supplier.ID);
                    cmd.Parameters.AddWithValue("@Active", obj.Active);
                    cmd.Parameters.AddWithValue("@StockQuantity", obj.StockQuantity);
                    cmd.Parameters.AddWithValue("@Description", obj.Description);
                    cmd.Parameters.AddWithValue("@InsertBy", obj.Username);
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

        public DataTable ReadAll()
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * from vw_GetAllItems", con);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }

        public DataTable ReadById(int id)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_GetItemByBarcode", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Barcode", id.ToString());
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                }
                return dt;
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

        public DataTable ReadByName(string name)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(DataConnection.Constring))
                {
                    SqlCommand cmd = new SqlCommand("sp_ReadItemByName", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
