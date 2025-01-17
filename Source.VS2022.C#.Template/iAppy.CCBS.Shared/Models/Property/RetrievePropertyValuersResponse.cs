﻿using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class RetrievePropertyValuersResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public bool HasMissingValuers { get; set; }

        [DataMember]
        public CbsPropertyPerson[] MissingValuers { get; set; }

        #endregion Public Properties
    }
}