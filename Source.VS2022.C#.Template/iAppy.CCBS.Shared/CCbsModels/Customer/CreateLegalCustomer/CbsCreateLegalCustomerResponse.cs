﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsCreateLegalCustomerResponse : CommonResponseModel
    {
        #region Public Properties

        /// <summary>
        /// Customer Id (varchar (15))
        /// </summary>
        public string cu_id { get; set; }

        /// <summary>
        /// Customer CBS Id (varchar (20))
        /// </summary>
        public string cu_clnum { get; set; }

        /// <summary>
        /// Customer Check Digit (integer)
        /// </summary>
        public int cu_checkdigit { get; set; }

        /// <summary>
        /// Member Id (varchar (20))
        /// </summary>
        public string member_id { get; set; }

        /// <summary>
        /// Member Status (varchar (20))
        /// 1
        /// </summary>
        public string member_status { get; set; }

        /// <summary>
        /// Member SubStatus (varchar (20))
        /// 1
        /// </summary>
        public string member_substatus { get; set; }

        /// <summary>
        /// Member Creation Date (datetime)
        /// business date
        /// </summary>
        public DateTime member_strdate { get; set; }

        /// <summary>
        /// Member Contributions (varchar (1))
        /// 2
        /// </summary>
        public string source { get; set; }

        /// <summary>
        /// BBF Self CBS Id (varchar (20))
        /// </summary>
        public string clnum { get; set; }

        /// <summary>
        /// BBF Self Check Digit (integer)
        /// </summary>
        public int checkdigit { get; set; }

        /// <summary>
        /// sn_cbs (integer)
        /// </summary>
        public int sn_cbs { get; set; }

        /// <summary>
        /// addnumcbs (integer)
        /// </summary>
        public int addnumcbs { get; set; }

        /// <summary>
        /// pe_idtyp (varchar (10))
        /// </summary>
        public string pe_idtyp { get; set; }

        /// <summary>
        /// pe_idnbr (varchar (20))
        /// </summary>
        public string pe_idnbr { get; set; }

        #endregion Public Properties
    }
}
