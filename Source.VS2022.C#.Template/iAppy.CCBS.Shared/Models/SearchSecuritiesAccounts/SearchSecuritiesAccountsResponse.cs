﻿using System.Runtime.Serialization;

namespace iApplyShared.Models
{
    [DataContract(Namespace = "http://www.relational.gr/iApply/HFKEN/1/data")]
    public class SearchSecuritiesAccountsResponse : BaseResponse
    {
        #region Public Fields

        [DataMember]
        public SearchSecuritiesAccountListItem[] SearchSecuritiesAccountList;

        #endregion Public Fields
    }
}