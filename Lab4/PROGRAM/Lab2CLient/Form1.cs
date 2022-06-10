using Contract.DTO;
using Lab2CLient.EmpServiceReference;
using Lab2CLient.ItemServiceReference;
using Lab2CLient.OrderServiceReference;
using Lab2CLient.PartsServiceReference1;
using System;
using System.ComponentModel;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab2CLient
{
    public partial class Form1 : Form
    {
        private int selectedDb;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;        
        }

        public void update()
        {   selectedDb = comboBox1.SelectedIndex;
            switch (selectedDb)
            {
                case 0:
                    dataGridView1.DataSource = null; UpdateEmployee();
                    break;
                case 1:
                    dataGridView1.DataSource = null; UpdateOrders();
                    break;
                case 2:
                    dataGridView1.DataSource = null; UpdateItems();
                    break;
                case 3:
                    dataGridView1.DataSource = null; UpdateParts();
                    break;  

            }
        }

        private void UpdateEmployee()
        {
            EmployeeServiceClient client = new EmployeeServiceClient();
            var list = new BindingList<EmployeeDTO>(client.read().ToList());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
        }
        private void UpdateOrders()
        {
            OrderServiceClient client = new OrderServiceClient();
            var list = new BindingList<OrderDTO>(client.read().ToList());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
        }
        private void UpdateItems()
        {
            ItemServiceClient client = new ItemServiceClient();
            var list = new BindingList<ItemDTO>(client.read().ToList());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
        }
        private void UpdateParts()
        {
            PartsServiceClient client = new PartsServiceClient();
            var list = new BindingList<PartDTO>(client.read().ToList());
            var source = new BindingSource(list, null);
            dataGridView1.DataSource = source;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(selectedDb);
            addForm.Owner = this;
            addForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex.ToString())
                {
                    case "0":

                        UpdateEmployee();

                        break;

                    case "1":

                        UpdateOrders();

                        break;

                    case "2":

                        UpdateItems();

                        break;

                    case "3":

                        UpdateParts();

                        break;

                    default:
                        MessageBox.Show("Unknown table");
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            editForm ef = new editForm(comboBox1.SelectedItem.ToString(), Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            ef.Owner = this;
            ef.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Laboratory work 3\nThis aplication was created with using databases and WCF server, was added HELP by:\nGoncharenko Sergey and Shkurapet Maksim, 326st");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            ToolTip tt = new ToolTip();

            tt.AutoPopDelay = 5000;
            tt.InitialDelay = 1000;
            tt.ReshowDelay = 500;

            tt.ShowAlways = true;

            tt.SetToolTip(this.addButton, "Create ADD form");
            tt.SetToolTip(this.deleteButton, "Create Edit\\Delete form");
            tt.SetToolTip(this.comboBox1, "Database`s tables");
            

        }

        private void addButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Create a form for adding information to Database";
        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void deleteButton_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Create a form for Edit or Delete information of selected row in selected table";
        }

        private void deleteButton_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void comboBox1_MouseEnter(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "Here you can chose a needed table";

        }

        private void comboBox1_MouseLeave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
        }

        private void helpContextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file://..\\lab4\\HELP\\Help.chm");
        }   
    }
}
