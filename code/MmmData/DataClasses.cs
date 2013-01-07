using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MmmData
{

    public class EmployeeDetails
    {
        public string employeeId { get; set; }
        public string employeeName { get; set; }
        public DateTime employeeDob { get; set; }
        public string employeeAddress { get; set; }
        public string employeePhoneNumber { get; set; }
        public string employeeEmail { get; set; }
        public DateTime employeeJoinDate { get; set; }
        public string employeeDepartment { get; set; }
        public double employeeSalary { get; set; }
        public string employeeManagerId { get; set; }
    }

   /* public class AccountInfo
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
    }*/

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
    public enum UserTypeEnum
    {
        user,
        manager,
        owner
    }

    public class AgentDetails
    {
        public string agentId { get; set; }
        public string agentTitle { get; set; }
        public string agentName { get; set; }
        public DateTime joinDate { get; set; }
        public int rank { get; set; }
        public string designation { get; set; }
        public string agentFatherHusbandName { get; set; }
        public string agentAddress { get; set; }
        public int agentPinCode { get; set; }
        public string agentState { get; set; }
        public string agentPhoneNumber { get; set; }
        public string agentBloodGroup { get; set; }
        public DateTime agentDateOfBirth { get; set; }
        public string agentNationality { get; set; }
        public string agentQualification { get; set; }
        public string agentNomineeName { get; set; }
        public DateTime agentNomineeDob { get; set; }
        public string agentNomineeRelationship { get; set; }
        public string agentIntroducerId { get; set; }
        public string agentBranchId { get; set; }
        public List<ClientDetails> clients;
    }

    public class LoginData
    {
        public string userName;
        public UserTypeEnum type;
        public string password;
    }

    public class ClientDetails
    {
        public string clientId { get; set; }
        public string clientName { get; set; }
        public DateTime joinDate { get; set; }
        public DateTime clientDateOfBirth { get; set; }
        public string clientJointApplicantName { get; set; }
        public DateTime clientJointApplicantDateOfBirth { get; set; }
        public string clientGuardianFatherName { get; set; }
        public string clientAddress { get; set; }
        public int clientPinCode { get; set; }
        public string clientPhoneNumber { get; set; }
        public string clientOccupation { get; set; }
        public string clientNomineeName { get; set; }
        public DateTime clientNomineeDateOfBirth { get; set; }
        public string clientNomineeRelationship { get; set; }
        public string clientPlan { get; set; }
        public double clientProposedValue { get; set; }
        public int clientPeriodMonth { get; set; }
        public string clientPaymentMode { get; set; }
        public double clientPaymentAmountInstallment { get; set; }
        public double clientPaymentAmountServiceCharge { get; set; }
        public double clientPaymentAmountTotal { get; set; }
        public string clientPaymentReciptNumber { get; set; }
        public string clientIntroducerId { get; set; }
        public List<SchemeInfo> schemes;
        public List<LoanInfo> loans;
        public List<AmountInfo> payments;
    }

}
