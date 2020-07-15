using PTi1MenaxhimiDepos.Administration;
using PTi1MenaxhimiDepos.Collab;
using PTi1MenaxhimiDepos.Items;
using PTi1MenaxhimiDepos.POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.Languages
{
    public static class TranslateFormMultipleResource
    {
        public static void ChangeLanguages(string langCode)
        {
            foreach (Form openForm in Application.OpenForms)
            {
                TranslateFormMultipleResource.ChangeLanguage(langCode, openForm);
                foreach (var openChildForm in openForm.MdiChildren)
                {
                    TranslateFormMultipleResource.ChangeLanguage(langCode, openChildForm);
                }
            }
        }
        private static void ChangeLanguage(string lang, Form actualForm)
        {
            CultureInfo ci = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
            ComponentResourceManager resources;

            if (actualForm.GetType() == typeof(Main)) resources = new ComponentResourceManager(typeof(Main));
            else if (actualForm.GetType() == typeof(Sale.Sale)) resources = new ComponentResourceManager(typeof(Sale.Sale));
            else if (actualForm.GetType() == typeof(Role)) resources = new ComponentResourceManager(typeof(Role));
            else if (actualForm.GetType() == typeof(RoleList)) resources = new ComponentResourceManager(typeof(RoleList));
            else if (actualForm.GetType() == typeof(User)) resources = new ComponentResourceManager(typeof(User));
            else if (actualForm.GetType() == typeof(UserList)) resources = new ComponentResourceManager(typeof(UserList));
            else if (actualForm.GetType() == typeof(Employee)) resources = new ComponentResourceManager(typeof(Employee));
            else if (actualForm.GetType() == typeof(EmployeeList)) resources = new ComponentResourceManager(typeof(EmployeeList));
            else if (actualForm.GetType() == typeof(EmployeePOS)) resources = new ComponentResourceManager(typeof(EmployeePOS));
            else if (actualForm.GetType() == typeof(EmployeePOSList)) resources = new ComponentResourceManager(typeof(EmployeePOSList));
            else if (actualForm.GetType() == typeof(Supplier)) resources = new ComponentResourceManager(typeof(Supplier));
            else if (actualForm.GetType() == typeof(SupplierList)) resources = new ComponentResourceManager(typeof(SupplierList));
            else if (actualForm.GetType() == typeof(Invoices.Invoice)) resources = new ComponentResourceManager(typeof(Invoices.Invoice));
            else if (actualForm.GetType() == typeof(Invoices.InvoiceBody)) resources = new ComponentResourceManager(typeof(Invoices.InvoiceBody));
            else if (actualForm.GetType() == typeof(Invoices.InvoiceList)) resources = new ComponentResourceManager(typeof(Invoices.InvoiceList));
            else if (actualForm.GetType() == typeof(Invoices.ListInvoice)) resources = new ComponentResourceManager(typeof(Invoices.ListInvoice));
            else if (actualForm.GetType() == typeof(Invoices.ListInvoiceBodies)) resources = new ComponentResourceManager(typeof(Invoices.ListInvoiceBodies));
            else if (actualForm.GetType() == typeof(POS.POS)) resources = new ComponentResourceManager(typeof(POS.POS));
            else if (actualForm.GetType() == typeof(POS.PosList)) resources = new ComponentResourceManager(typeof(POS.PosList));
            else if (actualForm.GetType() == typeof(Sale.Payment)) resources = new ComponentResourceManager(typeof(Sale.Payment));
            else if (actualForm.GetType() == typeof(CategoryList)) resources = new ComponentResourceManager(typeof(CategoryList));
            else if (actualForm.GetType() == typeof(ItemCategory)) resources = new ComponentResourceManager(typeof(ItemCategory));
            else if (actualForm.GetType() == typeof(ItemList)) resources = new ComponentResourceManager(typeof(ItemList));
            else if (actualForm.GetType() == typeof(ItemType)) resources = new ComponentResourceManager(typeof(ItemType));
            else if (actualForm.GetType() == typeof(ItemUnit)) resources = new ComponentResourceManager(typeof(ItemUnit));
            else if (actualForm.GetType() == typeof(RegisterItem)) resources = new ComponentResourceManager(typeof(RegisterItem));
            else if (actualForm.GetType() == typeof(TypeList)) resources = new ComponentResourceManager(typeof(TypeList));
            else if (actualForm.GetType() == typeof(UnitList)) resources = new ComponentResourceManager(typeof(UnitList));

            else resources = new ComponentResourceManager(typeof(Login));

            TranslateControls(actualForm.Controls, ci, resources);

        }

        private static void TranslateControls(Control.ControlCollection controls, CultureInfo ci, ComponentResourceManager resources)
        {
            foreach (Control control in controls)
            {

                //localize c# winform current winform
                if (control.Controls.Count > 0) TranslateControls(control.Controls, ci, resources);
                if (control is ToolStrip)
                {
                    foreach (ToolStripItem item in ((ToolStrip)control).Items)
                    {
                        string text = resources.GetString(item.Name + ".Text", ci);
                        if (text != null)
                            item.Text = text;

                        ToolStripItemTranslate(item, ci, resources);

                    }
                }
                else if (control is RadGridView)
                {
                    foreach (GridViewColumn dataGridViewColumn in ((RadGridView)control).Columns)
                    {
                        string text = resources.GetString(dataGridViewColumn.Name + ".HeaderText",ci);
                        if (text != null)
                        {
                            dataGridViewColumn.HeaderText = text;
                            control.Text = text;
                        }
                    }
                }
                else
                {
                    if (control.Name == "") return;
                    string text = resources.GetString(control.Name + ".Text", ci);
                    if (text != null)
                        control.Text = text;
                }
            }
        }

        public static void ToolStripItemTranslate(ToolStripItem item, CultureInfo ci, ComponentResourceManager resources)
        {
            if (item is ToolStripMenuItem)
            {
                var menuItem = (ToolStripMenuItem)item;
                foreach (ToolStripItem toolStripItem in menuItem.DropDown.Items)
                {
                    string text = resources.GetString(toolStripItem.Name + ".Text", ci);
                    if (text != null)
                        toolStripItem.Text = text;

                    ToolStripItemTranslate(toolStripItem, ci, resources);
                }
            }
        }
    }
}
