﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchValuerResponse : BaseResponse
    {
        [DataMember]
        public CbsValuer[] Results { get; set; }
        [DataMember]
        public int ResultsCount { get; set; }
    }
}
