using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PioneerTech.Consultancy.Model;

namespace PioneerTech.Consultancy.DAL
{
    public class EmployeeDataAccessLayer
    {

        public long EmployeeSqlConnection(EmployeeDetailsModel EmployeeDetailsmodel)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
            "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand EmployeeDetailCommand = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
                                 "'" + EmployeeDetailsmodel.FirstName + "','" + EmployeeDetailsmodel.LastName + "','" + EmployeeDetailsmodel.EmailId + "'," +
                                 EmployeeDetailsmodel.PhoneNumber + "," + EmployeeDetailsmodel.AlternatePhoneNumber + ",'" + EmployeeDetailsmodel.Address1 + "','" + EmployeeDetailsmodel.Address2 +
                                 "','" + EmployeeDetailsmodel.HomeCountry + "','" + EmployeeDetailsmodel.CurrentCountry + "'," + EmployeeDetailsmodel.ZipCode + ")", mysqlconnection);

            long EmployeeConnection = EmployeeDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return EmployeeConnection;

        }

        public long ProjectSqlConnection(ProjectDetailsModel ProjectDetailsmodel)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                         "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand ProjectDetailCommand = new SqlCommand("INSERT INTO ProjectDetail VALUES(" +
                             "'" + ProjectDetailsmodel.ProjectName + "','" + ProjectDetailsmodel.ClientName + "','" + ProjectDetailsmodel.Location + "','" +
                             ProjectDetailsmodel.Roles + "'," + ProjectDetailsmodel.EmployeeId + ")", mysqlconnection);
            long ProjectConnection = ProjectDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return ProjectConnection;
        }

        public long CompanySqlConnection(CompanyDetailsModel CompanyDetailsmodel)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                         "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand CompanyDetailCommand = new SqlCommand("INSERT INTO CompanyDetail VALUES(" +
                                 "'" + CompanyDetailsmodel.EmployerName + "'," + CompanyDetailsmodel.ContactNumber + ",'" + CompanyDetailsmodel.Location + "','" + CompanyDetailsmodel.Website + "'," + CompanyDetailsmodel.EmployeeId + ")", mysqlconnection);
            long CompanyConnection = CompanyDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return CompanyConnection;
        }

        public long TechnicalSqlConnection(TechnicalDetailsModel TechnicalDetailsmodel)
        {
            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                         "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            mysqlconnection.Open();
            SqlCommand TechnicalDetailCommand = new SqlCommand("INSERT INTO TechnicalDetail VALUES(" +
                                 "'" + TechnicalDetailsmodel.UserInterface + "','" + TechnicalDetailsmodel.ProgrammingLanguages + "','" + TechnicalDetailsmodel.Database + "'," + TechnicalDetailsmodel.EmployeeId + ")", mysqlconnection);
            long TechnicalConnection = TechnicalDetailCommand.ExecuteNonQuery();
            mysqlconnection.Close();
            return TechnicalConnection;

        }
    }

}

