using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MmmData;

namespace MmmDb
{
    public static class DbInteraction
    {
        #region Login

        public static bool DoMmmLogin(LoginData loginData)
        {
            return FetcheLoginData(loginData);
        }

        private static bool FetcheLoginData(LoginData loginData)
        {
            bool returnVal = false;

            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlConnection.Open();

                msqlCommand.CommandText = "Select password,type from login_details where user_name = @userName;";
                msqlCommand.Parameters.AddWithValue("@userName", loginData.userName);
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                msqlReader.Read();


                string password = msqlReader.GetString("password");
                string type = msqlReader.GetString("type");

                if (loginData.password.Equals(password) && loginData.type.ToString().Equals(type))
                    returnVal = true;
            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return returnVal;
        }

        #endregion

        #region Agents

        public static int DoRegisterNewAgent(AgentDetails agentDetails)
        {
            return RegisterNewAgentInDb(agentDetails);
        }
        private static int RegisterNewAgentInDb(AgentDetails agentDetails)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                //open the connection
                if (msqlConnection.State != System.Data.ConnectionState.Open)
                    msqlConnection.Open();

                msqlCommand.CommandText = "INSERT INTO agents(agent_id,agent_join_date,agent_rank,agent_designation,agent_nationality,agent_educational_qualification,agent_nominee_name,agent_nominee_dob,agent_nominee_relationship,agent_introducer_id,agent_branch_id,agent_name,agent_father_husband_name,agent_address,agent_pin_code,agent_state,agent_phone_number,agent_blood_group,agent_dob) "
                                                   + "VALUES(@agent_id,@agent_join_date,@agent_rank,@agent_designation,@agent_nationality,@agent_educational_qualification,@agent_nominee_name,@agent_nominee_dob,@agent_nominee_relationship,@agent_introducer_id,@agent_branch_id,@agent_name,@agent_father_husband_name,@agent_address,@agent_pin_code,@agent_state,@agent_phone_number,@agent_blood_group,@agent_dob)";

                msqlCommand.Parameters.AddWithValue("@agent_id", agentDetails.agentId);
                msqlCommand.Parameters.AddWithValue("@agent_join_date", agentDetails.joinDate);
                msqlCommand.Parameters.AddWithValue("@agent_rank", agentDetails.rank);
                msqlCommand.Parameters.AddWithValue("@agent_designation", agentDetails.designation);
                msqlCommand.Parameters.AddWithValue("@agent_nationality", agentDetails.agentNationality);
                msqlCommand.Parameters.AddWithValue("@agent_educational_qualification", agentDetails.agentQualification);
                msqlCommand.Parameters.AddWithValue("@agent_nominee_name", agentDetails.agentNomineeName);
                msqlCommand.Parameters.AddWithValue("@agent_nominee_dob", agentDetails.agentNomineeDob);
                msqlCommand.Parameters.AddWithValue("@agent_nominee_relationship", agentDetails.agentNomineeRelationship);
                msqlCommand.Parameters.AddWithValue("@agent_introducer_id", agentDetails.agentIntroducerId);
                msqlCommand.Parameters.AddWithValue("@agent_branch_id", agentDetails.agentBranchId);
                msqlCommand.Parameters.AddWithValue("@agent_name", agentDetails.agentName);
                msqlCommand.Parameters.AddWithValue("@agent_father_husband_name", agentDetails.agentFatherHusbandName);
                msqlCommand.Parameters.AddWithValue("@agent_address", agentDetails.agentAddress);
                msqlCommand.Parameters.AddWithValue("@agent_pin_code", agentDetails.agentPinCode);
                msqlCommand.Parameters.AddWithValue("@agent_state", agentDetails.agentState);
                msqlCommand.Parameters.AddWithValue("@agent_phone_number", agentDetails.agentPhoneNumber);
                msqlCommand.Parameters.AddWithValue("@agent_blood_group", agentDetails.agentBloodGroup);
                msqlCommand.Parameters.AddWithValue("@agent_dob", agentDetails.agentDateOfBirth);

                msqlCommand.ExecuteNonQuery();
                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }

        public static List<AgentDetails> GetAllAgentList()
        {
            return QueryAllAgentList();
        }

