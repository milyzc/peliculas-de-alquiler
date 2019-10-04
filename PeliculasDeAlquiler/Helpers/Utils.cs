using PeliculasDeAlquiler.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliculasDeAlquiler.Helpers
{
    public class Utils
    {
        public static void CargarCombo(ref ComboBox combo, DataTable datosDT, string valueMember, string displayMember)
        {
            combo.ValueMember = valueMember;
            combo.DisplayMember = displayMember;
            combo.DataSource = datosDT;
        }


        public static void CargarListBox(ref ListBox combo, DataTable datosDT, string valueMember, string displayMember)
        {
            combo.ValueMember = valueMember;
            combo.DisplayMember = displayMember;
            combo.DataSource = datosDT;
        }

        public static void Set(ref ListBox combo, int value)
        {
            var datos = combo.Items;
            DataRowView seleccionado = null;
            foreach (DataRowView item in datos)
            {
                if (int.Parse(item.Row.ItemArray[0].ToString()) == value)
                    seleccionado = item;
            }
            combo.SelectedItem = seleccionado;
        }


        public static void Set(ref ComboBox combo, int value)
        {
            var datos = combo.Items;
            DataRowView seleccionado = null;
            foreach (DataRowView item in datos)
            {
                if (int.Parse(item.Row.ItemArray[0].ToString()) == value)
                    seleccionado = item;
            }
            combo.SelectedItem = seleccionado;
        }

    }
}
