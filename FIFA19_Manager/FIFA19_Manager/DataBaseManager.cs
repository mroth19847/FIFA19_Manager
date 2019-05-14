using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFA19_Manager
{
    public class DataBaseManager
    {
        private static string conStrSQL = "Data Source=mrrothmssql.database.windows.net;" +
                           "Initial Catalog=FIFA19Manager;" +
                           "User ID=mrooth;" +
                           "Password=4?zvbWJJM?tyY2Q6UBg4";


        /// <summary>
        /// The function stores a team object in the "TeamTable" in the DataBase of following MSSql server: mrrothmssql.database.windows.net
        /// </summary>
        /// <param name="team"></param>
        public static void addTeam(Team team)
        {
            SqlConnection con = new SqlConnection(conStrSQL);
            try
            {
                string comStr = "INSERT INTO TeamTable (TeamName,GK,LV,IVL,IVR,RV,ZDM,ZML,ZMR,RS,LS,ST,Score) VALUES ('" +
                team.Name + "','" + 
                team.GK.ID + "','" +
                team.LV.ID + "','" +
                team.IVL.ID + "','" + 
                team.IVR.ID + "','" + 
                team.RV.ID + "','" + 
                team.ZDM.ID + "','" + 
                team.ZML.ID + "','" + 
                team.ZMR.ID + "','" + 
                team.RS.ID + "','" + 
                team.LS.ID + "','" + 
                team.ST.ID + "','" +
                team.Score + "')";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (SqlException)
            {
                throw new Exception("Error occured while storing the team.");
            }
        }
    }
}
