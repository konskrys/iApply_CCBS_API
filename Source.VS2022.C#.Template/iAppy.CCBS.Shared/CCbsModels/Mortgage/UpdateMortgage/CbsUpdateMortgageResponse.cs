﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsUpdateMortgageResponse : CommonResponseModel
    {
        /// <summary>
        /// Application Id
        /// Data Type: varchar (15)
        /// Entities: crp_CBS_updateMortCBSID
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Mortgage Id
        /// Data Type: varchar (15)
        /// Entities: crp_CBS_updateMortCBSID
        /// </summary>
        public string mort_id { get; set; }

        /// <summary>
        /// Mortgage CBS Id
        /// Data Type: integer
        /// Entities: crp_CBS_updateMortCBSID
        /// </summary>
        public int cbsid { get; set; }

        /// <summary>
        /// Mortgage Status
        /// Data Type: varchar (10)
        /// Entities: crp_CBS_updateMortCBSID
        /// </summary>
        public string cbs_status { get; set; }

        /// <summary>
        /// Property Id
        /// Entities: crp_CBS_updateMortDetCBSID
        /// </summary>
        public string p_ipid { get; set; }

        /// <summary>
        /// Mortgage CBS Id
        /// Data Type: integer
        /// Entities: crp_CBS_updateMortDetCBSID
        /// </summary>
        public int p_cbsid { get; set; }
    }
}