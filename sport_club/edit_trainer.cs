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
    public partial class edit_trainer : Form
    {
        public edit_trainer()
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

        private void trainer1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trainer1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void edit_trainer_Load(object sender, EventArgs e)
        {
            string sg = sign_inTableAdapter1.ScalarQuery1(Login.log_login);
            if (sg == "admin" || sg == "moder") ;

            else
            {
                MessageBox.Show("Для доступу увійдіть як адміністратор чи модератор");
                Menu frm = new Menu();
                frm.Show();
                Close();
            }
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Trainer1". При необходимости она может быть перемещена или удалена.
            this.trainer1TableAdapter.Fill(this.sportDataSet.Trainer1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Змінити запис?", "Редагування", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                

                trainer1TableAdapter.UpdateQuery(tnameTextBox.Text, snameTextBox.Text, tspecTextBox.Text, Convert.ToString(tdateDateTimePicker.Value), tphoneTextBox.Text, temailTextBox.Text, trainer_IDTextBox.Text);
                trainer1TableAdapter.Fill(sportDataSet.Trainer1);
                MessageBox.Show("Дані збережено");
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Видалити строку?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in trainer1DataGridView.SelectedRows)
                {
                    trainer1DataGridView.Rows.RemoveAt(row.Index);

                }
                trainer1TableAdapter.Update(sportDataSet.Trainer1);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked ==true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
            }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                  checkBox1.Checked = false;
                 checkBox2.Checked = false;
            }
            }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {

                trainer1TableAdapter.FillBy(sportDataSet.Trainer1,textBox1.Text);

            }
            if (checkBox2.Checked == true)
            {

                trainer1TableAdapter.FillBy2(sportDataSet.Trainer1, textBox1.Text);

            }
            if (checkBox3.Checked == true)
            {

                trainer1TableAdapter.FillBy1(sportDataSet.Trainer1, textBox1.Text);

            }
            textBox1.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            trainer1TableAdapter.Fill(sportDataSet.Trainer1);
        }
    }
}
