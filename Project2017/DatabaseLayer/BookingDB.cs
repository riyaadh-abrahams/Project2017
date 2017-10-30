﻿using System;
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
        public class BookingDB : DB
        {
            //Data members        
            private string table1 = "Bookings";
            private string sqlLocal1 = "SELECT * FROM Bookings";


            private Collection<Booking> bookings;

            //***every column (field) in a database table has a name, data type and the datatype has a size
            //*** we will use this struct later in the workshop series
            public struct ColumnAttribs
            {
                public string myName;
                public SqlDbType myType;
                public int mySize;
            }

            //Default Constructor
            public BookingDB() : base()
            {
                bookings = new Collection<Booking>();
                FillDataSet(sqlLocal1, table1);
                Add2Collection();

            }
            public Collection<Booking> AllBookings
            {
                get
                {
                    return bookings;
                }
            }

            public DataSet GetDataSet()
            {
                return dsMain;
            }

            #region Database Operations CRUD --- Add the object's values to the database
            public void DataSetChange(Booking myBooking, DB.DBOperation operation)
            {
                DataRow aRow = null;

                switch (operation)
                {
                    case DB.DBOperation.Add:
                        aRow = dsMain.Tables[table1].NewRow();
                        FillRow(aRow, myBooking, operation);
                        //Add to the dataset
                        dsMain.Tables[table1].Rows.Add(aRow);
                        break;
                    case DB.DBOperation.Edit:
                        // to Edit
                        aRow = dsMain.Tables[table1].Rows[FindRow(myBooking)];
                        FillRow(aRow, myBooking, operation);
                        break;
                    case DB.DBOperation.Delete:
                        //to delete
                        aRow = dsMain.Tables[table1].Rows[FindRow(myBooking)];
                        aRow.Delete();
                        break;
                }
            }
            #endregion

            #region Utility Methods
            private void Add2Collection()
            {
                //Declare references to a myRow object and an Booking object
                DataRow myRow = null;
                Booking myBooking;
                foreach (DataRow myRow_loopVariable in dsMain.Tables[table1].Rows)
                {
                    myRow = myRow_loopVariable;
                    if (!(myRow.RowState == DataRowState.Deleted))
                    {
                        //Instantiate a new Booking object
                        myBooking = new Booking();
                        //Obtain each Booking attribute from the specific field in the row in the table
                        myBooking.BookingID = Convert.ToString(myRow["ID"]).TrimEnd();
                        myBooking.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                        myBooking.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                        myBooking.Address = Convert.ToString(myRow["Address"]).TrimEnd();
                        myBooking.EmailAddress = Convert.ToString(myRow["EmailAddress"]).TrimEnd();
                        myBooking.NumberOfGuests = Convert.ToInt32(myRow["NumberOfGuests"]);

                        bookings.Add(myBooking);
                    }
                }
            }
            private void FillRow(DataRow aRow, Booking myBooking, DB.DBOperation operation)
            {

                if (operation == DB.DBOperation.Add)
                {
                    aRow["ID"] = myBooking.BookingID;
                }
                aRow["Name"] = myBooking.Name;
                aRow["Surname"] = myBooking.Surname;
                aRow["Address"] = myBooking.Address;
                aRow["EmailAddress"] = myBooking.EmailAddress;
                aRow["NumberOfGuests"] = myBooking.NumberOfGuests;

            }


            //The FindRow method finds the row for a specific Booking(by ID)  in a specific table
            private int FindRow(Booking myBooking)
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
                        if (myBooking.BookingID == Convert.ToString(dsMain.Tables[table1].Rows[rowIndex]["ID"]))
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
            private void Build_INSERT_Parameters(Booking myBooking)
            {
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
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

                param = new SqlParameter("@NumberOfGuests", SqlDbType.Int, 1, "NumberOfGuests");
                daMain.InsertCommand.Parameters.Add(param);
            }


            private void Build_UPDATE_Parameters(Booking myBooking)
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

                //testing the ID of record that needs to change with the original ID of the record
                param = new SqlParameter("@Original_ID", SqlDbType.NVarChar, 15, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);
            }

            private void Build_DELETE_Parameters()
            {
                //--Create Parameters to communicate with SQL DELETE
                SqlParameter param;
                param = new SqlParameter("@ID", SqlDbType.NVarChar, 15, "ID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.DeleteCommand.Parameters.Add(param);
            }
            private void Create_INSERT_Command(Booking myBooking)
            {
                //Create the command that must be used to insert values into the Books table..
                daMain.InsertCommand = new SqlCommand("INSERT into Bookings (ID, Name, Surname, Address, EmailAddress, NumberOfGuests) VALUES (@ID, @Name, @Surname, @Address, @EmailAddress, @NumberOfGuests)", cnMain);
                Build_INSERT_Parameters(myBooking);
            }

            private void Create_UPDATE_Command(Booking myBooking)
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE Bookings SET Name =@Name, Surname =@Surname, Address =@Address1, EmailAddress = @EmailAddress, NumberOfGuests = @NumberOfGuests " + "WHERE ID = @Original_ID", cnMain);
                Build_UPDATE_Parameters(myBooking);
            }

            private string Create_DELETE_Command(Booking myBooking)
            {
                string errorString = null;
                //Create the command that must be used to delete values from the the appropriate table
                daMain.DeleteCommand = new SqlCommand("DELETE FROM Bookings WHERE ID = @ID", cnMain);
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
            public bool UpdateDataSource(Booking myBooking)
            {
                bool success = true;
                Create_INSERT_Command(myBooking);
                Create_UPDATE_Command(myBooking);
                Create_DELETE_Command(myBooking);
                success = UpdateDataSource(sqlLocal1, table1);
                return success;
            }
            #endregion

        }
    
}
