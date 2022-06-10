using Contract.DTO;
using Lab2CLient.EmpServiceReference;
using Lab2CLient.ItemServiceReference;
using Lab2CLient.OrderServiceReference;
using Lab2CLient.PartsServiceReference1;
using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace Lab2CLient
{
    public partial class editForm : Form
    {
        private string selectedDb;
        private int id;
        public editForm(string table, int id)
        {
            
            InitializeComponent();
            tableLbl.Text = table;
            lf0.Text += id;
            this.id = id;
            selectedDb = table;
            tableInit(selectedDb);
        }
        private void tableInit(string table)
        {
            try
            {
                switch (selectedDb)
                {
                    case "Employee":

                        EmployeeServiceClient client = new EmployeeServiceClient();
                       
                        EmployeeDTO employeeDTO = new EmployeeDTO();
                        employeeDTO= client.readById(id);
                        
                        lf1.Text = "First name";
                        lf2.Text = "Last name";
                        lf3.Text = "Age";
                        lf4.Text = "Sex";
                        lf5.Text = "Phone";
                        textBox1.Visible = true; textBox1.Text = employeeDTO.FirstName;
                        textBox2.Visible = true; textBox2.Text = employeeDTO.LastName;
                        textBox3.Visible = true; textBox3.Text = employeeDTO.Age.ToString();
                        textBox4.Visible = true; textBox4.Text = employeeDTO.Sex;
                        textBox5.Visible = true; textBox5.Text = employeeDTO.Phone;
                        break;

                    case "Orders":

                        OrderServiceClient orderServiceClient = new OrderServiceClient();
                        OrderDTO order = orderServiceClient.readById(id);
                        
                        lf1.Text = "EmpNo";
                        lf2.Text = "";
                        lf3.Text = "";
                        lf4.Text = "";
                        lf5.Text = "";
                        textBox1.Visible = true; textBox1.Text = order.EmpNo.ToString();
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;

                        break;

                    case "Items":
                        ItemServiceClient itemServiceClient = new ItemServiceClient();
                        ItemDTO item = itemServiceClient.readById(id);

                        lf1.Text = "OrderNo";
                        lf2.Text = "PartNo";
                        lf3.Text = "Count";
                        lf4.Text = "";
                        lf5.Text = "";
                        textBox1.Visible = true; textBox1.Text = item.OrderNo.ToString();
                        textBox2.Visible = true; textBox2.Text = item.PartNo.ToString();
                        textBox3.Visible = true; textBox3.Text = item.Count.ToString();
                        textBox4.Visible = false;
                        textBox5.Visible = false;

                        break;

                    case "Parts":
                        PartsServiceClient partsServiceClient = new PartsServiceClient();
                        PartDTO part = partsServiceClient.readById(id);

                        lf1.Text = "Name";
                        lf2.Text = "Serial num.";
                        lf3.Text = "VendorNo";
                        lf4.Text = "";
                        lf5.Text = "";
                        textBox1.Visible = true; textBox1.Text= part.Name;
                        textBox2.Visible = true; textBox2.Text = part.SerialNum.ToString();
                        textBox3.Visible = true; textBox3.Text = part.VendorNo.ToString();
                        textBox4.Visible = false;
                        textBox5.Visible = false;

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
        private void editButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (selectedDb)
                {
                    case "Employee":

                        EmployeeServiceClient client = new EmployeeServiceClient();

                        client.update(new EmployeeDTO
                        {
                            EmpNo = id,
                            FirstName = textBox1.Text,
                            LastName = textBox2.Text,
                            Age = Convert.ToInt32(textBox3.Text),
                            Sex = textBox4.Text,
                            Phone = textBox5.Text
                        });
                        break;

                    case "Orders":

                        OrderServiceClient orderServiceClient = new OrderServiceClient();
                        orderServiceClient.update(new OrderDTO
                        {
                            OrderNo = id,
                            EmpNo = Convert.ToInt32(textBox1.Text)
                        });

                        

                        break;

                    case "Items":
                        ItemServiceClient itemServiceClient = new ItemServiceClient();
                        itemServiceClient.update(new ItemDTO
                        {
                            ItemNo = id,  
                            OrderNo = Convert.ToInt32(textBox1.Text),
                            PartNo = Convert.ToInt32(textBox2.Text),
                            Count = Convert.ToInt32(textBox3.Text)
                        });

                      

                        break;

                    case "Parts":
                        PartsServiceClient partsServiceClient = new PartsServiceClient();
                        partsServiceClient.update(new PartDTO
                        {
                            PartNo = id,
                            Name = textBox1.Text,
                            SerialNum = textBox2.Text,
                            VendorNo = Convert.ToInt32(textBox3.Text),
                        });


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
            Form1 form1 = new Form1();
            form1.Update();
            this.Close();
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                switch (selectedDb)
                {
                    case "Employee":

                        EmployeeServiceClient client = new EmployeeServiceClient();
                        client.deleteById(id);
                        break;

                    case "Orders":

                        OrderServiceClient orderServiceClient = new OrderServiceClient();
                        orderServiceClient.deleteById(id);
                        break;

                    case "Items":

                        ItemServiceClient itemServiceClient = new ItemServiceClient();
                        itemServiceClient.deleteById(id);
                        break;

                    case "Parts":

                        PartsServiceClient partsServiceClient = new PartsServiceClient();
                        partsServiceClient.deleteById(id);
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
            Form1 form1 = new Form1();
            form1.Update();
            this.Close();
        }

        private void editForm_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.editButton, "Save changed information");
            tt.SetToolTip(this.canselButton, "Close this form");
            tt.SetToolTip(this.button1, "Delete this from " + selectedDb);

            tt.SetToolTip(this.lf0, "Id of selected entry");
            tt.SetToolTip(this.tableLbl, "Selected table");

            tt.SetToolTip(this.textBox1, "Here you can input " + lf1.Text);
            tt.SetToolTip(this.textBox2, "Here you can input " + lf2.Text);
            tt.SetToolTip(this.textBox3, "Here you can input " + lf3.Text);
            tt.SetToolTip(this.textBox4, "Here you can input " + lf4.Text);
            tt.SetToolTip(this.textBox5, "Here you can input " + lf5.Text);
        }
    }
}
