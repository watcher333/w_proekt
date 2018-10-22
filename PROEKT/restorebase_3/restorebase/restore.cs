using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace restorebase
{
    class  restore
    {
        string sqlzapros;
        string srv, to, from, path_base;

        list_combo list_combo;

        public restore(list_combo list_combo)
        {
            this.list_combo = list_combo;
            
        }

       
        public string print()
        {
            this.srv = list_combo.srv_combo.SelectedItem.ToString();
            this.to = list_combo.to_combo.SelectedItem.ToString();
            this.from = list_combo.from_combo.SelectedItem.ToString();
            this.path_base = @"\\192.168.0.2\temp_base$" + list_combo.path_base_zip[list_combo.date_combo.SelectedIndex].ToString().Substring(list_combo.path_base_zip[list_combo.date_combo.SelectedIndex].ToString().LastIndexOf(@"\")).Replace("zip", "bak");
            return sqlzapros;
        }
    }
}
