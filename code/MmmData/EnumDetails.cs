using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MmmData
{
    public enum ViewOrEdit
    {
        View,
        Edit
    }

    public enum AmountType
    {
        Debit,
        Credit,
        Overdraft
    }

    public class AmountInfo
    {
        public string id { get; set; }
        public double amount { get; set; }
        public string description { get; set; }
        public AmountType type { get; set; }

    }

    public class AccountInfo
    {
        public string id { get; set; }
        public ClientDetails client;
        public double balance { get; set; }
        public List<AmountInfo> amounts { get; set; }
    }

    public class SchemeInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public DateTime Duration { get; set; }
        public DateTime dateOfStart { get; set; }
        public string description { get; set; }
        public AmountInfo amountPremium { get; set; }
        public double incentivePercentage;
    }

    public class LoanInfo
    {
        public string id { get; set; }
        public string name { get; set; }
        public string Type { get; set; }
        public DateTime Duration { get; set; }
        public DateTime dateOfStart { get; set; }
        public string description { get; set; }
        public AmountInfo amountPrincipal { get; set; }
        public double interestPercentage;
    }

    public class SchemeController
    {
        public List<SchemeInfo> schemes;
    }

    public class LoanController
    {
        public List<LoanInfo> loans;
    }
    public class ClientController
    {
        public List<ClientDetails> clients;
    }

    public class AgentsController
    {
        public List<AgentDetails> agents;
    }
    public class AcountsController
    {
        public List<AccountInfo> accounts;
    }

    public class MFMSController
    {
        public AgentsController agentsController;
        public ClientController clientController;
        public SchemeController SchemeController;
        public LoanController loanController;
        public AcountsController AcountsController;
    }
}
