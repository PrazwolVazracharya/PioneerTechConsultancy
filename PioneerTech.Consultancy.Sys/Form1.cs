using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PioneerTech.Consultancy.Sys
{
    public partial class Pioneer : Form
    {
        public object DashBoard_EmployeeIdTextBox { get; private set; }

        public Pioneer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void companyDetailsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                String EmployerName = CompanyDeatilsEmployerNameTextBox.Text;
                int ContactNumber = Convert.ToInt32(CompantDetailsContactNumberTextBox.Text);
                String Location = CompanyDetailsLocationTextBox.Text;
                String Website = CompanyDetailsWebsiteTextBox.Text;
                int EmployeeId = Convert.ToInt32(CompanyDetailsEmployeeTextBox.Text);
                SqlConnection mysqlconnection = new SqlConnection();
                mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                             "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

                SqlCommand CompanyDetailCommand = new SqlCommand("INSERT INTO CompanyDetail VALUES(" +
                                     "'" + EmployerName + "'," + ContactNumber + ",'" + Location + "','" + Website + "'," + EmployeeId + ")", mysqlconnection);
                mysqlconnection.Open();
                SqlDataReader DrC = CompanyDetailCommand.ExecuteReader();

                mysqlconnection.Close();
                MessageBox.Show("Datas Saved in the Database");
            }
            catch (Exception exception)
            {
                MessageBox.Show("An Error has Occured, Please contact the Administrator!");
            }
            finally
            {

            }
        }
        private void employeeDetailTabPage_Click(object sender, EventArgs e)
        {

        }



        private void EmployeeDetailsClearButton_Click(object sender, EventArgs e)
        {

        }

        private void employeeDetailSaveButton_Click(object sender, EventArgs e)
        {
            try
            {

                String FirstName = firstNameTextBox.Text;
                String LastName = lastNameTextBox.Text;
                String EmailId = emailIDTextBox.Text;
                long PhoneNumber = Convert.ToInt64(phoneNumberTextBox.Text);
                long AlternatePhoneNumber = Convert.ToInt64(alternatePhoneTextBox.Text);
                String Address1 = address1TextBox.Text;
                String Address2 = address2TextBox.Text;
                String HomeCountry = homeCountryTextBox.Text;
                String CurrentCountry = currentCountryTextBox.Text;
                int ZipCode = Convert.ToInt32(zipcodeTextBox.Text);


                // Creating database connection
                SqlConnection mysqlconnection = new SqlConnection();
                mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                             "database = PioneerTechConsultancy_Database;Integrated security = SSPI";


                SqlCommand cmd = new SqlCommand("INSERT INTO EmployeeDetail VALUES(" +
                             "'" + FirstName + "','" + LastName + "','" + EmailId + "'," +
                             PhoneNumber + "," + AlternatePhoneNumber + ",'" + Address1 + "','" + Address2 +
                             "','" + HomeCountry + "','" + CurrentCountry + "'," + ZipCode + ")", mysqlconnection);
                //Opening Sql Database Connection
                mysqlconnection.Open();
                SqlDataReader Dr = cmd.ExecuteReader();

                mysqlconnection.Close();
                MessageBox.Show("Datas Saved in the Database");
            }
            catch (Exception exception)
            {
                MessageBox.Show("An Error has Occured, Please contact the Administrator!");
            }
            finally
            {

            }
        }

        private void projectDetailsSaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                String ProjectName = ProjectDetailsProjectNameTextBox.Text;
                String ClientName = ProjectDetailsClientNameTextBox.Text;
                String Location = ProjectDetailsLocationTextBox.Text;
                String Roles = ProjectDetailsRolesTextBox.Text;
                int EmployeeId = Convert.ToInt32(ProjectDetailsEmployeeIdTextbox.Text);

                SqlConnection mysqlconnection = new SqlConnection();
                mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
                             "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

                SqlCommand ProjectDetailCommand = new SqlCommand("INSERT INTO ProjectDetail VALUES(" +
                                 "'" + ProjectName + "','" + ClientName + "','" + Location + "','" +
                                 Roles + "'," + EmployeeId + ")", mysqlconnection);

                /*MessageBox.Show("INSERT INTO ProjectDetail VALUES(" +
                                 "'" + ProjectName + "','" + ClientName + "','" + Location + "'," +
                                 Roles + "," + EmployeeId + ")");*/


                mysqlconnection.Open();
                SqlDataReader DrP = ProjectDetailCommand.ExecuteReader();

                mysqlconnection.Close();
                MessageBox.Show("Datas Saved in the Database");
            }
            catch (Exception exception)
            {
                MessageBox.Show("An Error has Occured, Please contact the Administrator!");
            }
            finally
            {

            }

        }


        private void label19_Click_1(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void EmployeeShowDetails_Click(object sender, EventArgs e)
        {
            int EmployeeId = Convert.ToInt32(DashBoard_EmployeeId.Text);

            SqlConnection mysqlconnection = new SqlConnection();
            mysqlconnection.ConnectionString = "Data Source = DESKTOP-6T65F42;" +
            "database = PioneerTechConsultancy_Database;Integrated security = SSPI";

            SqlCommand employeeSqlCommand = new SqlCommand("SELECT * FROM EmployeeDetail WHERE EmployeeId = " + EmployeeId, mysqlconnection);
            SqlCommand projectSqlCommand = new SqlCommand("SELECT * FROM ProjectDetail WHERE EmployeeId = " + EmployeeId, mysqlconnection);
            SqlCommand companySqlCommand = new SqlCommand("SELECT * FROM CompanyDetail WHERE EmployeeId = " + EmployeeId, mysqlconnection);

            mysqlconnection.Open();

            SqlDataReader Dr = employeeSqlCommand.ExecuteReader();
            BindingSource sourceE = new BindingSource();
            sourceE.DataSource = Dr;
            Dr.Close();

            SqlDataReader DrP = projectSqlCommand.ExecuteReader();
            BindingSource sourceP = new BindingSource();
            sourceP.DataSource = DrP;
            DrP.Close();

            SqlDataReader DrC = companySqlCommand.ExecuteReader();
            BindingSource sourceC = new BindingSource();
            sourceC.DataSource = DrC;
            DrC.Close();

            EmployeeDetailGridView.DataSource = sourceE;
            ProjectDetailsGridView.DataSource = sourceP;
            CompanyDetailsGridView.DataSource = sourceC;

        }
    }
}
