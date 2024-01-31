using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Encoders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment6_6422770345
{
    public class infoDAO
    {
        public static List<info> info_try = new List<info>();
        public static string connectionString = "datasource=localhost;port=3306;username=root;password=root;database=db_6422770345_lab6;";


    public static int addOneRecord(info a1)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `signup`(`ID`,`First_Name`, `Last_Name`, `Sex`, `BirthDate`, `Email`, `Occupation`) VALUES (@ID, @fname, @lname, @sex, @birthdate, @email, @occupation)", connect);
            cmd.Parameters.AddWithValue("@ID", a1.ID);
            cmd.Parameters.AddWithValue("@fname", a1.fName);
            cmd.Parameters.AddWithValue("@lname", a1.LName);
            cmd.Parameters.AddWithValue("@sex", a1.Sex);
            cmd.Parameters.AddWithValue("@birthdate", a1.Bdate);
            cmd.Parameters.AddWithValue("@email", a1.Email);
            cmd.Parameters.AddWithValue("@Occupation", a1.Occup);
            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;
        }
        public static int addOneRecord_login(logininfo a1)
        {
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `login`(`User_ID`,`Signup_ID`, `Username`, `Password`) VALUES (@uID, @rID, @uName, @Pass)", connect);
            cmd.Parameters.AddWithValue("@uID", a1.uID);
            cmd.Parameters.AddWithValue("@rID", a1.rID);
            cmd.Parameters.AddWithValue("@uName", a1.uName);
            cmd.Parameters.AddWithValue("@Pass", a1.Pass);
            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;
        }

        public List<info> getAll()
        {
            List<info> returnall = new List<info>();
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM signup", connect);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    info ret = new info
                    {
                        ID = reader.GetInt32(0),
                        fName = reader.GetString(1),
                        LName = reader.GetString(2),
                        Sex = reader.GetString(3),
                        Bdate = reader.GetString(4),
                        Email = reader.GetString(5),
                        Occup = reader.GetString(6)
                    };
                    returnall.Add(ret);
                }
            }
            connect.Close();
            return returnall;

        }
        public List<logininfo> getAll_login()
        {
            List<logininfo> returnall_login = new List<logininfo>();
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM login", connect);
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    logininfo ret = new logininfo
                    {
                        uID = reader.GetInt32(0),
                        rID = reader.GetInt32(1),
                        uName = reader.GetString(2),
                        Pass = reader.GetString(3),
                    };
                    returnall_login.Add(ret);
                }
            }
            connect.Close();
            return returnall_login;

        }

        internal int deleteOneRecord(int id_row)
        {
            /*(g) If a user deletes his record in the user page, his login information
            should also be deleted as well.*/

            MySqlConnection connect = new
            MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `signup` WHERE `signup`.`ID` = @ID",
            connect);
            cmd.Parameters.AddWithValue("@ID", id_row);
            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;

        }

        internal int updateOneRecord(info a1)
        {
            /*
                (h) A user is allowed to update only his details.*/
            MySqlConnection connect = new MySqlConnection(connectionString);
            connect.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE signup SET First_Name = @fname, Last_Name = @lname, Sex = @sex, BirthDate = @birthdate, Email = @email, Occupation = @Occupation WHERE ID = @ID", connect);
            cmd.Parameters.AddWithValue("@ID", a1.ID);
            cmd.Parameters.AddWithValue("@fname", a1.fName);
            cmd.Parameters.AddWithValue("@lname", a1.LName);
            cmd.Parameters.AddWithValue("@sex", a1.Sex);
            cmd.Parameters.AddWithValue("@birthdate", a1.Bdate);
            cmd.Parameters.AddWithValue("@email", a1.Email);
            cmd.Parameters.AddWithValue("@Occupation", a1.Occup);
            int newRows = cmd.ExecuteNonQuery();
            connect.Close();
            return newRows;
        }
    }
    
}
