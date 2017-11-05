using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project2017.DatabaseLayer;
using Project2017.BusinessLayer.Entities;

namespace Project2017.BusinessLayer.Controllers
{
    public class CustomerController
    {
        CustomerDB CustomerDB;
        Collection<Customer> Customers;   //***W3

        #region Properties
        public Collection<Customer> AllCustomers
        {
            get
            {
                return Customers;
            }
        }
        #endregion

        public CustomerController()
        {
            //***instantiate the CustomerDB object to communicate with the database
            CustomerDB = new CustomerDB();
            Customers = CustomerDB.AllCustomers;
        }

        #region Database Communication
        public void DataMaintenance(Customer myCustomer, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            CustomerDB.DataSetChange(myCustomer, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the Customer to the Collection
                    Customers.Add(myCustomer);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(myCustomer);
                    Customers[index] = myCustomer;  // replace Customer at this index with the updated Customer
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(myCustomer);  // find the index of the specific Customer in collection
                    Customers.RemoveAt(index);  // remove that Customer form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Customer Customer)
        {
            //***call the CustomerDB method that will commit the changes to the database
            return CustomerDB.UpdateDataSource(Customer);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role

        //This method receives a Customer CustomerID as a parameter; finds the Customer object in the collection of Customers and then returns this object
        public Customer Find(string CustomerID)
        {
            int index = 0;
            bool found = (Customers[index].CustomerID == CustomerID);  //check if it is the first student
            int count = Customers.Count;
            while (!(found) && (index < Customers.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (Customers[index].CustomerID == CustomerID);   // this will be TRUE if found
            }
            return Customers[index];  // this is the one!  
        }

        public bool Contains(string CustomerID)
        {
            int index = 0;
            bool found = (Customers[index].CustomerID == CustomerID);  //check if it is the first student
            int count = Customers.Count;

            while (!(found) && (index < Customers.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (Customers[index].CustomerID == CustomerID);   // this will be TRUE if found
            }

            return found; 
        }

        public int FindIndex(Customer myCustomer)
        {
            int counter = 0;
            bool found = false;
            found = (myCustomer.CustomerID == Customers[counter].CustomerID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < Customers.Count - 1)
            {
                counter += 1;
                found = (myCustomer.CustomerID == Customers[counter].CustomerID);
            }
            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        #endregion
    }
}
