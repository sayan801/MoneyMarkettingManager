using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MmmData
{
    public class AgentDetails
    {
        public string agentId  { get; set; } 
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
}
