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
    public partial class Login : Form
    {
      static public  string log_login;
        public Login()
        {
            InitializeComponent();
        }

        private void trainerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
// this.trainerBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet5.Sign_in". При необходимости она может быть перемещена или удалена.
            this.sign_inTableAdapter.Fill(this.sportDataSet5.Sign_in);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet4.Sign_in". При необходимости она может быть перемещена или удалена.
           // this.sign_inTableAdapter.Fill(this.sportDataSet4.Sign_in);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet3.Sign_in". При необходимости она может быть перемещена или удалена.
           // this.sign_inTableAdapter.Fill(this.sportDataSet3.Sign_in);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet2.Sign". При необходимости она может быть перемещена или удалена.
            //this.signTableAdapter.Fill(this.sportDataSet2.Sign);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet1.Login". При необходимости она может быть перемещена или удалена.
           // this.loginTableAdapter.Fill(this.sportDataSet1.Login);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Customer". При необходимости она может быть перемещена или удалена.
          //  this.customerTableAdapter.Fill(this.sportDataSet.Customer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "sportDataSet.Trainer". При необходимости она может быть перемещена или удалена.
          //  this.trainerTableAdapter.Fill(this.sportDataSet.Trainer);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          //  this.customerBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.sportDataSet);

        }

        private void loginBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.loginBindingSource.EndEdit();
           // this.tableAdapterManager.UpdateAll(this.sportDataSet1);

        }

        private void signBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
           // this.signBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sportDataSet2);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            string pass = textBox2.Text;
            byte[] checkSum = md5.ComputeHash(Encoding.UTF8.GetBytes(pass));
            string result = BitConverter.ToString(checkSum).Replace("-", String.Empty);

            string tts = textBox1.Text;
          
           
            string a = sign_inTableAdapter.ScalarQuery(tts);

            if (result == a)
            {
                Guid id = Guid.NewGuid();
                logTableAdapter1.Insert(Convert.ToString(id),textBox1.Text,"Користувач "+ textBox1.Text + " успішно увійшов до системи",DateTime.Now);
                Menu frm = new Menu();
                log_login = textBox1.Text;
                frm.Show();
                Hide();

           }
            else
           {
                MessageBox.Show("Не вірний логін чи пароль", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBox1.Text = "";
                textBox2.Text = "";
           }

        }

        private void sign_inBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sign_inBindingSource.EndEdit();
          //  this.tableAdapterManager.UpdateAll(this.sportDataSet3);

        }

        private void sign_inBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sign_inBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.sportDataSet4);

        }

        private void sign_inBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.sign_inBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sportDataSet5);

        }

        private void користувачіToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void персоналToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
