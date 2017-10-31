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
    public partial class Navantagh : Form
    {
        public Navantagh()
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

        private void Navantagh_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet1.Trainer1". При необходимости она может быть перемещена или удалена.
            this.trainer1TableAdapter.Fill(this.sportDataSet1.Trainer1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.DataTable3". При необходимости она может быть перемещена или удалена.
            this.dataTable3TableAdapter.Fill(this.sportDataSet.DataTable3);

        }

        private void button2_Click(object sender, EventArgs e)
        {
          DateTime  endDate = dateTimePicker1.Value;
           endDate = endDate.AddDays(-1);
            dataTable3TableAdapter.FillBy(sportDataSet.DataTable3,comboBox1.Text, endDate,dateTimePicker1.Value);
            progressBar1.Maximum = 10;
            int p= dataTable3DataGridView.RowCount;
            if (dataTable3DataGridView.RowCount > 8)
            {
                p = 8;
            }
            if (Convert.ToString(dataTable3DataGridView.Rows[0].Cells[1].Value)=="")
            {
                p = 0;
            }

            progressBar1.Value = p;

            if (dataTable3DataGridView.RowCount >= 8)
            {
                pictureBox1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                MessageBox.Show(comboBox1.Text+" перегружений", "Перенавантаження");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataTable3TableAdapter.Fill(sportDataSet.DataTable3);
            pictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            progressBar1.Value = 0;

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
