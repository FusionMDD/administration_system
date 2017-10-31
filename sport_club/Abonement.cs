using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sport_club
{
    public partial class Abonement : Form
    {
        public Abonement()
        {
            InitializeComponent();
        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainer_viev frm = new Trainer_viev();
            frm.Show();
            Close();
        }

        private void користувачіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainer_viev frm = new Trainer_viev();
            frm.Show();
            Close();
        }

        private void інвентарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_view frm = new Inventory_view();
            frm.Show();
            Close();
        }

        private void тренуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Training_view frm = new Training_view();
            frm.Show();
            Close();
        }

        private void новийПрацівникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_trainer frm = new add_trainer();
            frm.Show();
            Close();
        }

        private void редагуванняПрацівниківToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_trainer frm = new edit_trainer();
            frm.Show();
            Close();
        }

        private void розподілНавантаженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Navantagh frm = new Navantagh();
            frm.Show();
            Close();
        }

        private void пошукПрацівникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Trainer_search frm = new Trainer_search();
            frm.Show();
            Close();
        }

        private void новийКлієнтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_user frm = new add_user();
            frm.Show();
            Close();
        }

        private void редагуванняКлієнтівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_user frm = new edit_user();
            frm.Show();
            Close();
        }

        private void пошукКлієнтаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User_search frm = new User_search();
            frm.Show();
            Close();
        }

        private void статусАбонементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abonement frm = new Abonement();
            frm.Show();
            Close();
        }

        private void новеСпорядженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_inventory frm = new add_inventory();
            frm.Show();
            Close();
        }

        private void редагуванняСпорядженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_inv frm = new edit_inv();
            frm.Show();
            Close();
        }

        private void пошукСпорядженняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventory_search frm = new Inventory_search();
            frm.Show();
            Close();
        }

        private void переглядОбліковихЗаписівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pass_view frm = new pass_view();
            frm.Show();
            Close();
        }

        private void змінаПаролюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edit_pass frm = new Edit_pass();
            frm.Show();
            Close();
        }

        private void новийКористувачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_pass frm = new add_pass();
            frm.Show();
            Close();
        }

        private void менюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void доToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }

        private void редагуватиТренуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit_training frm = new edit_training();
            frm.Show();
            Close();
        }

        private void пошукТренуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            search_training frm = new search_training();
            frm.Show();
            Close();
        }

        private void новеТренуванняToolStripMenuItem_Click(object sender, EventArgs e)
        {
            add_training frm = new add_training();
            frm.Show();
            Close();
        }

        private void Abonement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.sportDataSet.DataTable1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DateTime endDate = DateTime.Now;
            
            if (checkBox1.Checked == true)
            {
                DateTime stDate = endDate.AddDays(7);

                dataTable1TableAdapter.FillBy(sportDataSet.DataTable1, Convert.ToString( endDate), Convert.ToString(stDate));

            }
            if (checkBox2.Checked == true)
            {
                DateTime stDate = endDate.AddDays(14);
                dataTable1TableAdapter.FillBy(sportDataSet.DataTable1, Convert.ToString(endDate), Convert.ToString(stDate));



            }
            if (checkBox3.Checked == true)
            {
                DateTime stDate = endDate.AddDays(31);
                dataTable1TableAdapter.FillBy(sportDataSet.DataTable1, Convert.ToString(endDate), Convert.ToString(stDate));


            }
            if (checkBox4.Checked == true)
            {
                DateTime stDate = endDate.AddDays(-31);
                dataTable1TableAdapter.FillBy(sportDataSet.DataTable1, Convert.ToString(stDate), Convert.ToString(endDate));



            }
            if (checkBox5.Checked == true)
            {
                DateTime stDate = endDate.AddDays(-31);
                endDate = endDate.AddYears(-1);
                dataTable1TableAdapter.FillBy(sportDataSet.DataTable1, Convert.ToString(stDate), Convert.ToString(endDate));


            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
            }

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
        }

        private void менюToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            Close();
        }
    }
}
