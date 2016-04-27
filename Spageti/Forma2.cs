using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace Spageti
{
    public partial class Forma2 : DevExpress.XtraEditors.XtraForm
    {
        Form1 _owner;
        
        SqlConnection konekcija = new SqlConnection(@"Data Source=ANTE\SQLEXPRESS;Initial Catalog=Spageti;User ID=ante;Password=ante");
        //public Forma2()
        //{
           
        //}
        public Forma2(Form1 owner)
        {
            InitializeComponent();
            _owner = owner;
        }



        private void Forma2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'spagetiDataSet.db_workcenter' table. You can move, or remove it, as needed.
            this.db_workcenterTableAdapter.Fill(this.spagetiDataSet.db_workcenter);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Da li ste sigurni da želite dodati novi stroj?", "Poruka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DodajNoviButon();
                foreach (Button batun in _owner.panel1.Controls)
                {
                    _owner.panel1.Controls.Remove(batun);
                }
                _owner.panel1.Refresh();
                _owner.dodajbutone();
                
            }

            else if (dialogResult == DialogResult.No)
            {

            }
        }
        private void DodajNoviButon()
        {
            try
            {
                //SqlCommand command = new SqlCommand("select id from Buton", konekcija);
                //if (konekcija.State == ConnectionState.Closed)
                //    konekcija.Open();
                //SqlDataReader read = command.ExecuteReader();
                //while (read.Read())
                //{
                //   object x = (read["id"]);
                //    int xy = Convert.ToInt32(x);
                //    int xyz = xy + 1;
                //}

                //read.Close();

                //object xyz;
                //SqlCommand last = new SqlCommand("SELECT ButonName FROM Buton", konekcija);
                //if (konekcija.State == ConnectionState.Closed)
                //{
                //    konekcija.Open();
                //    xyz = last.ExecuteNonQuery();
                //    konekcija.Close();
                //}
                //else
                //{
                //    xyz = last.ExecuteNonQuery();
                //}
             //   var x = spagetiDataSet.Buton.Rows.Count;

                button2.Text = comboBox1.SelectedValue.ToString(); 
                using (SqlCommand kom = new SqlCommand("Insert into Buton (ButonName,ButonText,BojaSlova,BojaPozadine,X,Y,Height,Width,LocationTop,LocationLeft,id_workcenter)  Values(@val1,@val2,@val3,@val4,@val5,@val6,@val7,@val8,@val9,@val10,@val11)", konekcija))
                {
                 
                    kom.Parameters.AddWithValue("@val1", "btn" + comboBox1.SelectedIndex);//promjeniti u button name!!!!
                    kom.Parameters.AddWithValue("@val2", button2.Text);
                    kom.Parameters.AddWithValue("@val3", button2.ForeColor.ToArgb());
                    kom.Parameters.AddWithValue("@val4", button2.BackColor.ToArgb());
                    kom.Parameters.AddWithValue("@val5", 0);
                    kom.Parameters.AddWithValue("@val6", 0);
                    kom.Parameters.AddWithValue("@val7", button2.Height);
                    kom.Parameters.AddWithValue("@val8", button2.Width);
                    kom.Parameters.AddWithValue("@val9", button2.Top - (button2.Height) / 2);
                    kom.Parameters.AddWithValue("@val10",button2.Left - (button2.Width) / 2);
                    kom.Parameters.AddWithValue("@val11",comboBox1.SelectedIndex);
                    if (konekcija.State == ConnectionState.Closed)
                    {
                        konekcija.Open();
                        kom.ExecuteNonQuery();                        
                    }
                    else
                    {
                        kom.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                button2.Text = "";
                button2.Name = "";
                

            }
        }
        
        private void rClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                ContextMenu contMenu = new ContextMenu();
                this.ContextMenu = contMenu;
                MenuItem mItem = new MenuItem();
                mItem.Click += new EventHandler(bojaPozadine);
                mItem.Text = "Pozadina";
                contMenu.MenuItems.Add(mItem);
                MenuItem mItem2 = new MenuItem();
                mItem2.Click += new EventHandler(bojaSlova);
                mItem2.Text = "Boja Slova";
                contMenu.MenuItems.Add(mItem2);
                //MenuItem mItem3= new MenuItem();
                //mItem3.Click += new EventHandler(bojaBordera);
                //mItem3.Text = "Boja Bordera";
                //contMenu.MenuItems.Add(mItem3);
            }
        }
        private void bojaPozadine(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {         
               button2.BackColor = cDialog.Color;              
            }
        }
        private void bojaSlova(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {  
               button2.ForeColor = cDialog.Color;           
            }
        }
        public void bojaBordera(object sender, EventArgs e)
        {
            
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                button2.FlatStyle = FlatStyle.Flat;
              button2.FlatAppearance.BorderColor = cDialog.Color;   
            }
        }
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            button2.Text= comboBox1.SelectedValue.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.MouseDown += new MouseEventHandler(rClick);
        }
    }
}

