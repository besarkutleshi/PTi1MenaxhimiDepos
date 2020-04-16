using PTi1MenaxhimiDepos.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PTi1MenaxhimiDepos.DAL;
using System.Data;

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

        #endregion

        #region UnitRegion
        public static List<ItemUnit> GetItemUnits()
        {
            return ItemUnit.ReadAll();
        }

        public static ItemUnit GetUnitType(int id)
        {
            return ItemUnit.ReadById(id);
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

        public static bool InsertItem(Item obj)
        {
            return Item.Add(obj);
        }

        public static Item GetItem(int id)
        {
            return Item.ReadById(id);
        }

        public static bool DeleteItem(int id)
        {
            return Item.Delete(id);
        }

        public static bool UpdateItem(int id, Item type)
        {
            return Item.Update(id, type);
        }

        public static DataTable ConvertToDataTable(List<Item> rows)
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
                object[] values = new object[9];
                values[0] = item.Barcode;
                values[1] = item.Name;
                values[2] = item.Category.Name;
                values[3] = item.Type.Name;
                values[4] = item.Unit.Name;
                values[5] = item.Supplier.Name;
                values[6] = item.Active;
                values[7] = item.StockQuantity;
                values[8] = item.Description;
                dataTable.Rows.Add(values);
            }

            return dataTable;
        }

        #endregion
    }
}
