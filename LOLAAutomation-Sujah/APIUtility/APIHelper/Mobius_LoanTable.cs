using System;
namespace APIUtility.APIHelper
{
    public class Mobius_LoanTable
    {
        public int businessTransactionId { get; set; }
        public long transactionNo { get; set; }
        public string loanTrackerStatusGUID { get; set; }
        public string loanTrackerStatusName { get; set; }
        public string loanPurpose { get; set; }
        public int loanChannelGroupId { get; set; }
        public int loanStatus { get; set; }
        public DateTime stat60Date { get; set; }
        public DateTime lastUpdateDate { get; set; }
        public string leadTypeCode { get; set; }
        public string tenant { get; set; }
        public string transactionStatus { get; set; }
        public string subTransactionStatus { get; set; }
        public Subjectpropertyaddress subjectPropertyAddress { get; set; }
        public object[] history { get; set; }
        public Gcidmapping[] gcidMappings { get; set; }
        public string[] loanChannels { get; set; }
    }

    public class Subjectpropertyaddress
    {
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string plus4 { get; set; }
    }

    public class Gcidmapping
    {
        public int businessTransactionId { get; set; }
        public int gcid { get; set; }
        public bool isPrimaryBorrower { get; set; }
        public bool isActiveOnLoan { get; set; }
    }
}
