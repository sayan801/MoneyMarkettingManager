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

namespace MmmDemo.Clients
{
    /// <summary>
    /// Interaction logic for ClientInfo.xaml
    /// </summary>
    public partial class ClientInfo : UserControl
    {
        public ClientInfo()
        {
            InitializeComponent();
        }

        public ClientDetails GetDetails()
        {
            ClientDetails clientData = new ClientDetails();

            clientData.clientName = nameTxtbox.Text;
            clientData.joinDate = joinDatePicker.SelectedDate.Value;
            clientData.clientDateOfBirth = clientDobDatepicker.SelectedDate.Value;
            //clientData.clientId = clientIdTxtbox.Text;
            clientData.clientJointApplicantName = jointApplicantNameTxtbox.Text;
            clientData.clientJointApplicantDateOfBirth = jointApplicantDobDatepicker.SelectedDate.Value;
            clientData.clientGuardianFatherName = clientGuardianFatherNameTxtbox.Text;
            clientData.clientAddress = clientAddressTxtbox.Text;
            clientData.clientPinCode = Convert.ToInt32(clientPinCodeTxtbox.Text);
            clientData.clientPhoneNumber = clientPhoneNumberTxtbox.Text;
            clientData.clientOccupation = clientOccupationTxtbox.Text;
            clientData.clientNomineeName = clientNomineeNameTxtbox.Text;
            clientData.clientNomineeDateOfBirth = clientNomineeDateOfBirthDatepicker.SelectedDate.Value;
            clientData.clientNomineeRelationship = clientNomineeRelationshipTxtbox.Text;
            clientData.clientPlan = clientPlanTxtbox.Text;
            clientData.clientProposedValue = Convert.ToDouble(clientProposedValueTxtbox.Text);
            clientData.clientPeriodMonth = Convert.ToInt32(clientPeriodMonthTxtbox.Text);
            clientData.clientPaymentMode = clientPaymentModeCombobox.Text;
            clientData.clientPaymentAmountInstallment = Convert.ToDouble(clientPaymentAmountInstalmentTxtbox.Text);
            clientData.clientPaymentAmountServiceCharge = Convert.ToDouble (clientPaymentAmountServiceChargeTxtbox.Text);
            clientData.clientPaymentAmountTotal = Convert.ToDouble(clientPaymentAmountTotalTxtbox.Text);
            clientData.clientPaymentReciptNumber = clientPaymentReceiptNumberTxtbox.Text;
            clientData.clientIntroducerId = clientIntroducerIdTxtbox.Text;

            return clientData;
        }

        public void SetDetails(ClientDetails clientData)
        {

            nameTxtbox.Text = clientData.clientName;
            joinDatePicker.SelectedDate = clientData.joinDate;
            clientDobDatepicker.SelectedDate = clientData.clientDateOfBirth;
            clientIdTxtbox.Text = clientData.clientId;
            jointApplicantNameTxtbox.Text = clientData.clientJointApplicantName;
            jointApplicantDobDatepicker.SelectedDate = clientData.clientJointApplicantDateOfBirth;
            clientGuardianFatherNameTxtbox.Text = clientData.clientGuardianFatherName;
            clientAddressTxtbox.Text = clientData.clientAddress;
            clientPinCodeTxtbox.Text = clientData.clientPinCode.ToString();
            clientPhoneNumberTxtbox.Text = clientData.clientPhoneNumber;
            clientOccupationTxtbox.Text = clientData.clientOccupation;
            clientNomineeNameTxtbox.Text=clientData.clientNomineeName;
            clientNomineeDateOfBirthDatepicker.SelectedDate = clientData.clientNomineeDateOfBirth;
            clientNomineeRelationshipTxtbox.Text = clientData.clientNomineeRelationship;
            clientPlanTxtbox.Text = clientData.clientPlan;
            clientProposedValueTxtbox.Text = clientData.clientProposedValue.ToString();
            clientPeriodMonthTxtbox.Text=clientData.clientPeriodMonth.ToString();
            clientPaymentModeCombobox.Text = clientData.clientPaymentMode;
            clientPaymentAmountInstalmentTxtbox.Text = clientData.clientPaymentAmountInstallment.ToString();
            clientPaymentAmountServiceChargeTxtbox.Text = clientData.clientPaymentAmountServiceCharge.ToString();
            clientPaymentAmountTotalTxtbox.Text = clientData.clientPaymentAmountTotal.ToString();
            clientPaymentReceiptNumberTxtbox.Text  = clientData.clientPaymentReciptNumber;
            clientIntroducerIdTxtbox.Text = clientData.clientIntroducerId;
            

        }
    }
}
