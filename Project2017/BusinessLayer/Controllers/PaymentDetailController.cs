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
    public class PaymentDetailController
    {
        PaymentDetailDB PaymentDetailDB;
        Collection<PaymentDetail> PaymentDetails;   //***W3

        #region Properties
        public Collection<PaymentDetail> AllPaymentDetails
        {
            get
            {
                return PaymentDetails;
            }
        }
        #endregion

        public PaymentDetailController()
        {
            //***instantiate the PaymentDetailDB object to communicate with the database
            PaymentDetailDB = new PaymentDetailDB();
            PaymentDetails = PaymentDetailDB.AllPaymentDetails;
        }

        #region Database Communication
        public void DataMaintenance(PaymentDetail myPaymentDetail, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            PaymentDetailDB.DataSetChange(myPaymentDetail, operation);
            //perform operations on the collection
            switch (operation)
            {
                case DB.DBOperation.Add:
                    //*** Add the PaymentDetail to the Collection
                    PaymentDetails.Add(myPaymentDetail);
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(myPaymentDetail);
                    PaymentDetails[index] = myPaymentDetail;  // replace PaymentDetail at this index with the updated PaymentDetail
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(myPaymentDetail);  // find the index of the specific PaymentDetail in collection
                    PaymentDetails.RemoveAt(index);  // remove that PaymentDetail form the collection
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(PaymentDetail PaymentDetail)
        {
            //***call the PaymentDetailDB method that will commit the changes to the database
            return PaymentDetailDB.UpdateDataSource(PaymentDetail);
        }
        #endregion

        #region Search Methods
        //This method  (function) searched through all the employess to finds onlly those with the required role

        //This method receives a PaymentDetailPaymentID as a parameter; finds the PaymentDetail object in the collection of PaymentDetails and then returns this object
        public PaymentDetail Find(string PaymentID)
        {
            int index = 0;
            bool found = (PaymentDetails[index].PaymentID ==PaymentID);  //check if it is the first student
            int count = PaymentDetails.Count;
            while (!(found) && (index < PaymentDetails.Count - 1))  //if not "this" student and you are not at the end of the list 
            {
                index = index + 1;
                found = (PaymentDetails[index].PaymentID ==PaymentID);   // this will be TRUE if found
            }
            return PaymentDetails[index];  // this is the one!  
        }

        public int FindIndex(PaymentDetail myPaymentDetail)
        {
            int counter = 0;
            bool found = false;
            found = (myPaymentDetail.PaymentID == PaymentDetails[counter].PaymentID);   //using a Boolean Expression to initialise found
            while (!(found) & counter < PaymentDetails.Count - 1)
            {
                counter += 1;
                found = (myPaymentDetail.PaymentID == PaymentDetails[counter].PaymentID);
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
