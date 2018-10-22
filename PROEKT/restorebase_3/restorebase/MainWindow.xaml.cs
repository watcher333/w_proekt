using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;


namespace restorebase
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        list_combo list_combo;
        restore restore;
        ArrayList real_base;
        
        public MainWindow()
        {
            InitializeComponent();

            list_combo = new list_combo(srv_combo,to_combo,from_combo,date_combo,log_list,progress);   
            restore = new restore(list_combo);
            real_base = new ArrayList();
            srv_combo.SelectedItem = "";
            from_combo.SelectedItem = "";
            to_combo.SelectedItem = "";
            date_combo.SelectedItem = "";
            start_btrn.IsEnabled = false;
            stop_btrn.IsEnabled = false;
            real_base.Clear();
            real_base.Add("diskont");
            real_base.Add("uppcons");
            real_base.Add("bux");
            real_base.Add("zup");
            real_base.Add("TBGarbo");
            real_base.Add("tort");
            real_base.Add("DK");
            real_base.Add("FinPlanSep");
            real_base.Add("Garbo_Trade");
            real_base.Add("msdb");
            real_base.Add("master");
            real_base.Add("model");
            real_base.Add("tempdb");
            real_base.Add("pubs");
            real_base.Add("TorgBuh_Back");
            
        }

        private void select_srv_combo(object sender, SelectionChangedEventArgs e)
        {
            to_combo.Items.Clear();
            from_combo.Items.Clear();
            date_combo.Items.Clear();
            list_combo.list_base_combo();
        }

        private bool proverka()
        {
            int i;

           for (i = 0; i < real_base.Count; i++)
            {
                try
                {
                    if (to_combo.SelectedItem.ToString() == real_base[i].ToString())
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    log_list.Items.Add(e.Message);
                }
            }
            return true;
        }
        private void start(object sender, RoutedEventArgs e)
        {
                   if (proverka() == false)
                    {
                        log_list.Items.Add("Реальные базы не restore");
                        start_btrn.IsEnabled = false;
                        
                    }
                    else
                    {
                        start_btrn.IsEnabled = false;
                        stop_btrn.IsEnabled = true;
                        prv_btrn.IsEnabled = false;
                        clear_btrn.IsEnabled = false;
                        
                        
                        list_combo.unzip();
                       /* start_btrn.IsEnabled = false;
                        stop_btrn.IsEnabled = false;
                        prv_btrn.IsEnabled = true;
                        clear_btrn.IsEnabled = true;*/
                         
                        
                   }
              

        }

        private void select_from_combo(object sender, SelectionChangedEventArgs e)
        {
            date_combo.Items.Clear();
            list_combo.list_date_combo();
        }

        private void clear_list(object sender, RoutedEventArgs e)
        {
            log_list.Items.Clear();
        }

        private void stop(object sender, RoutedEventArgs e)
        {
            list_combo.stop_potok();
            start_btrn.IsEnabled = false;
            stop_btrn.IsEnabled = false;
            prv_btrn.IsEnabled = true;
            clear_btrn.IsEnabled = true;
            progress.Value = 0;
            log_list.Items.Add("Все процессы остановлены");

        }

       
        private void report_prv(object sender, RoutedEventArgs e)
        {
            if (from_combo.SelectedItem != null && to_combo.SelectedItem != null && date_combo.SelectedItem != null && srv_combo.SelectedItem != null)
            {

                start_btrn.IsEnabled = true;
                //restore.copy(srv_combo.SelectedItem.ToString(), to_combo.SelectedItem.ToString(), from_combo.SelectedItem.ToString(),date_combo.SelectedIndex);
                log_list.Items.Add(restore.print());
                srv_combo.IsEnabled = false;
                from_combo.IsEnabled = false;
                to_combo.IsEnabled = false;
                date_combo.IsEnabled = false;
            }
            else
            {
                log_list.Items.Add("Не все пункты выбраны");
            }
            
           
        }

        private void abort(object sender, RoutedEventArgs e)
        {
            srv_combo.IsEnabled = true;
            from_combo.IsEnabled = true;
            to_combo.IsEnabled = true;
            date_combo.IsEnabled = true;
            start_btrn.IsEnabled = false;
        }     
       
    }
}
