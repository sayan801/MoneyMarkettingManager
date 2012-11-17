using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MmmData;

namespace MmmDemo
{
    /// <summary>
    /// Interaction logic for AgentInfo.xaml
    /// </summary>
    public partial class AgentInfo : UserControl
    {
        public AgentInfo()
        {
            InitializeComponent();
        }

        public AgentDetails GetDetails()
        {
            AgentDetails agentData = new AgentDetails();

            agentData.agentAddress = addressTxtbox.Text;
            agentData.agentBloodGroup = bloodGroupTxtbox.Text;
            agentData.agentBranchId = branchTxtbox.Text;
            agentData.agentDateOfBirth = dobDatepicker.SelectedDate.Value;
            agentData.joinDate = joinDatePicker.SelectedDate.Value;
            agentData.agentFatherHusbandName = fatherHusbandNameTxtbox.Text;
            agentData.agentIntroducerId = introducerIdTxtbox.Text;
            agentData.agentName = nameTxtbox.Text;
            agentData.agentNationality = nationalityTxtbox.Text;
            agentData.agentNomineeDob = nomineeAgeDatepicker.SelectedDate.Value;
            agentData.agentNomineeName = nomineeNameTxtbox.Text;
            agentData.agentNomineeRelationship = nomineeRelationshipTxtbox.Text;
            agentData.agentPhoneNumber = phoneNoTxtbox.Text;
            agentData.agentPinCode = Convert.ToInt32(pincodeTxtbox.Text);
            agentData.agentQualification = qualificationTxtbox.Text;
            agentData.agentState = stateTxtbox.Text;
            //agentData.agentTitle = titleNameCombobox.Text;
            agentData.designation = designationTxtbox.Text;
            agentData.rank = Convert.ToInt32(rankTxtbox.Text);

            return agentData;
        }

        internal void SetDetails(AgentDetails agentDetails)
        {
            agentIdTxtbox.Text = agentDetails.agentId;
            addressTxtbox.Text = agentDetails.agentAddress;
            bloodGroupTxtbox.Text = agentDetails.agentBloodGroup;
            branchTxtbox.Text = agentDetails.agentBranchId;
            dobDatepicker.SelectedDate = agentDetails.agentDateOfBirth;
            joinDatePicker.SelectedDate = agentDetails.joinDate;
            fatherHusbandNameTxtbox.Text = agentDetails.agentFatherHusbandName;
            introducerIdTxtbox.Text = agentDetails.agentIntroducerId;
            nameTxtbox.Text = agentDetails.agentName;
            nationalityTxtbox.Text  = agentDetails.agentNationality ;
            nomineeAgeDatepicker.SelectedDate = agentDetails.agentNomineeDob;
            nomineeNameTxtbox.Text = agentDetails.agentNomineeName ;
            nomineeRelationshipTxtbox.Text = agentDetails.agentNomineeRelationship;
            phoneNoTxtbox.Text= agentDetails.agentPhoneNumber ;
            pincodeTxtbox.Text= agentDetails.agentPinCode.ToString();
            qualificationTxtbox.Text = agentDetails.agentQualification;
            stateTxtbox.Text = agentDetails.agentState;
            //titleNameCombobox.Text = agentDetails.agentTitle;
            designationTxtbox.Text=agentDetails.designation;
            rankTxtbox.Text = agentDetails.rank.ToString();
        }
    }
}
