using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography;
using System.IO;


namespace Exampleproject
{
    static public class SqlCom
    {
        private static string conecstring = ConfigurationManager.ConnectionStrings["connectionstr"].ConnectionString;
        private static SqlCommand Command;
        private static SqlConnection connection;
        private static DataTable Table;
        private static SqlDataAdapter Adapter;

        public static bool FechDoctor(string username)
        {   
            // აბრუნებს არსებობს თუ არა ეგ ექიმი
            connection= new SqlConnection(conecstring);
            Command.CommandType = CommandType.StoredProcedure;
            Command = new SqlCommand("FechDoctor", connection);
            SqlParameter param = new SqlParameter("@Username",SqlDbType.VarChar);
            param.Value = username;
            Command.Parameters.Add(param);

            
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();
            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);

            if (Table.Rows.Count==0 || Table.Rows.Count==null)
            {
                return true;
            }
            return false;
        }
        public static bool FechPatient(string username)
        {   
            // აბრუნებს არსებობს თუ არა პაციენტი
            
            connection = new SqlConnection(conecstring);
            Command.CommandType = CommandType.StoredProcedure;
            Command = new SqlCommand("FechPatient", connection);
            SqlParameter param = new SqlParameter("@Username", SqlDbType.VarChar);
            param.Value = username;
            Command.Parameters.Add(param);

            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();

            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);
            if (Table.Rows.Count == 0 || Table.Rows.Count == null)
            {
                return true;
            }
            return false;
        }

        public static void Register_Doctor(string Name ,string LastName,string Username,string passcode,string Speciallity,string Bio,string discription)
        {   
            //არეგისტრირებს ექმის
            connection = new SqlConnection(conecstring);
            Command.CommandType = CommandType.StoredProcedure;
            Command = new SqlCommand("Register_Doctor", connection);
            SqlParameter[] param = new SqlParameter[7];
            param[0] = new SqlParameter("@Name",SqlDbType.VarChar);
            param[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[2] = new SqlParameter("@Username",SqlDbType.VarChar);
            param[3] = new SqlParameter("@passcode", SqlDbType.VarChar);
            param[4] = new SqlParameter("@Speciallity", SqlDbType.VarChar);
            param[5] = new SqlParameter("@Bio", SqlDbType.VarChar);
            param[6] = new SqlParameter("@discription", SqlDbType.VarChar);

            param[0].Value = Name;
            param[1].Value = LastName;
            param[2].Value = Username;
            param[3].Value = passcode;
            param[4].Value = Speciallity;
            param[5].Value = Bio;
            param[6].Value = discription;
            Command.Parameters.AddRange(param);

         
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
     
        }
        public static void Register_Patient(string Name, string LastName, string Username, string passcode, string Bio)
        {   
            // არეგისტრირებს პაციენტს 
            connection = new SqlConnection(conecstring);
            Command.CommandType = CommandType.StoredProcedure;
            Command = new SqlCommand("Register_Patient", connection);
            SqlParameter[] param = new SqlParameter[4];
            param[0] = new SqlParameter("@Name", SqlDbType.VarChar);
            param[1] = new SqlParameter("@LastName", SqlDbType.VarChar);
            param[2] = new SqlParameter("@Username", SqlDbType.VarChar);
            param[3] = new SqlParameter("@passcode", SqlDbType.VarChar);
            param[4] = new SqlParameter("@Bio", SqlDbType.VarChar);


            param[0].Value = Name;
            param[1].Value = LastName;
            param[2].Value = Username;
            param[3].Value = passcode;
            param[4].Value = Bio;

         
            Command.Parameters.AddRange(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();

        }
        public static DataTable GetMesseges(string username)
        {   
            //ყველა შენ მესსიგს გიბრუნებს
            connection = new SqlConnection(conecstring);
            Command.CommandType = CommandType.StoredProcedure;
            Command = new SqlCommand("GetMesseges", connection);
            SqlParameter param = new SqlParameter("@Username", SqlDbType.Int);
            param.Value = username;
            Command.Parameters.Add(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
            Table = new DataTable();
            Adapter = new SqlDataAdapter(Command);
            Adapter.Fill(Table);
            string temp;
            DataRow[] tempRow = Table.Select();
            for (int i = 0; i < Table.Rows.Count; i++)
            {

              
                    for (int j = 0; j < Table.Columns.Count; j++)
                {
                    if (j!=0) {
                        temp = Exampleproject.Encrypte.Decrypt(tempRow[i][j].ToString()).ToString();
                    }
                    else
                    {
                        temp = tempRow[i][j].ToString();
                    }        
    
                }
              
                        
            }
            Table.Clear();
            Table.Rows.Add(tempRow);
            return Table;
        }

        public static void SendMessege(int id,string type,string setto,string messege)
        {   
            //მესსიჯს აგზავნის
            connection = new SqlConnection(conecstring);
            Command.CommandType = CommandType.StoredProcedure;
            Command = new SqlCommand("SendMessege", connection);
            SqlParameter[] param = new SqlParameter[4];
            param[0]= new SqlParameter("@Id", SqlDbType.Int);
            param[1] = new SqlParameter("@type", SqlDbType.VarChar);
            param[2] = new SqlParameter("@sentto", SqlDbType.VarChar);
            param[3] = new SqlParameter("@messege", SqlDbType.VarChar);


            param[0].Value = id;
            param[1].Value = Exampleproject.Encrypte.Encrypt(type);
            param[2].Value = Exampleproject.Encrypte.Encrypt(setto);
            param[3].Value = Exampleproject.Encrypte.Encrypt( messege);
            Command.Parameters.AddRange(param);
            connection.Open();
            Command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
