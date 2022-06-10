using Contract.DTO;
using Lab2CLient.EmpServiceReference;
using Lab2CLient.ItemServiceReference;
using Lab2CLient.OrderServiceReference;
using Lab2CLient.PartsServiceReference1;
using System;
using System.Windows.Forms;

namespace Lab2CLient
{
    public partial class AddForm : Form
    { 
        private int selectedDb;
        public AddForm(int table)
        {
            InitializeComponent();

            selectedDb = table;
            comboBox1.SelectedIndex = selectedDb;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (selectedDb)
                {
                    case 0:
                        {
                            EmployeeDTO ed = new EmployeeDTO
                            {
                                FirstName = textBox1.Text,
                                LastName = textBox2.Text,
                                Age = Convert.ToInt32(textBox3.Text),
                                Sex = textBox4.Text,
                                Phone = textBox5.Text
                            };

                            EmployeeServiceClient client = new EmployeeServiceClient();
                            client.create(ed);
                        }
                
                       break;

                    case 1:
                        {
                            OrderDTO oo = new OrderDTO
                            {
                                EmpNo = Convert.ToInt32(textBox1.Text)
                            };

                            OrderServiceClient client = new OrderServiceClient();
                            client.create(oo);
                        }
                        break;

                    case 2:
                        {
                            ItemDTO id = new ItemDTO
                            {
                                OrderNo = Convert.ToInt32(textBox1.Text),
                                PartNo = Convert.ToInt32(textBox2.Text),
                                Count = Convert.ToInt32(textBox3.Text)
                            };

                            ItemServiceClient client = new ItemServiceClient();
                            client.create(id);
                        }
                        break;

                    case 3:
                        {
                            PartDTO pd = new PartDTO
                            {
                                Name = textBox1.Text,
                                SerialNum = textBox2.Text,
                                VendorNo = Convert.ToInt32(textBox3.Text)
                            };

                            PartsServiceClient client = new PartsServiceClient();
                            client.create(pd);
                        }
                        break;
                    default:
                        MessageBox.Show("Something went wrong");
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Something went WRONG");
            }
            Form1 ownerForm = (Form1)this.Owner;
            ownerForm.update();
            this.Close();
        }

        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedDb = comboBox1.SelectedIndex;
            try
            {
                switch (selectedDb)
                {
                    case 0:

                        lf1.Text = "First name";
                        lf2.Text = "Last name";
                        lf3.Text = "Age";
                        lf4.Text = "Sex";
                        lf5.Text = "Phone";
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        break;

                    case 1:

                        lf1.Text = "EmpNo";
                        lf2.Text = "";
                        lf3.Text = "";
                        lf4.Text = "";
                        lf5.Text = "";
                        textBox1.Visible = true;
                        textBox2.Visible = false;
                        textBox3.Visible = false;
                        textBox4.Visible = false;
                        textBox5.Visible = false;

                        break;

                    case 2:

                        lf1.Text = "OrderNo";
                        lf2.Text = "PartNo";
                        lf3.Text = "Count";
                        lf4.Text = "";
                        lf5.Text = "";
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = false;
                        textBox5.Visible = false;

                        break;

                    case 3:

                        lf1.Text = "Name";
                        lf2.Text = "Serial num.";
                        lf3.Text = "VendorNo";
                        lf4.Text = "";
                        lf5.Text = "";
                        textBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
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

        private void AddForm_Load(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.addButton, "Create new entry with selected information");
            tt.SetToolTip(this.canselButton, "Close this form");

            tt.SetToolTip(this.comboBox1, "Database`s tables");

            tt.SetToolTip(this.textBox1, "Here you can input " + lf1.Text);
            tt.SetToolTip(this.textBox2, "Here you can input " + lf2.Text);
            tt.SetToolTip(this.textBox3, "Here you can input " + lf3.Text);
            tt.SetToolTip(this.textBox4, "Here you can input " + lf4.Text);
            tt.SetToolTip(this.textBox5, "Here you can input " + lf5.Text);
        }
    }
}
