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
        /// <summary>
        /// For the beginning the username and password are written down in plain text, if more time remains,
        /// I will implement more security later
        /// </summary>
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
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
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

        /// <summary>
        /// The function establishes a connection to the database, reads the data, and returns a list including all teams.
        /// </summary>
        /// <returns></returns>
        public static List<Team> getStoredTeams()
        {
            try
            {
                SqlConnection con = new SqlConnection(conStrSQL);
                List<Team> teams = new List<Team>();
                string comStr = "SELECT * FROM TeamTable";
                using (SqlCommand cmd = new SqlCommand(comStr, con))
                {
                    con.Open();
                    var reader = cmd.ExecuteReader();
                    con.Close();
                    while (reader.Read())
                    {
                        Team t = new Team { ID = Convert.ToInt32(reader["TeamID"]),
                            Name = reader["TeamName"].ToString(),
                            GK = PlayerBL.getPlayerObject(reader["GK"]),
                            RV = PlayerBL.getPlayerObject(reader["RV"]),
                            IVR = PlayerBL.getPlayerObject(reader["IVR"]),
                            IVL = PlayerBL.getPlayerObject(reader["IVL"]),
                            LV = PlayerBL.getPlayerObject(reader["LV"]),
                            ZDM = PlayerBL.getPlayerObject(reader["ZDM"]),
                            ZML = PlayerBL.getPlayerObject(reader["ZML"]),
                            ZMR = PlayerBL.getPlayerObject(reader["ZMR"]),
                            RS = PlayerBL.getPlayerObject(reader["RS"]),
                            ST = PlayerBL.getPlayerObject(reader["ST"]),
                            LS = PlayerBL.getPlayerObject(reader["LS"]),
                            Score = Convert.ToInt32(reader["Score"]),
                            Won = Convert.ToInt32(reader["Won"]),
                            Lost = Convert.ToInt32(reader["Lost"]),
                            Draw = Convert.ToInt32(reader["Draw"])
                        };
                        teams.Add(t);
                    }
                    reader.Close();
                }
                return teams;
            }
            catch (SqlException)
            {
                throw new Exception("Error occured while trying to access stored teams.");
            }
        }
    }
}
