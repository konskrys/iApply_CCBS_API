﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.CbsModels
{
    public class CbsRepaymentScheduleSaveResponse :CommonResponseModel
    {
        /// <summary>
        /// Seq.: 1
        /// Application Id
        /// </summary>
        public string la_id { get; set; }

        /// <summary>
        /// Seq.: 2
        /// Serial Num
        /// </summary>
        public int serial_num { get; set; }

        /// <summary>
        /// Seq.: 3
        /// CBS Serial Num
        /// </summary>
        public int cbs_serial_num { get; set; }
    }
}
