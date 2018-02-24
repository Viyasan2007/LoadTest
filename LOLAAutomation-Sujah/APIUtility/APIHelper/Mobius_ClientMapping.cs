using System;

namespace APIUtility.APIHelper
{
    public class Mobius_ClientMapping
    {
        public long transactionNo { get; set; }
        public string loanPurpose { get; set; }
        public string transactionStatus { get; set; }
        public string subTransactionStatus { get; set; }
        public Subjectpropertyaddress subjectPropertyAddress { get; set; }
        public Clientmapping[] clientMappings { get; set; }
        public object[] agentMappings { get; set; }
        public object[] loanChannels { get; set; }
        public int baseLoanAmount { get; set; }
        public int totalLoanAmount { get; set; }
        public bool isTeamMemberLoan { get; set; }
        public bool rateLockIndicator { get; set; }
        public object[] freshStartConsultantMappings { get; set; }
    }
}
        public class Subjectpropertyaddress
        {
            public string address1 { get; set; }
            public string city { get; set; }
            public string state { get; set; }
            public string zipCode { get; set; }
        }

        public class Clientmapping
        {
            public bool isPrimaryBorrower { get; set; }
            public int sourceReferenceId { get; set; }
            public string sourceReferenceType { get; set; }
            public bool isActiveOnLoan { get; set; }
            public DateTime createDate { get; set; }
        }
 

