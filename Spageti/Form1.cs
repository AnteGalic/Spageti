using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;

namespace Spageti
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        Button[] btnn = new Button[10000];
        string btnName;
        SqlConnection konekcija = new SqlConnection(@"Data Source=ANTE\SQLEXPRESS;Initial Catalog=Spageti;User ID=ante;Password=ante");
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //prod_technology_linesGridControl.Visible = false;
            //prod_technologyGridControl.Visible = false;
            //ribbonControl1.Visible = false;
            //panel1.Visible = false;
            //nazivArtiklaComboBox.Visible = false;


            try
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(Progres1), false, false, true);
                DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Učitavam podatke");
                ucitajGridove();
                prod_technology_linesGridControl.Visible = true;
                prod_technologyGridControl.Visible = true;
                ribbonControl1.Visible = true;
                panel1.Visible = true;
                nazivArtiklaComboBox.Visible = true;


            }
            catch (Exception)
            {
            }
            finally
            {
                DevExpress.XtraSplashScreen.SplashScreenManager.CloseForm(false);
            }
        }
        private void ucitajGridove()
        {
            this.db_productTableAdapter.Fill(this.spagetiDataSet.db_product);
            this.prod_technologyTableAdapter.Fill(this.spagetiDataSet.prod_technology);
            this.prod_technology_linesTableAdapter.Fill(this.spagetiDataSet.prod_technology_lines);
            this.db_workcenterTableAdapter.Fill(this.spagetiDataSet.db_workcenter);
            dodajbutone();
        }
        private void lokacija()
        {

            foreach (Button buton in panel1.Controls)
            {
                var x = buton.Location.X;
                var y = buton.Location.Y;
                var xx = buton.Top - (buton.Height / 2);
                var yy = buton.Left - (buton.Width / 2);
                Graphics g;
                g = panel1.CreateGraphics();
                Pen pen = new Pen(Color.Blue, 1);
                g.DrawLine(pen, x, y, xx, yy);
                // MessageBox.Show(string.Format("Lokacija x je: {0} i y:{1} ",x.ToString(),y.ToString()));
            }
        }

        public void dodajbutone()
        {
            SqlCommand command = new SqlCommand("select * from Buton", konekcija);
            if (konekcija.State == ConnectionState.Closed)
                konekcija.Open();
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                Button buton = new Button();
                panel1.Controls.Add(buton);
                var x = (read["X"]);
                var y = (read["Y"]);
                object bojaslova = (read["BojaSlova"]);
                object bojapozadine = (read["BojaPozadine"]);
                int bs = Convert.ToInt32(bojaslova);
                int bp = Convert.ToInt32(bojapozadine);
                var sirina = (read["Width"]);
                var visina = (read["Height"]);
                buton.Anchor = (AnchorStyles.Left | AnchorStyles.Top |AnchorStyles.Right | AnchorStyles.Bottom);
                buton.Text = (read["ButonText"].ToString());
                buton.Name = (read["ButonName"].ToString());
                buton.Location = new Point(Convert.ToInt32(x), Convert.ToInt32(y));
                buton.Size = new Size(Convert.ToInt32(sirina), Convert.ToInt32(visina));
                buton.ForeColor = Color.FromArgb(bs);
                buton.BackColor = Color.FromArgb(bp);
                buton.MinimumSize =new Size(20,20);
                funkcije.Init(buton);
                buton.MouseDown += new MouseEventHandler(rClick);
                
                
                
            }
            read.Close();
        }
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forma2 fr2 = new Forma2(this);
            fr2.Show();

        }
        private void DodajNoviButon()
        {
            try
            {
                // inicijalizacija bat'na
                Button buton = new Button();
                panel1.Controls.Add(buton);
                funkcije.Init(buton);
                buton.MouseDown += new MouseEventHandler(rClick);

            }
            finally
            {

            }
        }
        private void rClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Button btn = sender as Button;
                btnName = btn.Name;
                ContextMenu contMenu = new ContextMenu();
                panel1.ContextMenu = contMenu;
                MenuItem mItem = new MenuItem();
                mItem.Click += new EventHandler(bojaPozadine);
                mItem.Text = "Pozadina";
                contMenu.MenuItems.Add(mItem);
                MenuItem mItem2 = new MenuItem();
                mItem2.Click += new EventHandler(bojaSlova);
                mItem2.Text = "Boja Slova";
                contMenu.MenuItems.Add(mItem2);
                //MenuItem mItem3 = new MenuItem();
                //mItem3.Click += new EventHandler(bojaBordera);
                //mItem3.Text = "Border";
                //contMenu.MenuItems.Add(mItem3);
                MenuItem mItem1 = new MenuItem();
                mItem1.Click += new EventHandler(izbrisiButton);
                mItem1.Text = "Izbriši Button";
                contMenu.MenuItems.Add(mItem1);

            }

        }
        private void bojaPozadine(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Name == btnName)
                    {
                        item.BackColor = cDialog.Color;
                    }
                }

            }
        }
        private void bojaSlova(object sender, EventArgs e)
        {
            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Name == btnName)
                    {
                        item.ForeColor = cDialog.Color;
                    }
                }
            }
        }
        public void bojaBordera(object sender, EventArgs e)
        {

            ColorDialog cDialog = new ColorDialog();
            if (cDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control item in panel1.Controls)
                {
                    if (item.Name == btnName)
                    {
                        //item.FlatStyle = FlatStyle.Flat;
                        //item.FlatAppearance.BorderColor = cDialog.Color;

                    }
                }
            }
        }
        private void izbrisiButton(object sender, EventArgs e)
        {
            Button buton = sender as Button;

            foreach (Button butoncic in panel1.Controls)
            {
                if (butoncic.Name == btnName)
                {
                    using (SqlCommand cmd = new SqlCommand("DELETE FROM Buton Where ButonName = @ButonName", konekcija))
                    {
                        cmd.Parameters.AddWithValue("@ButonName", butoncic.Name);
                        if (konekcija.State == ConnectionState.Closed)
                            konekcija.Open();
                        cmd.ExecuteNonQuery();
                        panel1.Controls.Remove(butoncic);
                        MessageBox.Show("Gumb je izbrisan");



                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Želite spremiti izmjene", "Poruka", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    foreach (Button buton in panel1.Controls)

                        using (SqlCommand kom = new SqlCommand("Update Buton SET ButonText = @val2,BojaSlova = @val3,BojaPozadine = @val4,X = @val5,Y = @val6,Height = @val7,Width = @val8,LocationTop = @val9,LocationLeft= @val10  where ButonName = @val1", konekcija))
                        {
                            kom.Parameters.AddWithValue("@val1", buton.Name);
                            kom.Parameters.AddWithValue("@val2", buton.Text);
                            kom.Parameters.AddWithValue("@val3", buton.ForeColor.ToArgb());
                            kom.Parameters.AddWithValue("@val4", buton.BackColor.ToArgb());
                            kom.Parameters.AddWithValue("@val5", buton.Location.X);
                            kom.Parameters.AddWithValue("@val6", buton.Location.Y);
                            kom.Parameters.AddWithValue("@val7", buton.Height);
                            kom.Parameters.AddWithValue("@val8", buton.Width);
                            kom.Parameters.AddWithValue("@val9", buton.Top - (buton.Height) / 2);
                            kom.Parameters.AddWithValue("@val10", buton.Left - (buton.Width) / 2);
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (dialogResult == DialogResult.No)
            {
                lokacija();
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((checkBox1.Checked == false))
            {
                ribbonControl1.Enabled = false;
                panel1.Enabled = false;
                checkBox1.Enabled = true;
                button1.Enabled = false;
            }
            else
            {
                ribbonControl1.Enabled = true;
                panel1.Enabled = true;
                checkBox1.Enabled = true;
                button1.Enabled = true;
            }
        }

        private void gridView1_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           
            int x = gridView2.RowCount;
            string[] cell = new string[x];
            for (int i = 0; i < x; i++)
            {
                cell[i] = gridView2.GetRowCellValue(i, "operation_name").ToString();
               
            }
            var xxxx = repositoryItemLookUpEdit1.GetDataSourceRowByDisplayValue("machine_id");

            foreach (Button item in panel1.Controls)
            {     
                if (cell.Contains(item.Text))
                {
                    item.BackColor = Color.Red;
                }
            }
            //for (int i = 0; i < cell.Length; i++)
            //{

            //    if (panel1.Controls.Text = cell[i])
            //    {
            //        item.BackColor = Color.Blue;
            //    }
            //}
   

        }
    }
}

    



