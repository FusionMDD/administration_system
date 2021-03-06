﻿using System;
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
    public partial class edit_inv : Form
    {
        public edit_inv()
        {
            InitializeComponent();
        }

        private void inventory1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.inventory1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void edit_inv_Load(object sender, EventArgs e)
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Inventory1". При необходимости она может быть перемещена или удалена.
            this.inventory1TableAdapter.Fill(this.sportDataSet.Inventory1);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Зберегти зміни?", "Збереження", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                inventory1TableAdapter.Update(sportDataSet.Inventory1);
        }

        private void стартToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void кінецьToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
           //     this.inventory1TableAdapter.FillBy(this.sportDataSet.Inventory1, invnameToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Видалити строку?","Видалення" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in inventory1DataGridView.SelectedRows)
                {
                    inventory1DataGridView.Rows.RemoveAt(row.Index);

                }
                inventory1TableAdapter.Update(sportDataSet.Inventory1);
            }
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.inventory1TableAdapter.FillBy(this.sportDataSet.Inventory1, invnameToolStripTextBox1.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            inventory1TableAdapter.Fill(sportDataSet.Inventory1);
        }
    }
}
