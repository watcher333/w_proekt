using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace barter
{
    public partial class Form3 : Form
    {
        private Form1 form1;
        private string sqlzapros;
        private int i;
        public Form3(Form1 frm)
        {
            InitializeComponent();
            form1 = frm;
        }

        private void variant()
        {
            FbConnection myConn = new FbConnection(form1.myConnectionString);
            myConn.Open();
            FbDataAdapter da = new FbDataAdapter();
            FbTransaction myTxn = myConn.BeginTransaction();
            da.SelectCommand = new FbCommand(sqlzapros, myConn, myTxn);
            da.SelectCommand.Parameters.Add("@cena", textBox1.Text);
            da.SelectCommand.Parameters.Add("@kv", textBox2.Text);
            form1.ds = new DataSet();
            da.Fill(form1.ds);
            form1.dataGridView1.DataSource = form1.ds.Tables[0];
            form1.Column1.Visible = true;
            form1.dataGridView1.Columns[6].Visible = false;
            form1.ds.Tables[0].Columns[4].ColumnName = "Дата";
            form1.ds.Tables[0].Columns[3].ColumnName = "Квартира";
            form1.ds.Tables[0].Columns[2].ColumnName = "Адрес";
            form1.ds.Tables[0].Columns[1].ColumnName = "Площаль";
            form1.ds.Tables[0].Columns[0].ColumnName = "Цена";
            DataTable datatable = form1.ds.Tables[0];
            i = 0;
            foreach (DataRow datarow in datatable.Rows)
            {
                
                form1.dataGridView1.Rows[i].Cells[0].Value = Convert.ToInt32(form1.ds.Tables[0].Rows[i][0]) - Convert.ToInt32(textBox1.Text);
                i++;

            }
            
           
            myTxn.Commit();
            myConn.Close();

        }

        private void form3_variant(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Введены не все данные");
            }
            else
            {
                sqlzapros = "select cena,ploshad,adress,kv,date1,id from bart where cena>=@cena and kv=@kv;";
                variant();
                this.Close();
            }
        }
    }
}
