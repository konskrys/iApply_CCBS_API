﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class DownloadRepInstallmentRequest : BaseRequest
    {
        [DataMember(IsRequired = true)]
        public string LoanAccountNo { get; set; }

        [DataMember(IsRequired = true)]
        public short? LoanAccountCD { get; set; }
    }
}
