using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {

        public int EmployeeSqlConnection(string FirstName, string LastName, string EmailId, long PhoneNumber, long AlternatePhoneNumber, string Address1, string Address2, string HomeCountry, string CurrentCountry, int ZipCode)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
            "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand EmployeeDetailCommand = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
                                 "'" + FirstName + "','" + LastName + "','" + EmailId + "'," +
                                 PhoneNumber + "," + AlternatePhoneNumber + ",'" + Address1 + "','" + Address2 +
                                 "','" + HomeCountry + "','" + CurrentCountry + "'," + ZipCode + ")", mysqlconnection);

            int EmployeeConnection = EmployeeDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return EmployeeConnection;

        }

        public int ProjectSqlConnection(string ProjectName, string ClientName, string Location, string Roles, int EmployeeId)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                         "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand ProjectDetailCommand = new SqlCommand("INSERT INTO ProjectDetail VALUES(" +
                             "'" + ProjectName + "','" + ClientName + "','" + Location + "','" +
                             Roles + "'," + EmployeeId + ")", mysqlconnection);
            int ProjectConnection = ProjectDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return ProjectConnection;
        }

        public int CompanySqlConnection(string EmployerName, int ContactNumber, string Location, string Website, int EmployeeId)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                         "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand CompanyDetailCommand = new SqlCommand("INSERT INTO CompanyDetail VALUES(" +
                                 "'" + EmployerName + "'," + ContactNumber + ",'" + Location + "','" + Website + "'," + EmployeeId + ")", mysqlconnection);
            int CompanyConnection = CompanyDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return CompanyConnection;
        }

        public int TechnicalSqlConnection(string UserInterface, string ProgrammingLanguage, string Database, int EmployeeId)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                         "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand TechnicalDetailCommand = new SqlCommand("INSERT INTO TechnicalDetail VALUES(" +
                                 "'" + UserInterface + "','" + ProgrammingLanguage + "','" + Database + "'," + EmployeeId + ")", mysqlconnection);
            int TechnicalConnection = TechnicalDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return TechnicalConnection;

        }
    }

}

