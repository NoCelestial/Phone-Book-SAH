using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Phone_Book_SAH
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlCommand cmd = new SqlCommand();
        CurrencyManager cr;
        string sd;
        string d;
        int before;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename= F:\visual projeckt\Phone Book SAH\Phone Book SAH\Phonebook.mdf;Integrated Security=True";
            conn.Open();
            Filldb();
            btnsave.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.ShowDialog();
        }

        private void Filldb(string s = "SELECT * FROM userinfophone ")
        {

            cmd.CommandText = s;
            cmd.Connection = conn;
            sda.SelectCommand = cmd;
            ds.Clear();
            sda.Fill(ds, "T1");
            dgvdb.DataBindings.Clear();
            dgvdb.DataBindings.Add("datasource", ds, "T1");
            txtfiler(txtfirstname, "T1.name");
            txtfiler(txtlastname, "T1.family");
            txtfiler(txttelphone, "T1.phone");
            txtfiler(txtadress, "T1.adress");
            cr = (CurrencyManager)this.BindingContext[ds, "T1"];
        }

        private void txtfiler(TextBox d, string s)
        {
            d.DataBindings.Clear();
            d.DataBindings.Add("text", ds, s);

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            cr.Position++;
        }

        private void btnper_Click(object sender, EventArgs e)
        {
            cr.Position--;
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            cr.Position = cr.Count;
        }

        private void btnfirst_Click(object sender, EventArgs e)
        {
            cr.Position = 0;
        }

        private void btnsnsde(object sender, EventArgs e)
        {
            TextBox[] txtboxs = new TextBox[4];
            txtboxs[0] = txtfirstname;
            txtboxs[1] = txtlastname;
            txtboxs[2] = txttelphone;
            txtboxs[3] = txtadress;
            Button[] buttns = new Button[4];
            buttns[0] = btnnew;
            buttns[1] = btnsave;
            buttns[2] = btnedit;
            buttns[3] = btndel;
            switch (((Control)sender).Text)
            {
                case "New":
                    btnsave.Text = "Save";
                    foreach (TextBox a in txtboxs)
                    {
                        a.Clear();
                        a.ReadOnly = false;
                    }
                    txtfirstname.Focus();
                    foreach (Button a in buttns)
                    {
                        if (a.Text == "Save")
                            a.Enabled = true;
                        else
                            a.Enabled = false;
                    }
                    break;

                case "Save":
                    SqlCommand insert = new SqlCommand();
                    insert.CommandText = "INSERT INTO userinfophone VALUES(@p1 , @p2 , @p3 , @p4)";
                    insert.Connection = conn;
                    int i = 1;
                    foreach (TextBox a in txtboxs)
                    {
                        string p = "p" + i.ToString();
                        insert.Parameters.AddWithValue(p, txtboxs[i - 1].Text);
                        i += 1;
                        a.ReadOnly = true;
                    }
                    insert.ExecuteNonQuery();
                    Filldb();
                    foreach (Button a in buttns)
                    {
                        if (a.Text != "Save")
                            a.Enabled = true;
                        else
                            a.Enabled = false;
                    }
                    break;

                case "Delete":
                    DialogResult x;
                    x = MessageBox.Show("Do You Want Delete \n FirstName : " + txtfirstname.Text + " \n LastName : " + txtlastname.Text + " Phone Number : " + txttelphone.Text, "Warning Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (x == DialogResult.Yes)
                    {
                        SqlCommand del = new SqlCommand();
                        del.CommandText = "DELETE FROM userinfophone WHERE phone = @p1";
                        del.Connection = conn;
                        //txttelphone.ReadOnly = false;
                        del.Parameters.AddWithValue("p1", txttelphone.Text);
                        del.ExecuteNonQuery();
                        Filldb();
                    }
                    else
                        Filldb();
                    foreach (Button a in buttns)
                    {
                        if (a.Text != "Save")
                            a.Enabled = true;
                        else
                            a.Enabled = false;
                    }
                    Filldb();
                    break;

                case "Edit":
                    foreach (TextBox a in txtboxs)
                        if (a.Name == "txttelphone")
                            a.ReadOnly = true;
                        else
                            a.ReadOnly = false;
                    foreach (Button a in buttns)
                    {
                        if (a.Text == "Save")
                        {
                            a.Enabled = true;
                            btnsave.Text = "Aplye";
                            txtfirstname.Focus();
                        }
                        else
                            a.Enabled = false;
                    }
                    before = cr.Position;
                    break;

                case "Rescue":
                    foreach (Button a in buttns)
                        if (a.Text != "Save" && a.Text != "Aplye")
                            a.Enabled = true;
                        else
                            a.Enabled = false;
                    btnsave.Text = "Save";
                    break;

                case "Aplye":
                    DialogResult t;
                    t = MessageBox.Show("Do You Want Edit It ? " + "\n FirstName : " + txtfirstname.Text + "\n LastName : " + txtlastname.Text + "\n Adress : " + txtadress.Text, "Edit Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (t == DialogResult.Yes)
                    {
                        SqlCommand update = new SqlCommand();
                        update.CommandText = "UPDATE userinfophone SET name=@p1 , family=@p2,Adress=@p3 WHERE phone= @p4;";
                        update.Connection = conn;

                        update.Parameters.AddWithValue("p1", txtfirstname.Text);
                        update.Parameters.AddWithValue("p2", txtlastname.Text);
                        update.Parameters.AddWithValue("p3", txtadress.Text);
                        update.Parameters.AddWithValue("p4", txttelphone.Text);
                        update.ExecuteNonQuery();
                        btnsave.Text = "Save";
                    }
                    else
                    {
                        Filldb();
                        
                    }
                    foreach (Button a in buttns)
                        if (a.Text == "Aplye")
                        {
                            a.Enabled = false;
                            a.Text = "Save";
                        }
                        else
                            a.Enabled = true;
                    Filldb();
                    cr.Position = before;
                    break;
            }


        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string a;
            switch (comboBox1.Text)
            {
                case ("First Name"):
                    sd = "name";
                    break;
                case ("Last Name"):
                    sd = "family";
                    break;
                case ("Adress"):
                    sd = "Adress";
                    break;
                case ("TelPhone"):
                    sd = "phone";
                    
                    break;
            }
            a = "SELECT * FROM userinfophone WHERE " + sd + " LIKE N'%" + textBox1.Text + "%' ;";
            //MessageBox.Show(a);
            Filldb(a);
        }

        private void dgvdb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            cr.Position = e.RowIndex;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            btnsearch_Click(null, null);
        }
    }
}