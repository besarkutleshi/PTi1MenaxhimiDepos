using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using PTi1MenaxhimiDepos.DAL;
using System.Data;
using System.Windows.Forms;
namespace PTi1MenaxhimiDepos.BL
{
    public class ItemBLL
    {
        static ItemCategoriesRepository itemCategories = new ItemCategoriesRepository();
        static ItemTypeRepository ItemType = new ItemTypeRepository();
        static ItemUnitRepository ItemUnit = new ItemUnitRepository();
        static ItemRepository Item = new ItemRepository();

        #region CategoryRegion
        public static List<ItemCategory> GetCategories()
        {
            return itemCategories.ReadAll();
        }

        public static ItemCategory GetItemCategory(int id)
        {
            return itemCategories.ReadById(id);
        }

        public static ItemCategory GetItemCategory(string name)
        {
            return itemCategories.ReadByName(name);
        }
        public static bool InsertCategory(ItemCategory category)
        {
            return itemCategories.Add(category);
        }

        public static bool DeleteCategory(int id)
        {
            return itemCategories.Delete(id);
        }
        public static bool UpdateCategory(int id,ItemCategory category)
        {
            return itemCategories.Update(id, category);
        }

        #endregion

        #region TypeRegion

        public static List<ItemType> GetItemTypes()
        {
            return ItemType.ReadAll();
        }

        public static ItemType GetItemType(int id)
        {
            return ItemType.ReadById(id);
        }

        public static bool InsertItemType(ItemType type)
        {
            return ItemType.Add(type);
        }

        public static bool DeleteItemType(int id)
        {
            return ItemType.Delete(id);
        }

        public static bool UpdateItemType(int id,ItemType type)
        {
            return ItemType.Update(id, type);
        }

        public static ItemType GetItemType(string name)
        {
            return ItemType.ReadByName(name);
        }

        #endregion

        #region UnitRegion
        public static List<ItemUnit> GetItemUnits()
        {
            return ItemUnit.ReadAll();
        }

        public static ItemUnit GetUnit(int id)
        {
            return ItemUnit.ReadById(id);
        }

        public static ItemUnit GetUnit(string name)
        {
            return ItemUnit.ReadByName(name);
        }

        public static bool InsertUnitType(ItemUnit type)
        {
            return ItemUnit.Add(type);
        }

        public static bool DeleteUnitType(int id)
        {
            return ItemUnit.Delete(id);
        }

        public static bool UpdateUnitType(int id, ItemUnit type)
        {
            return ItemUnit.Update(id, type);
        }
        #endregion

        #region Items

        public static List<Item> GetItems()
        {
            return Item.ReadAll();
        }

        public static List<Item> GetItems(string item) => Item.ReadAllLike(item);

        public static List<Item> GetTodayItems() => Item.ReadAllToday();

        public static List<Item> GetItemsByBarcode(string barcode) => Item.ReadAllByBarcodeLike(barcode);

        public static bool InsertItem(Item obj)
        {
            return Item.Add(obj);
        }

        public static Item GetItem(int id)
        {
            return Item.ReadById(id);
        }

        public static bool DeleteItem(string barcode)
        {
            return Item.Delete(barcode);
        }

        public static bool UpdateItem(int id, Item obj)
        {
            return Item.Update(id, obj);
        }

        public static Item GetItemByName(string name)
        {
            return Item.ReadByName(name);
        }

        #endregion

        public static DataTable ConvertToDataTableItems(List<Item> rows)
        {
            try
            {
                DataTable dataTable = new DataTable(typeof(Item).Name);
                System.Reflection.PropertyInfo[] Props = typeof(Item).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
                foreach (System.Reflection.PropertyInfo item in Props)
                {
                    if (item.Name == "UnitID" || item.Name == "CategoryId" || item.Name == "TypeID" || item.Name == "SupplierID" || item.Name == "Username")
                    {
                        continue;
                    }
                    dataTable.Columns.Add(item.Name);
                }
                foreach (var item in rows)
                {
                    if(item == null)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        object[] values = new object[10];
                        values[0] = item.ID;
                        values[1] = item.Barcode;
                        values[2] = item.Name;
                        values[3] = item.Unit.Name;
                        values[4] = item.Category.Name;
                        values[5] = item.Type.Name;
                        values[6] = item.Supplier.Name;
                        values[7] = item.Active;
                        values[8] = item.StockQuantity;
                        values[9] = item.Description;
                        dataTable.Rows.Add(values);
                    }
                }
                return dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Nothing to show", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return null;
            }
        }
        

    }
}
