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
    public class PaymentDetailDB : DB
    {
        //Data members        
        private string table1 = "PaymentDetails";
        private string sqlLocal1 = "SELECT * FROM PaymentDetails";

        


        private Collection<PaymentDetail> paymentDetails;

        //***every column (field) in a database table has a name, data type and the datatype has a size
        //*** we will use this struct later in the workshop series
        public struct ColumnAttribs
        {
            public string myName;
            public SqlDbType myType;
            public int mySize;
        }

        //Default Constructor
        public PaymentDetailDB() : base()
        {
            paymentDetails = new Collection<PaymentDetail>();
            FillDataSet(sqlLocal1, table1);
            Add2Collection();

        }
        public Collection<PaymentDetail> AllPaymentDetails
        {
            get
            {
                return paymentDetails;
            }
        }

        public DataSet GetDataSet()
        {
            return dsMain;
        }

        #region Database Operations CRUD --- Add the object's values to the database
        public void DataSetChange(PaymentDetail myPaymentDetail, DB.DBOperation operation)
        {
            DataRow aRow = null;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[table1].NewRow();
                    FillRow(aRow, myPaymentDetail, operation);
                    //Add to the dataset
                    dsMain.Tables[table1].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    // to Edit
                    aRow = dsMain.Tables[table1].Rows[FindRow(myPaymentDetail)];
                    FillRow(aRow, myPaymentDetail, operation);
                    break;
                case DB.DBOperation.Delete:
                    //to delete
                    aRow = dsMain.Tables[table1].Rows[FindRow(myPaymentDetail)];
                    aRow.Delete();
                    break;
            }
        }
        #endregion

        #region Utility Methods

        private void Add2Collection()
        {
            //Declare references to a myRow object and an PaymentDetail object
            DataRow myRow = null;
            PaymentDetail myPaymentDetail;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table1].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new PaymentDetail object
                    myPaymentDetail = new PaymentDetail();
                    //Obtain each PaymentDetail attribute from the specific field in the row in the table
                    myPaymentDetail.PaymentID = Convert.ToString(myRow["PaymentID"]).TrimEnd();
                    myPaymentDetail.CreditCardNumber = Convert.ToString(myRow["CreditCardNumber"]).TrimEnd();
                    myPaymentDetail.ExpiryMonth = Convert.ToInt32(myRow["ExpiryMonth"]);
                    myPaymentDetail.ExpiryYear = Convert.ToInt32(myRow["ExpiryYear"]);
                    myPaymentDetail.CVC = Convert.ToString(myRow["CVC"]).TrimEnd();

                    paymentDetails.Add(myPaymentDetail);
                }
            }
        }

        private void FillRow(DataRow aRow, PaymentDetail myPaymentDetail, DB.DBOperation operation)
        {

            if (operation == DB.DBOperation.Add)
            {
                aRow["PaymentID"] = myPaymentDetail.PaymentID;
            }
            aRow["CreditCardNumber"] = myPaymentDetail.CreditCardNumber;
            aRow["ExpiryMonth"] = myPaymentDetail.ExpiryMonth;
            aRow["ExpiryYear"] = myPaymentDetail.ExpiryYear;
            aRow["CVC"] = myPaymentDetail.CVC;

        }




        //The FindRow method finds the row for a specific PaymentDetail(by PaymentID)  in a specific table
        private int FindRow(PaymentDetail myPaymentDetail)
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
                    if (myPaymentDetail.PaymentID == Convert.ToString(dsMain.Tables[table1].Rows[rowIndex]["PaymentID"]))
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
        private void Build_INSERT_Parameters(PaymentDetail myPaymentDetail)
        {
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 9, "PaymentID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardNumber", SqlDbType.NVarChar, 16, "CreditCardNumber");
            daMain.InsertCommand.Parameters.Add(param);

            //Do the same for Description & answer -ensure that you choose the right size
            param = new SqlParameter("@ExpiryMonth", SqlDbType.Int, 100, "ExpiryMonth");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@ExpiryYear", SqlDbType.Int, 100, "ExpiryYear");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CVC", SqlDbType.NVarChar, 3, "CVC");
            daMain.InsertCommand.Parameters.Add(param);
        }


        private void Build_UPDATE_Parameters(PaymentDetail myPaymentDetail)
        {
            //---Create Parameters to communicate with SQL UPDATE
            SqlParameter param = default(SqlParameter);

            param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 9, "PaymentID");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CreditCardNumber", SqlDbType.NVarChar, 16, "CreditCardNumber");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param); ;

            param = new SqlParameter("@ExpiryMonth", SqlDbType.Int, 100, "ExpiryMonth");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@ExpiryYear", SqlDbType.Int, 100, "ExpiryYear");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CVC", SqlDbType.NVarChar, 3, "CVC");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Build_DELETE_Parameters()
        {
            //--Create Parameters to communicate with SQL DELETE
            SqlParameter param;
            param = new SqlParameter("@PaymentID", SqlDbType.NVarChar, 15, "PaymentID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.DeleteCommand.Parameters.Add(param);
        }
        private void Create_INSERT_Command(PaymentDetail myPaymentDetail)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT into PaymentDetails (PaymentID, CreditCardNumber, ExpiryMonth, ExpiryYear, CVC) VALUES (@PaymentID, @CreditCardNumber, @ExpiryMonth, @ExpiryYear, @CVC)", cnMain);
            Build_INSERT_Parameters(myPaymentDetail);
        }

        private void Create_UPDATE_Command(PaymentDetail myPaymentDetail)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE PaymentDetails SET CreditCardNumber =@CreditCardNumber, ExpiryMonth =@ExpiryMonth, ExpiryYear =@ExpiryYear, CVC = @CVC " + "WHERE PaymentID = @Original_ID", cnMain);
            Build_UPDATE_Parameters(myPaymentDetail);
        }

        private string Create_DELETE_Command(PaymentDetail myPaymentDetail)
        {
            string errorString = null;
            //Create the command that must be used to delete values from the the appropriate table
            daMain.DeleteCommand = new SqlCommand("DELETE FROM PaymentDetails WHERE PaymentID = @PaymentID", cnMain);
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
        public bool UpdateDataSource(PaymentDetail myPaymentDetail)
        {
            bool success = true;
            Create_INSERT_Command(myPaymentDetail);
            Create_UPDATE_Command(myPaymentDetail);
            Create_DELETE_Command(myPaymentDetail);
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

