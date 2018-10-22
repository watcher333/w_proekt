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
    public partial class Form2 : Form
    {
        private Form1 form1;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            form1 = frm;

        }
        
        private string date_m2;
        private void date()
        {
            string words = Convert.ToString(DateTime.Now);
            char[] delimiter = words.ToCharArray();
            for (int i = 0; i < 10; i++)
            {
                date_m2 = date_m2 + delimiter[i];
            }

        }

        private bool prov1()
        {
          if(textBox1.Text=="" || textBox2.Text=="" || textBox3.Text=="")
          {
              return false;
          }
            return true;
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            comboBox7.Text = "";
            comboBox8.Text = "";
            comboBox9.Text = "";
            comboBox10.Text = "";
            comboBox11.Text = "";
            comboBox12.Text = "";
            textBox13.Text = "";
            date_m2 = "";
           
        }

        private void form2_insert(object sender, EventArgs e)
        {
            if (prov1() == true)
            {

                date();
                FbConnection myConn = new FbConnection(form1.myConnectionString);
                myConn.Open();
                FbDataAdapter da = new FbDataAdapter();
                FbTransaction myTxn = myConn.BeginTransaction();
                da.InsertCommand = new FbCommand("INSERT INTO bart(date1,kv,adress,ploshad,etash,cena,hozyaev,mat_dom,nal_balkon,nal_tel,sobstvennost,smesh_izol,san_uzel,kon_tel) Values(@date1, @kv, @adress, @ploshad, @etash, @cena, @hozyaev, @mat_dom, @nal_balkon, @nal_tel, @sobstvennost, @smesh_izol, @san_uzel, @kon_tel)", myConn, myTxn);
                da.InsertCommand.Parameters.Add("@date1", date_m2);
                da.InsertCommand.Parameters.Add("@kv", textBox1.Text);
                da.InsertCommand.Parameters.Add("@adress", textBox2.Text);
                da.InsertCommand.Parameters.Add("@ploshad", textBox3.Text);
                da.InsertCommand.Parameters.Add("@etash", textBox4.Text);
                da.InsertCommand.Parameters.Add("@cena", textBox5.Text);
                da.InsertCommand.Parameters.Add("@hozyaev", textBox6.Text);
                da.InsertCommand.Parameters.Add("@mat_dom", comboBox7.Text);
                da.InsertCommand.Parameters.Add("@nal_balkon", comboBox8.Text);
                da.InsertCommand.Parameters.Add("@nal_tel", comboBox9.Text);
                da.InsertCommand.Parameters.Add("@sobstvennost", comboBox10.Text);
                da.InsertCommand.Parameters.Add("@smesh_izol", comboBox11.Text);
                da.InsertCommand.Parameters.Add("@san_uzel", comboBox12.Text);
                da.InsertCommand.Parameters.Add("@kon_tel", textBox13.Text);
                da.InsertCommand.ExecuteNonQuery();
                myTxn.Commit();
                myConn.Close();
                clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("ВВедены не все данные");
            }
            
        }

        private void form2_komnata(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Text = "0";
                textBox1.Enabled = false;
                comboBox11.Enabled = false;
            }
            else
            {
                textBox1.Text = "";
                textBox1.Enabled = true;
                textBox6.Enabled = true;
                comboBox11.Enabled = true;
            }
        }
    }
}