        private static List<AgentDetails> QueryAllAgentList()
        {
            List<AgentDetails> agentList = new List<AgentDetails>();
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlConnection.Open();

                msqlCommand.CommandText = "Select * From agents;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    AgentDetails agent = new AgentDetails();


                    agent.agentId = msqlReader.GetString("agent_id");
                    agent.rank = msqlReader.GetInt32("agent_rank");
                    agent.designation = msqlReader.GetString("agent_designation");
                    agent.agentNationality = msqlReader.GetString("agent_nationality");
                    agent.agentQualification = msqlReader.GetString("agent_educational_qualification");
                    agent.agentNomineeName = msqlReader.GetString("agent_nominee_name");
                    agent.agentNomineeDob = msqlReader.GetDateTime("agent_nominee_dob");
                    agent.joinDate = msqlReader.GetDateTime("agent_join_date");
                    agent.agentNomineeRelationship = msqlReader.GetString("agent_nominee_relationship");
                    agent.agentIntroducerId = msqlReader.GetString("agent_introducer_id");
                    agent.agentBranchId = msqlReader.GetString("agent_branch_id");
                    agent.agentName = msqlReader.GetString("agent_name");
                    agent.agentFatherHusbandName = msqlReader.GetString("agent_father_husband_name");
                    agent.agentAddress = msqlReader.GetString("agent_address");
                    agent.agentPinCode = msqlReader.GetInt32("agent_pin_code");
                    agent.agentState = msqlReader.GetString("agent_state");
                    agent.agentPhoneNumber = msqlReader.GetString("agent_phone_number");
                    agent.agentBloodGroup = msqlReader.GetString("agent_blood_group");
                    agent.agentDateOfBirth = msqlReader.GetDateTime("agent_dob");

                    agentList.Add(agent);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return agentList;
        }

        #endregion

        #region Clients

        public static int DoRegisterNewClient(ClientDetails clientDetails)
        {
            return RegisterNewClientInDb(clientDetails);
        }

        private static int RegisterNewClientInDb(ClientDetails clientDetails)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                //open the connection
                if (msqlConnection.State != System.Data.ConnectionState.Open)
                    msqlConnection.Open();

                msqlCommand.CommandText = "INSERT INTO clients(client_id,client_name,client_dob,client_joint_applicant_name,client_joint_applicant_dob,client_gurdain_father_husband_name,client_address,client_pin_code,client_phone_number,client_occupation,client_nominee_name,client_nominee_dob,client_nominee_relationship,client_plan,client_proposed_value,client_period_month,client_payment_mode,client_payment_amount_instalment,client_payment_amount_service_charge,client_payment_amount_total,client_payment_receipt_number,client_introducer_id,client_join_date) "
                                                   + "VALUES(@client_id,@client_name,@client_dob,@client_joint_applicant_name,@client_joint_applicant_dob,@client_gurdain_father_husband_name,@client_address,@client_pin_code,@client_phone_number,@client_occupation,@client_nominee_name,@client_nominee_dob,@client_nominee_relationship,@client_plan,@client_proposed_value,@client_period_month,@client_payment_mode,@client_payment_amount_instalment,@client_payment_amount_service_charge,@client_payment_amount_total,@client_payment_receipt_number,@client_introducer_id,@client_join_date)";

