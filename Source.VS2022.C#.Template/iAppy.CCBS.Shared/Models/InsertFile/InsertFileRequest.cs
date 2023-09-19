﻿using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class InsertFileRequest : BaseRequest
    {
        #region Public Properties

        [DataMember]
        public string CustomerId { get; set; }

        [DataMember]
        public string DocId { get; set; }

        #endregion Public Properties
    }
}