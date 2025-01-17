﻿namespace iApplyShared.CbsModels
{
    public class CbsSearchCustomerAccountsRequest
    {
        #region Public Properties

        /// <summary>
        /// Account Type (varchar (10))
        /// </summary>
        public string AccountType { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string CustomerID { get; set; }

        /// <summary>
        /// Account Customer Type (varchar (10))
        /// Cod from G015
        /// </summary>
        public string CustomerType { get; set; }

        /// <summary>
        /// Product Id (varchar (30))
        /// </summary>
        public string ProductID { get; set; }

        #endregion Public Properties
    }
}