                msqlCommand.Parameters.AddWithValue("@client_id", clientDetails.clientId);
                msqlCommand.Parameters.AddWithValue("@client_name", clientDetails.clientName);
                msqlCommand.Parameters.AddWithValue("@client_dob", clientDetails.clientDateOfBirth);
                msqlCommand.Parameters.AddWithValue("@client_joint_applicant_name", clientDetails.clientJointApplicantName);
                msqlCommand.Parameters.AddWithValue("@client_joint_applicant_dob", clientDetails.clientJointApplicantDateOfBirth);
                msqlCommand.Parameters.AddWithValue("@client_gurdain_father_husband_name", clientDetails.clientGuardianFatherName);
                msqlCommand.Parameters.AddWithValue("@client_address", clientDetails.clientAddress);
                msqlCommand.Parameters.AddWithValue("@client_pin_code", clientDetails.clientPinCode);
                msqlCommand.Parameters.AddWithValue("@client_phone_number", clientDetails.clientPhoneNumber);
                msqlCommand.Parameters.AddWithValue("@client_occupation", clientDetails.clientOccupation);
                msqlCommand.Parameters.AddWithValue("@client_nominee_name", clientDetails.clientNomineeName);
                msqlCommand.Parameters.AddWithValue("@client_nominee_dob", clientDetails.clientNomineeDateOfBirth);
                msqlCommand.Parameters.AddWithValue("@client_nominee_relationship", clientDetails.clientNomineeRelationship);
                msqlCommand.Parameters.AddWithValue("@client_plan", clientDetails.clientPlan);
                msqlCommand.Parameters.AddWithValue("@client_proposed_value", clientDetails.clientProposedValue);
                msqlCommand.Parameters.AddWithValue("@client_period_month", clientDetails.clientPeriodMonth);
                msqlCommand.Parameters.AddWithValue("@client_payment_mode", clientDetails.clientPaymentMode);
                msqlCommand.Parameters.AddWithValue("@client_payment_amount_instalment", clientDetails.clientPaymentAmountInstallment);
                msqlCommand.Parameters.AddWithValue("@client_payment_amount_service_charge", clientDetails.clientPaymentAmountServiceCharge);
                msqlCommand.Parameters.AddWithValue("@client_payment_amount_total", clientDetails.clientPaymentAmountTotal);
                msqlCommand.Parameters.AddWithValue("@client_payment_receipt_number", clientDetails.clientPaymentReciptNumber);
                msqlCommand.Parameters.AddWithValue("@client_introducer_id", clientDetails.clientIntroducerId);
                msqlCommand.Parameters.AddWithValue("@client_join_date", clientDetails.joinDate);


