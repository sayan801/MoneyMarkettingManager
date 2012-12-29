using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MmmData
{
    public class ClientDetails
    {
        public string clientId  { get; set; } 
        public string clientName  { get; set; } 
        public DateTime joinDate  { get; set; } 
        public DateTime clientDateOfBirth  { get; set; } 
        public string clientJointApplicantName  { get; set; } 
        public DateTime clientJointApplicantDateOfBirth  { get; set; } 
        public string clientGuardianFatherName  { get; set; } 
        public string clientAddress  { get; set; } 
        public int clientPinCode  { get; set; } 
        public string clientPhoneNumber  { get; set; } 
        public string clientOccupation  { get; set; } 
        public string clientNomineeName  { get; set; } 
        public DateTime clientNomineeDateOfBirth  { get; set; } 
        public string clientNomineeRelationship  { get; set; } 
        public string clientPlan  { get; set; } 
        public double clientProposedValue  { get; set; } 
        public int clientPeriodMonth  { get; set; } 
        public string clientPaymentMode  { get; set; } 
        public double clientPaymentAmountInstallment  { get; set; } 
        public double clientPaymentAmountServiceCharge  { get; set; } 
        public double clientPaymentAmountTotal  { get; set; } 
        public string clientPaymentReciptNumber  { get; set; } 
        public string clientIntroducerId  { get; set; } 
    }
}
