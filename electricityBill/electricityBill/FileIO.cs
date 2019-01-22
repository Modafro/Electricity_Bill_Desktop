using CustomerData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace electricityBill
{
    /*Create various classes to create/input customer data in text file, read from text file and populate data in
    * listbox in the form
    * Author: Mo Sagnia
    * Date: 02 Jan 19
    */

    //Create a class to create and write data for customers in text file
    public static class FileIO
    {
        const string path = "Customers.txt";

        //writes data from the array to the file
        public static void WriteData(List<Customer> customers)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                //open the file for writing; overwrite old content
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);
                // write data
                foreach (Customer c in customers)
                    sw.WriteLine(c.ToFileString());

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while writing to the file: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                if (sw != null) sw.Close(); // also closes fs
            }
        }

        //create a class that reads data from the file and puts in a list and returns it
        //return number of elements
        public static List<Customer> ReadData()
        {
            List<Customer> customers = new List<Customer>();
            FileStream fs = null;
            StreamReader sr = null;
            string line; //for reading
            string[] fields; // result from splitting the line
            // open the file for reading and read numbers into data array
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while(!sr.EndOfStream) // while there is data in the file
                {
                    line = sr.ReadLine(); // read the next line
                    fields = line.Split(','); // split line into fields
                    //for new object customer created "c", Remove function is used to remove first blank space for all parameters 
                    //and remove $ sign for last parameter of new object
                    Customer c = new Customer(Convert.ToInt32(fields[0]), fields[1].Remove(0,1), Convert.ToChar(fields[2].Remove(0,1)), Convert.ToDecimal(fields[3].Remove(0,2)));
                    customers.Add(c);
                }
            }
            catch(FormatException)
            {
                MessageBox.Show("File contains bad format data. Aborting reading");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while reading the file: " + ex.Message, ex.GetType().ToString()); 
            }
            finally
            {
                //close the file if open
                if (sr != null) sr.Close(); //file stream gets closed too
            }
            return customers;
        }

        //create a class that will populate data from text file into listbox in the form
        public static decimal[] ReadCharges()
        {
            decimal[] charges = { 0, 0, 0 }; //set array that will store the total charges per customer
            FileStream fs = null;
            StreamReader sr = null;
            string line; //for reading
            string[] fields; // result from splitting the line
            // open the file for reading and read numbers into data array
            try
            {
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                while (!sr.EndOfStream) // while there is data in the file
                {
                    line = sr.ReadLine(); // read the next line
                    fields = line.Split(','); // split line into fields
                    //Remove function is used to remove first blank space for all parameters 
                    //and to remove $ sign for last parameter in fields array
                    if (Convert.ToChar(fields[2].Remove(0, 1)) == 'R')
                    {
                        charges[0] += Convert.ToDecimal(fields[3].Remove(0, 2));
                    }
                    else if (Convert.ToChar(fields[2].Remove(0, 1)) == 'C')
                    {
                        charges[1] += Convert.ToDecimal(fields[3].Remove(0, 2));
                    }
                    else
                    {
                        charges[2] += Convert.ToDecimal(fields[3].Remove(0, 2));
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("File contains bad format data. Aborting reading");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading the file: " + ex.Message, ex.GetType().ToString());
            }
            finally
            {
                //close the file if open
                if (sr != null) sr.Close(); //file stream gets closed too
            }
            return charges;
        }
    }
}
