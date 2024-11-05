using System;
using System.Data;
using V_M_S.BUSSINESS_LAYER;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V_M_S.Properties;
using System.Collections;
using System.Data.Common;

namespace V_M_S.DATA_LAYER
{
    internal class Connection
    {
        public static SqlConnection Connect() 
        {
             string constring = "Data Source=BOSS\\SQLEXPRESS;Initial Catalog=VMS;Integrated Security=True;Encrypt=False";
            SqlConnection connection = new SqlConnection(constring);
            connection.Open();
            return connection;
            //string query = "SELECT * FROM [ADMIN]";
            //SqlCommand cmd = new SqlCommand(query, connection);
            //SqlDataReader reader = cmd.ExecuteReader();
            //connection.Close();
            
        }
        public static SqlDataReader Authentication()
        {
            SqlConnection connection = Connect();
            string query = "Select * FROM [ADMIN];";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader readAuthenticate = cmd.ExecuteReader();
            return readAuthenticate;
        }
        public static SqlDataReader Volunteer_T()
        {
            SqlConnection connection = Connect();
            string query = "SELECT V_NAME,Volunteer_ID,Skills FROM VOLUNTEER";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader readvolunteer_t = cmd.ExecuteReader();
            return readvolunteer_t;
        }
        public static SqlDataReader Project_T()
        {
            SqlConnection connection = Connect();
            string query = "SELECT * FROM PROJECT";
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataReader readproject_t = cmd.ExecuteReader();
            return readproject_t;
        }
        public static void InsertProjectData(Project project)
        {
            using (SqlConnection myConnection = Connect())
            {
                string query = "INSERT INTO PROJECT (ProjectID, ProjectName, Description) VALUES (@ProjectID, @ProjectName, @Description)";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", new Project());
                    cmd.Parameters.AddWithValue("@ProjectName", new Project());
                    cmd.Parameters.AddWithValue("@Description", new Project());

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void InsertvolunteerData(Volunteer volunteer)
        {
            using (SqlConnection myConnection = Connect())
            {
                string query = "INSERT INTO VOLUNTEER (Volunteer_ID, V_Name, Skills) VALUES (@VolunteerID, @VName, @Skills)";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@VolunteerID", new Volunteer());
                    cmd.Parameters.AddWithValue("@VName", new Volunteer());
                    cmd.Parameters.AddWithValue("@Skills", new Volunteer());

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InsertvolunteerloginData(Volunteer volunteer)
        {
            using (SqlConnection myConnection = Connect())
            {
                string query = "INSERT INTO VOLUNTEER (Volunteer_ID, V_Name, Email, Skills, V_Availability, Registration_Date) " +
                               "VALUES (@VolunteerID, @VName, @Email, @Skills, @Availability, @RegistrationDate)";

                using (SqlCommand cmd = new SqlCommand(query, myConnection))
                {
                    cmd.Parameters.AddWithValue("@VolunteerID",new Volunteer());
                    cmd.Parameters.AddWithValue("@VName", new Volunteer());
                    cmd.Parameters.AddWithValue("@Email", new Volunteer());
                    cmd.Parameters.AddWithValue("@Skills", new Volunteer());
                    cmd.Parameters.AddWithValue("@Availability", new Volunteer());
                    cmd.Parameters.AddWithValue("@RegistrationDate", new Volunteer());

                    myConnection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeletevolunteerDetails(string  Volunteer_Name)
        {
            SqlConnection myConnection = Connect();
            string query = "DELETE FROM VOLUNTEER where VOLUNTEER.V_Name = '" + Volunteer_Name + "';";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            cmd.ExecuteNonQuery();
        }
        public static void DeleteprojectDetails(string project_id)
        {
            SqlConnection myConnection = Connect();
            string query = "DELETE FROM PROJECT where PROJECT.ID = '" + project_id + "'; ";
            SqlCommand cmd = new SqlCommand(query, myConnection);
            cmd.ExecuteNonQuery();
        }
    }
}
