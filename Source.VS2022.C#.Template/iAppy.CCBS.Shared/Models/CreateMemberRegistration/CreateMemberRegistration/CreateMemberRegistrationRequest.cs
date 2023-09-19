﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CreateMemberRegistrationRequest : BaseRequest
    {
        [DataMember]
        public string ApplicationId { get; set; }

        [DataMember]
        public string CustomerId { get; set; }
    }
}
