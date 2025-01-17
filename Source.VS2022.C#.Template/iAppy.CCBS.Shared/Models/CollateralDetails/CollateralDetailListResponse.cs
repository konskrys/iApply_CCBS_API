﻿using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class CollateralDetailListResponse : BaseResponse
    {
        #region Public Properties

        [DataMember]
        public RetrieveCollateralDetailsResponse[] MissingPersons { get; set; }

        #endregion Public Properties
    }
}