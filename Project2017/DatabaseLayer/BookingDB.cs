using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Xml;
using System.Globalization;
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


        public string generateAVQuery(DateTime arrivalDate, DateTime departureDate, int numRooms)
        {
            string startDate=arrivalDate.ToString("dd/MM/yyyy",
                                CultureInfo.InvariantCulture);

            int duration = (int)(departureDate - arrivalDate).TotalDays;

            string s = String.Format(@"select dateadd(dd,i,CONVERT(datetime, '{0}', 103)) as The_Date
                                        , {2} - sum(NumberOfRooms) as RoomsAvailable
                                        from Bookings, IntegerTable
                                        where i between 0 and {1}
                                        and ArrivalDate <= dateadd(dd, i, CONVERT(datetime, '{0}', 103))
                                        and DepartureDate > dateadd(dd, i, CONVERT(datetime, '{0}', 103))
                                        group by i
                                        order by RoomsAvailable
                                        ",startDate,duration,numRooms);

            return s;
        }


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

            public bool roomsAV(DateTime arrivalDate, DateTime departureDate, int numberOfRoomsInHotel, int numRooms)
            {
                FillDataSetAV(generateAVQuery(arrivalDate, departureDate, numberOfRoomsInHotel), table1);
                if (dsAvailable.Tables[table1].Rows.Count == 0)
                {
                    if (numRooms < numberOfRoomsInHotel)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if (Convert.ToInt32(dsAvailable.Tables[table1].Rows[0]["RoomsAvailable"])>=numRooms)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
                        myBooking.BookingID = Convert.ToString(myRow["BookingID"]).TrimEnd();
                        myBooking.CustomerID = Convert.ToString(myRow["CustomerID"]).TrimEnd();
                        myBooking.NumberOfRooms = Convert.ToInt32(myRow["NumberOfRooms"]);
                        myBooking.ArrivalDate = Convert.ToDateTime(myRow["ArrivalDate"]);
                        myBooking.DepartureDate = Convert.ToDateTime(myRow["DepartureDate"]);
                        myBooking.DepositAmount = Convert.ToDecimal(myRow["DepositAmount"]);
                        myBooking.DepositPaid = Convert.ToBoolean(myRow["DepositPaid"]);
                        myBooking.PaymentID = Convert.ToString(myRow["PaymentID"]);

                    bookings.Add(myBooking);
                    }
                }
            }
            private void FillRow(DataRow aRow, Booking myBooking, DB.DBOperation operation)
            {

                if (operation == DB.DBOperation.Add)
                {
                    aRow["BookingID"] = myBooking.BookingID;
                }
                aRow["CustomerID"] = myBooking.CustomerID;
                aRow["NumberOfRooms"] = myBooking.NumberOfRooms;
                aRow["ArrivalDate"] = myBooking.ArrivalDate;
                aRow["DepartureDate"] = myBooking.DepartureDate;
                aRow["DepositAmount"] = myBooking.DepositAmount;
                aRow["DepositPaid"] = myBooking.DepositPaid;
                aRow["PaymentID"] = myBooking.PaymentID;

        }


            //The FindRow method finds the row for a specific Booking(by BookingID)  in a specific table
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
                        if (myBooking.BookingID == Convert.ToString(dsMain.Tables[table1].Rows[rowIndex]["BookingID"]))
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

                param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 9, "BookingID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 9, "CustomerID");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@NumberOfRooms", SqlDbType.Int, 100, "NumberOfRooms");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@ArrivalDate", SqlDbType.Date, 15, "ArrivalDate");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@DepartureDate", SqlDbType.Date, 15, "DepartureDate");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@DepositAmount", SqlDbType.Decimal, 100,"DepositAmount");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@DepositPaid", SqlDbType.Bit, 100, "DepositPaid");
                daMain.InsertCommand.Parameters.Add(param);

                param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 9, "PaymentID");
                daMain.InsertCommand.Parameters.Add(param);


        }


            private void Build_UPDATE_Parameters(Booking myBooking)
            {
                //---Create Parameters to communicate with SQL UPDATE
                SqlParameter param = default(SqlParameter);

                param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 9, "BookingID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@CustomerID", SqlDbType.NVarChar, 9, "CustomerID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@NumberOfRooms", SqlDbType.Int, 100, "NumberOfRooms");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@ArrivalDate", SqlDbType.Date, 15, "ArrivalDate");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@DepartureDate", SqlDbType.Date, 15, "DepartureDate");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@DepositAmount", SqlDbType.Decimal, 100, "DepositAmount");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@DepositPaid", SqlDbType.Bit, 100, "DepositPaid");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);

                param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 9, "PaymentID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.UpdateCommand.Parameters.Add(param);
        }

            private void Build_DELETE_Parameters()
            {
                //--Create Parameters to communicate with SQL DELETE
                SqlParameter param;
                param = new SqlParameter("@BookingID", SqlDbType.NVarChar, 15, "BookingID");
                param.SourceVersion = DataRowVersion.Original;
                daMain.DeleteCommand.Parameters.Add(param);
            }
            private void Create_INSERT_Command(Booking myBooking)
            {
                //Create the command that must be used to insert values into the Books table..
                daMain.InsertCommand = new SqlCommand("INSERT into Bookings (BookingID, CustomerID, NumberOfRooms, ArrivalDate, DepartureDate, DepositAmount, DepositPaid, PaymentID) VALUES (@BookingID, @CustomerID, @NumberOfRooms, @ArrivalDate, @DepartureDate, @DepositAmount, DepositPaid, PaymentID)", cnMain);
                Build_INSERT_Parameters(myBooking);
            }

            private void Create_UPDATE_Command(Booking myBooking)
            {
                daMain.UpdateCommand = new SqlCommand("UPDATE Bookings SET CustomerID =@CustomerID, NumberOfRooms =@NumberOfRooms, ArrivalDate =@ArrivalDate, DepartureDate = @DepartureDate, DepositAmount = @DepositAmount, DepositPaid = @DepositPaid, PaymentID = @PaymentID " + "WHERE BookingID = @Original_ID", cnMain);
                Build_UPDATE_Parameters(myBooking);
            }

            private string Create_DELETE_Command(Booking myBooking)
            {
                string errorString = null;
                //Create the command that must be used to delete values from the the appropriate table
                daMain.DeleteCommand = new SqlCommand("DELETE FROM Bookings WHERE BookingID = @BookingID", cnMain);
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
