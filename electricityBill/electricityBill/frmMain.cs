using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace electricityBill
{
    /*Calculate electricity bill based on type of customer (Residential, Commercial, Industrial)
     * Author: Mo Sagnia
     * Date: 06 Dec 18
     */
    using CustomerData;

    public partial class frmMain : Form
    {
        List<Customer> customers = new List<Customer>(); //empty list
        decimal[] charges;
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default to Residential choice for customer type on page load
            cboCustomer.Text = "Residential";

            //make industrial text inputs invisible
            lblkWhOff.Visible = false;
            lblkWhPeak.Visible = false;
            txtkWhOff.Visible = false;
            txtkWhPeak.Visible = false;

            //read data from file (or create new file) and display
            customers = FileIO.ReadData();
            DisplayCustomers();

            //store the charges per customer in array by reading the customer.Txt
            charges = FileIO.ReadCharges();

            //focus on the input box
            txtAccountNo.Focus();
        }

        // calculate and display bill to pay
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // local declaration
            decimal kWh = 0m;           //input: kWh used for residential or commercial customers
            decimal kWhPeak = 0m;       //input: kWh used for industrial customers during peak hours
            decimal kWhOff = 0m;        //input: kWh used for industrial customers during off-peak hours         
            string customer;            //input: customer type
            char custType;              //customer type (R, C, or I)

            // obtain type of customer input from dropbox list
            customer = cboCustomer.Text;

            //assign customer type
            switch (customer)
            {
                case "Residential":
                    //focus on the input box
                    txtAccountNo.Focus();

                    //validate user input for kWh used
                    if (validator.IsProvided(txtAccountNo, "Account Number") &&
                        validator.IsNonZeroPositiveInt(txtAccountNo, "Account Number") &&
                        validator.IsProvided(txtCustomerName, "Customer Name") &&
                        validator.IsString(txtCustomerName, "Customer Name") &&
                        validator.IsProvided(txtkWh, "Residential usage") &&
                        validator.IsNonNegativeInt(txtkWh, "Residential Usage"))
                    {
                        //assign custType
                        custType = 'R';

                        //obtain input
                        kWh = Convert.ToDecimal(txtkWh.Text);

                        //create a Customer Object using data from text boxes
                        Customer c = new CustomerRes(Convert.ToInt32(txtAccountNo.Text), txtCustomerName.Text, custType, kWh);

                        //display charge amount in appropriate text box
                        txtBill.Text = c.CalculateCharge().ToString("c");

                        //add it to the list and display
                        customers.Add(c);
                        //DisplayCustomers();
                    }  
                    break;

                case "Commercial":
                    //focus on the input box
                    txtAccountNo.Focus();

                    //validate user input for kWh used
                    if (validator.IsProvided(txtAccountNo, "Account Number") &&
                        validator.IsNonZeroPositiveInt(txtAccountNo, "Account Number") &&
                        validator.IsProvided(txtCustomerName, "Customer Name") &&
                        validator.IsString(txtCustomerName, "Customer Name") &&
                        validator.IsProvided(txtkWh, "Commercial usage") &&
                        validator.IsNonNegativeInt(txtkWh, "Commercial Usage"))
                    {
                        //assign custType
                        custType = 'C';

                        //obtain input
                        kWh = Convert.ToDecimal(txtkWh.Text);

                        //create a Customer Object using data from text boxes
                        Customer c = new CustomerComm(Convert.ToInt32(txtAccountNo.Text), txtCustomerName.Text, custType, kWh);

                        //display charge amount in appropriate text box
                        txtBill.Text = c.CalculateCharge().ToString("c");

                        //add it to the list and display
                        customers.Add(c);
                        //DisplayCustomers();
                    }
                    break;

                case "Industrial":                   
                    //validate user input for kWh used
                    if (validator.IsProvided(txtAccountNo, "Account Number") &&
                        validator.IsNonZeroPositiveInt(txtAccountNo, "Account Number") &&
                        validator.IsProvided(txtCustomerName, "Customer Name") &&
                        validator.IsString(txtCustomerName, "Customer Name") &&
                        validator.IsProvided(txtkWhPeak, "Industrial peak hours usage") &&
                        validator.IsNonNegativeInt(txtkWhPeak, "Industrial peak hours usage") &&
                        validator.IsProvided(txtkWhOff, "Industrial off-peak hours usage") &&
                        validator.IsNonNegativeInt(txtkWhOff, "Industrial off-peak hours usage"))
                    {
                        //assign custType
                        custType = 'I';

                        //obtain input(s)
                        kWhPeak = Convert.ToDecimal(txtkWhPeak.Text);
                        kWhOff = Convert.ToDecimal(txtkWhOff.Text);

                        //create a Customer Object using data from text boxes
                        Customer c = new CustomerInd(Convert.ToInt32(txtAccountNo.Text), txtCustomerName.Text, custType, kWhPeak, kWhOff);

                        //display charge amount in appropriate text box
                        txtBill.Text = c.CalculateCharge().ToString("c");

                        //add it to the list and display
                        customers.Add(c);                     
                    }
                    break;

                default:
                    break;
            }
        }

        //method to display customers in listbox and required statistics
        private void DisplayCustomers()
        {
            decimal totalCharges = 0m;
            int count = 0; //initiate a count for number of customers
            lstCustomer.Items.Clear(); //start with empty list box

            //go through the list and add each product to the list box
            foreach(Customer c in customers)
            {
                lstCustomer.Items.Add(c);
                count++;
                
            }
            
            //display number of customers
            txtTotalCustomer.Text = count.ToString();

            //save new customer in file "Customers.txt"
            FileIO.WriteData(customers);

            //store the charges per customer in array by reading the customer.Txt
            charges = FileIO.ReadCharges();

            //display all relevant statistics in appropriate boxes
            txtTotalRes.Text = charges[0].ToString("c");
            txtTotalComm.Text = charges[1].ToString("c");
            txtTotalInd.Text = charges[2].ToString("c");

            //calculate and display all charges combined
            foreach(decimal chrg in charges)
            {
                totalCharges += chrg;
            }
            txtTotalAll.Text = totalCharges.ToString("c");
        }

  
        // reset the form 
        private void btnReset_Click(object sender, EventArgs e)
        {
            //erase contents of text boxes
            txtAccountNo.Text = "";
            txtCustomerName.Text = "";
            txtkWh.Text = "";
            txtBill.Text = "";
            txtkWhPeak.Text = "";
            txtkWhOff.Text = "";

            //default customer type to Residential
            cboCustomer.Text = "Residential";

            //make industrial labels and boxes invisible
            lblkWhOff.Visible = false;
            txtkWhOff.Visible = false;
            lblkWhPeak.Visible = false;
            txtkWhPeak.Visible = false;

            //make residential / commercial label and boxes visible
            lblkWh.Visible = true;
            txtkWh.Visible = true;

            //default focus to kWh input
            txtAccountNo.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); // exit the application
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCustomer.Text == "Industrial")
            {
                //make label and text invisible for commercial or residential customers
                lblkWh.Visible = false;
                txtkWh.Visible = false;

                //make label and text visible for industrial customers
                lblkWhOff.Visible = true;
                lblkWhPeak.Visible = true;
                txtkWhOff.Visible = true;
                txtkWhPeak.Visible = true;

                //focus on the input box
                txtAccountNo.Focus();

                //clear any values in bill box when selecting a new dropbox item
                txtBill.Text = "";
            }

            if((cboCustomer.Text == "Residential") || (cboCustomer.Text == "Commercial"))
            {
                //make label and text invisible for commercial or residential customers
                lblkWh.Visible = true;
                txtkWh.Visible = true;

                //make label and text visible for industrial customers
                lblkWhOff.Visible = false;
                lblkWhPeak.Visible = false;
                txtkWhOff.Visible = false;
                txtkWhPeak.Visible = false;

                //clear any values in bill box when selecting a new dropbox item
                txtBill.Text = "";

                //focus on the input box
                txtAccountNo.Focus();
            }
        }

        //add button to add customers in listbox
        private void btnAdd_Click(object sender, EventArgs e)
        {
            DisplayCustomers();
        }
    }
}