                msqlCommand.ExecuteNonQuery();
                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }

        public static List<ClientDetails> GetAllClientList()
        {
            return QueryAllClientList();
        }

        private static List<ClientDetails> QueryAllClientList()
        {
            List<ClientDetails> clientList = new List<ClientDetails>();
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlConnection.Open();

                msqlCommand.CommandText = "Select * From clients;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    ClientDetails client = new ClientDetails();


                    client.clientId = msqlReader.GetString("client_id");
                    client.clientName = msqlReader.GetString("client_name");
                    client.clientDateOfBirth = msqlReader.GetDateTime("client_dob");
                    client.clientJointApplicantName = msqlReader.GetString("client_joint_applicant_name");
                    client.clientJointApplicantDateOfBirth = msqlReader.GetDateTime("client_joint_applicant_dob");
                    client.clientGuardianFatherName = msqlReader.GetString("client_gurdain_father_husband_name");
                    client.clientAddress = msqlReader.GetString("client_address");
                    client.clientPinCode = msqlReader.GetInt32("client_pin_code");
                    client.clientPhoneNumber = msqlReader.GetString("client_phone_number");
                    client.clientOccupation = msqlReader.GetString("client_occupation");
                    client.clientNomineeName = msqlReader.GetString("client_nominee_name");
                    client.clientNomineeDateOfBirth = msqlReader.GetDateTime("client_nominee_dob");
                    client.clientNomineeRelationship = msqlReader.GetString("client_nominee_relationship");
                    client.clientPlan = msqlReader.GetString("client_plan");
                    client.clientPeriodMonth = msqlReader.GetInt32("client_period_month");
                    client.clientPaymentMode = msqlReader.GetString("client_payment_mode");
                    client.clientPaymentAmountInstallment = msqlReader.GetDouble("client_payment_amount_instalment");
                    client.clientPaymentAmountServiceCharge = msqlReader.GetDouble("client_payment_amount_service_charge");
                    client.clientPaymentAmountTotal = msqlReader.GetDouble("client_payment_amount_total");
                    client.clientPaymentReciptNumber = msqlReader.GetString("client_payment_receipt_number");
                    client.clientIntroducerId = msqlReader.GetString("client_introducer_id");
                    client.joinDate = msqlReader.GetDateTime("client_join_date");

                    clientList.Add(client);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return clientList;

        }

        #endregion

        #region Employee

        public static int DoRegisterNewEmployee(EmployeeDetails employeeDetails)
        {
            return DoRegisterNewEmployeeInDb(employeeDetails);
        }

        private static int DoRegisterNewEmployeeInDb(EmployeeDetails employeeDetails)
        {
            int returnVal = 0;
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {
                //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();

                //define the connection used by the command object
                msqlCommand.Connection = msqlConnection;

                //open the connection
                if (msqlConnection.State != System.Data.ConnectionState.Open)
                    msqlConnection.Open();

                msqlCommand.CommandText = "INSERT INTO employees(employee_id,employee_name,employee_dob,employee_address,employee_phone_no,employee_email,employee_join_date,department,salary,employee_manager_id) "
                                                   + "VALUES(@employee_id,@employee_name,@employee_dob,@employee_address,@employee_phone_no,@employee_email,@employee_join_date,@department,@salary,@employee_manager_id)";

                msqlCommand.Parameters.AddWithValue("@employee_id", employeeDetails.employeeId);
                msqlCommand.Parameters.AddWithValue("@employee_name", employeeDetails.employeeName);
                msqlCommand.Parameters.AddWithValue("@employee_dob", employeeDetails.employeeDob);
                msqlCommand.Parameters.AddWithValue("@employee_address", employeeDetails.employeeAddress);
                msqlCommand.Parameters.AddWithValue("@employee_phone_no", employeeDetails.employeePhoneNumber);
                msqlCommand.Parameters.AddWithValue("@employee_email", employeeDetails.employeeEmail);
                msqlCommand.Parameters.AddWithValue("@employee_join_date", employeeDetails.employeeJoinDate);
                msqlCommand.Parameters.AddWithValue("@department", employeeDetails.employeeDepartment);
                msqlCommand.Parameters.AddWithValue("@salary", employeeDetails.employeeSalary);
                msqlCommand.Parameters.AddWithValue("@employee_manager_id", employeeDetails.employeeManagerId);
                msqlCommand.ExecuteNonQuery();
                returnVal = 1;
            }
            catch (Exception er)
            {
                returnVal = 0;
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }
            return returnVal;
        }

        public static List<EmployeeDetails> GetAllEmployeeList()
        {
            return QueryAllEmployeeList();
        }

        private static List<EmployeeDetails> QueryAllEmployeeList()
        {
            List<EmployeeDetails> employeeList = new List<EmployeeDetails>();
            MySql.Data.MySqlClient.MySqlConnection msqlConnection = null;

            msqlConnection = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user id=root;Password=technicise;database=Mmm_mb;persist security info=False");
            try
            {   //define the command reference
                MySql.Data.MySqlClient.MySqlCommand msqlCommand = new MySql.Data.MySqlClient.MySqlCommand();
                msqlCommand.Connection = msqlConnection;

                msqlConnection.Open();

                msqlCommand.CommandText = "Select * From employees;";
                MySql.Data.MySqlClient.MySqlDataReader msqlReader = msqlCommand.ExecuteReader();

                while (msqlReader.Read())
                {
                    EmployeeDetails employee = new EmployeeDetails();
                    
                    employee.employeeId = msqlReader.GetString("employee_id");
                    employee.employeeName = msqlReader.GetString("employee_name");
                    employee.employeeDob = msqlReader.GetDateTime("employee_dob");
                    employee.employeeAddress = msqlReader.GetString("employee_address");
                    employee.employeeJoinDate = msqlReader.GetDateTime("employee_join_date");
                    employee.employeePhoneNumber = msqlReader.GetString("employee_phone_no");
                    employee.employeeEmail = msqlReader.GetString("employee_email");
                    employee.employeeDepartment = msqlReader.GetString("department");
                    employee.employeeSalary = msqlReader.GetDouble("salary");
                    employee.employeeManagerId = msqlReader.GetString("employee_manager_id");

                    employeeList.Add(employee);
                }

            }
            catch (Exception er)
            {
            }
            finally
            {
                //always close the connection
                msqlConnection.Close();
            }

            return employeeList;

        }

        #endregion




    }
}
