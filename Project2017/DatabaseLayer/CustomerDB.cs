using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
//namespaces
using Project2017.BusinessLayer.Controllers;
using Project2017.BusinessLayer.Entities;

namespace Project2017.DatabaseLayer
{
    public class CustomerDB : DB
    {
        //Data members        
        private string table1 = "Customers";
        private string sqlLocal1 = "SELECT * FROM Customers";


        private Collection<Customer> customers;

        //***every column (field) in a database table has a name, data type and the datatype has a size
        //*** we will use this struct later in the workshop series
        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        //Default Constructor
        public CustomerDB() : base()
        {
            customers = new Collection<Customer>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection();

        }
        public Collection<Customer> AllCustomers
        {
            get
            {
                return customers;
            }
        }

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(Customer myCustomer, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table1].NewRow();
                    FillRow(aRow, myCustomer, operation);
                    //Add to the dataset
                    dsMain.Tables[table1].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[table1].Rows[FindRow(myCustomer)];
                    FillRow(aRow, myCustomer, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[table1].Rows[FindRow(myCustomer)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Utility Methods
        private void Add2Collection()
        {
            //Declare references to a myRow object and an Customer object
            DataRow myRow = null;
            Customer myCustomer;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table1].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Customer object
                    myCustomer = new Customer();
                    //Obtain each Customer attribute from the specific field in the row in the table
                    myCustomer.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                    myCustomer.Name = Convert.ToString(myRow["Name"]).TrimEnd();

                    if (myRow["Name"] == System.DBNull.Value)
                    {
                        myCustomer.Name = "";
                    }
                    else
                    {
                        myCustomer.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    }

                    myCustomer.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                    myCustomer.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                    myCustomer.EmailAddress = Convert.ToString(myRow["EmailAddress"]).TrimEnd();

                    customers.Add(myCustomer);
                }
            }
        }
        private void FillRow(DataRow aRow, Customer myCustomer, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["CustomerID"] = myCustomer.CustomerID;
            }
            aRow["Name"] = myCustomer.Name;
            aRow["Surname"] = myCustomer.Surname;
            aRow["Address"] = myCustomer.Address;
            aRow["EmailAddress"] = myCustomer.EmailAddress;

        }


        //The FindRow method finds the row for a specific Customer(by CustomerID)  in a specific table
        private int FindRow(Customer myCustomer)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table1].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //In c# there is no item property (but we use the 2-dim array) it is automatically known to the compiler when used as below
                    if (myCustomer.CustomerID == Convert.ToString(dsMain.Tables[table1].Rows[rowIndex]["CustomerID"]))
                    {
                        returnValue = rowIndex;
                    }
                }
                rowIndex += 1;
            }
            return returnValue;
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Customer myCustomer)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 10, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 100, "Surname");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 1, "EmailAddress");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfGuests", SqlDbType.Int , 1, "NumberOfGuests");
            daMain.InsertCommand.Parameters.Add(param);
        }


        private void Build_UPDATE_Parameters(Customer myCustomer)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@Name", SqlDbType.NVarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@Surname", SqlDbType.NVarChar, 100, "Surname");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.NVarChar, 15, "Address");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 1, "EmailAddress");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfGuests", SqlDbType.Int, 1, "NumberOfGuests");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            //testing the CustomerID of record that needs to change with the original CustomerID of the record
            param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 15, "CustomerID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(Customer myCustomer)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into Customers (CustomerID, Name, Surname, Address, EmailAddress, NumberOfGuests) VALUES (@CustomerID, @Name, @Surname, @Address, @EmailAddress, @NumberOfGuests)", cnMain);
            Build_INSERT_Parameters(myCustomer);
        }

        private void Create_UPDATE_Command(Customer myCustomer)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Customers SET Name =@Name, Surname =@Surname, Address =@Address1, EmailAddress = @EmailAddress, NumberOfGuests = @NumberOfGuests " + "WHERE CustomerID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(myCustomer);
        }

        private string Create_DELETE_Command(Customer myCustomer)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM Customers WHERE CustomerID = @CustomerID", cnMain);
            try
            {
                Build_DELETE_Parameters();
            }
            catch (Exception errObj)
            {
                errorString = errObj.Message + "  " + errObj.StackTrace;
            }
            return errorString;
        }
        public bool UpdateDataSource(Customer myCustomer)
        {
            bool success = true;
            Create_INSERT_Command(myCustomer);
            Create_UPDATE_Command(myCustomer);
            Create_DELETE_Command(myCustomer);
            success = UpdateDataSource(sqlLocal1, table1);
            return success;
        }
        #endregion

    }
}

//Assigning Values when reading from a database:
// a value representing nothing in the database).  We don't need that complexity
// so we just convert a DBNull into Nothing if we need to.
//private System.DateTime GetDBDate(object Value)
//{
//    if ((Value == DBNull.Value))
//    {
//        DateTime aDate = Convert.ToDateTime(Value = null);
//        return aDate;
//    }
//    else
//    {
//        return Convert.ToDateTime(Value);
//    }
//}
//Writing to the database:
// SetDBDate(Value) does the reverse of GetDBDate(Value), encoded as SQL
//private object SetDBDate(System.DateTime Value)
//{
//    if (Value == null)
//    {
//        return System.DBNull.Value;
//    }
//    else
//    {
//        return "#" + Value.ToShortDateString() + "#";
//    }
//}

