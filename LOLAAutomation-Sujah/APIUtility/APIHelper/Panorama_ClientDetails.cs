using System;

namespace APIUtility.APIHelper
{
    public class Panorama_ClientDetails
    {
        public int Gcid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsTeamMember { get; set; }
        public bool IsPermanentOptOut { get; set; }
        public Currentemailaddress CurrentEmailAddress { get; set; }
        public object[] HistoryEmailAddresses { get; set; }
        public Phonenumber[] PhoneNumbers { get; set; }
        public object[] HistoryPhoneNumbers { get; set; }
        public Communicationpreference[] CommunicationPreferences { get; set; }
        public object[] LifeEvents { get; set; }
        public Mailingaddress MailingAddress { get; set; }
        public Status Status { get; set; }
        public string PrimaryLanguage { get; set; }
    }

    public class Currentemailaddress
    {
        public string EmailAddress { get; set; }
        public DateTime HistoricalDate { get; set; }
    }

    public class Mailingaddress
    {
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }

    public class Status
    {
        public string Primary { get; set; }
        public string Secondary { get; set; }
        public DateTime LastUpdateDate { get; set; }
    }

    public class Phonenumber
    {
        public string Type { get; set; }
        public string Number { get; set; }
        public DateTime HistoricalDate { get; set; }
        public bool ContactAtWork { get; set; }
    }

    public class Communicationpreference
    {
        public string CommunicationType { get; set; }
        public string CommunicationRoute { get; set; }
        public string CommunicationAddress { get; set; }
    }
}
