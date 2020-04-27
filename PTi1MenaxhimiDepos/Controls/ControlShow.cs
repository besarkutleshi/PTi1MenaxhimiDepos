using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace PTi1MenaxhimiDepos.Controls
{
    public static class ControlShow
    {
        public static Control GetButtonss(Control control, Point location, Size size, string text = null, Image img = null)
        {
            if (control is RadButton)
            {
                RadButton obj = (RadButton)control;
                obj.Image = img;
                obj.Height = 60;
                //obj.FlatAppearance.BorderSize = 1;
                //obj.FlatStyle = FlatStyle.Popup;
                obj.BackColor = Color.White;
                obj.ImageAlignment = ContentAlignment.MiddleCenter;
                obj.Cursor = Cursors.Hand;
                obj.Location = location;
                obj.Size = size;
                obj.Text = text;
                obj.Font = new Font("Microsoft San Serif", 8);
                return obj;
            }
            else if (control is RadGridView)
            {
                RadGridView obj = (RadGridView)control;
                obj.Size = size;
                obj.Location = location;
                //obj.BackgroundColor = Color.White;
                obj.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill;
                return obj;
            }
            else if (control is RadTextBox)
            {
                RadTextBox txt = (RadTextBox)control;
                txt.Text = text;
                txt.Size = size;
                //txt.ReadOnly = true;
                txt.Location = location;
                return txt;
            }
            else if(control is Label)
            {
                Label lbl = (Label)control;
                lbl.Text = text;
                lbl.Size = size;
                lbl.Location = location;
                return lbl;
            }
            return null;
        }
    }
}
