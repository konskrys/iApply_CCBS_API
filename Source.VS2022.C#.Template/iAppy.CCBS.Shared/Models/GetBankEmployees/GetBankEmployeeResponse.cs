﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class GetBankEmployeeResponse : BaseResponse
    {
        [DataMemberAttribute]
        public BankEmployeeInfo[] Details { get; set; }

        [DataMemberAttribute]
        public bool NotFound { get; set; }


    }
}
