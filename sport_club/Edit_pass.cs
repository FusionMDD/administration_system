using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sport_club
{
    public partial class Edit_pass : Form
    {
        public Edit_pass()
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

        private void sign_inBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sign_inBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void Edit_pass_Load(object sender, EventArgs e)
        {

            string sg = sign_inTableAdapter.ScalarQuery1(Login.log_login);
            if (sg == "admin" ) sg = "admin";
            else
            {
                MessageBox.Show("Для доступу увійдіть як адміністратор");
                Menu frm = new Menu();
                frm.Show();
                Close();


            }// TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Sign_in". При необходимости она может быть перемещена или удалена.
            this.sign_inTableAdapter.Fill(this.sportDataSet.Sign_in);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Змінити пароль?", "Зміна паролю", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                if (passwordTextBox1.Text == textBox1.Text && loginTextBox1.Text != "" && passwordTextBox1.Text != "")
            {
                MD5 md5 = new MD5CryptoServiceProvider();
                string pass = passwordTextBox1.Text;
                byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
                string result1 = BitConverter.ToString(checkSum).Replace("-", String.Empty);
                passwordTextBox1.Text = result1;

                sign_inTableAdapter.UpdateQuery(result1,ownerTextBox.Text,comboBox1.Text, loginTextBox1.Text, loginTextBox1.Text);
                    Guid id = Guid.NewGuid();
                    logTableAdapter1.Insert(Convert.ToString(id), Login.log_login, "Користувач " + Login.log_login + " успішно оновив пароль для " + loginTextBox1.Text, DateTime.Now);
                    sign_inTableAdapter.Fill(sportDataSet.Sign_in);
                textBox1.Text = "";
                passwordTextBox1.Text = "";
                loginTextBox1.Text = "";

                MessageBox.Show("Дані збережено");
            }
           
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.sign_inTableAdapter.FillBy(this.sportDataSet.Sign_in, loginToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name="";
            DialogResult result = MessageBox.Show("Видалити строку?", "Видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in sign_inDataGridView.SelectedRows)
                {
                    name = row.Cells[0].Value.ToString();
                    sign_inDataGridView.Rows.RemoveAt(row.Index);
                }

                Guid id = Guid.NewGuid();
            
                logTableAdapter1.Insert(Convert.ToString(id), Login.log_login, "Користувач " + Login.log_login + " успішно видалив акаунт  " + name, DateTime.Now);
            
                sign_inTableAdapter.Update(sportDataSet.Sign_in);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sign_inTableAdapter.Fill(sportDataSet.Sign_in);
        }

        private void ownerLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
