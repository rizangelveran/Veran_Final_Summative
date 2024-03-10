using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace DataHelper
{
    public class DataAccess
    {

        #region     //variables
        string usertype; 
        string moviename,moviegenre;
        decimal rentalfee;
        string currentMovieName;
        public string Usertype { get => usertype; set => usertype = value; }
        public string CurrentMovieName { get => currentMovieName; set => currentMovieName = value; }
        public string Moviename { get => moviename; set => moviename = value; }
        public string Moviegenre { get => moviegenre; set => moviegenre = value; }
        public decimal Rentalfee { get => rentalfee; set => rentalfee = value; }
        #endregion

        //encryptor
        public string EncryptData(string userPassword)
        {
            MD5CryptoServiceProvider hashVal = new MD5CryptoServiceProvider();
            byte[] totalByte = Encoding.ASCII.GetBytes(userPassword);
            byte[] hbytes = hashVal.ComputeHash(totalByte);

            StringBuilder stringBuilder = new StringBuilder();
            for (int c = 0; c < hbytes.Length; c++)
            {
                stringBuilder.AppendFormat("{0:x2}", hbytes[c]);
            }
            return (stringBuilder.ToString());
        }

        //for database
        static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\OneDrive - De La Salle University-Dasmariñas\BIT33(SEM1)\zsherp\vizual studio\Veran_Final_Summative\DBcf.mdf;Integrated Security=True";
        SqlConnection myConn = new SqlConnection(ConnStr);


#region//    =========== ------------ USER ------------ ===========
        public bool CheckAccount(string userName, string userPass)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("CheckValidAccount", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = userName;
            readCmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = userPass;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();

            while (dr.Read())
            {
                found = true;
                Usertype = dr.GetString(6);
                break;
            }
            myConn.Close();
            return found;
        }
        
        public void SaveNewAcct(string fname, string lname, string userName,string userPassword, int getAge)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("AddNewRecord", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@fname", SqlDbType.NVarChar).Value = fname;
            saveCmd.Parameters.Add("@lname", SqlDbType.NVarChar).Value = lname;
            saveCmd.Parameters.Add("@username", SqlDbType.NVarChar).Value = userName;
            saveCmd.Parameters.Add("@password", SqlDbType.NVarChar).Value = userPassword;
            saveCmd.Parameters.Add("@age", SqlDbType.Decimal).Value = getAge;
            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        //edit

        public void ChangeNewPass(string getUserName, string getPassword)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("ChangeUserPass", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@userName", SqlDbType.NVarChar).Value = getUserName;
            saveCmd.Parameters.Add("@newpassword", SqlDbType.NVarChar).Value = getPassword;
            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }


        //view all users
        public DataTable ViewAllUsers()
        {
            SqlDataAdapter viewAllMem = new SqlDataAdapter("ViewAllMovies", myConn);
            viewAllMem.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            viewAllMem.Fill(dt);
            return dt;
        }

        //view rented movie by user

        public DataTable GetRentedMovie(string getLogUsers)
        {
            SqlCommand cmdRentedMovie = new SqlCommand("GetRentedMovieByUser", myConn);
            cmdRentedMovie.CommandType = CommandType.StoredProcedure;
            cmdRentedMovie.Parameters.Add("@getUserPurchaser", SqlDbType.NVarChar).Value = getLogUsers;
            SqlDataAdapter viewUserMovie = new SqlDataAdapter(cmdRentedMovie);
            DataTable dx = new DataTable();
            viewUserMovie.Fill(dx);
            return dx;

        }

        #endregion
        #region //    =========== ------------ MOVIE ------------ ===========
        //search Movies
        public DataTable SearchByName(string searchName)
        {
            SqlCommand cmdSearchName = new SqlCommand("MoSearchByName", myConn);
            cmdSearchName.CommandType = CommandType.StoredProcedure;
            cmdSearchName.Parameters.Add("@movName", SqlDbType.NVarChar).Value = searchName;
            SqlDataAdapter viewbyName = new SqlDataAdapter(cmdSearchName);
            DataTable dt = new DataTable();
            viewbyName.Fill(dt);
            return dt;
        }

        public DataTable SearchbyGenre(string searchGenre)
        {
            SqlCommand cmdSearchgenre = new SqlCommand("MoSearchByGenre", myConn);
            cmdSearchgenre.CommandType = CommandType.StoredProcedure;
            cmdSearchgenre.Parameters.Add("@movGenre", SqlDbType.NVarChar).Value = searchGenre;
            SqlDataAdapter viewbyGenre = new SqlDataAdapter(cmdSearchgenre);
            DataTable dt = new DataTable();
            viewbyGenre.Fill(dt);
            return dt;

        }

        //show Movie
        public DataTable ViewAllRecord()
        {
            SqlDataAdapter viewAllMem = new SqlDataAdapter("ViewAllMovies", myConn);
            viewAllMem.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            viewAllMem.Fill(dt);
            return dt;
        }
        //save movie
        public void SaveNewMovie(string getMovieName, string getGenre, decimal getRecFee)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("MovieAdd", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@movName", SqlDbType.NVarChar).Value = getMovieName;
            saveCmd.Parameters.Add("@movGenre", SqlDbType.NVarChar).Value = getGenre;
            saveCmd.Parameters.Add("@renFee", SqlDbType.Decimal).Value = getRecFee;//decimal recfee
            
            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        //edit movie 
        public bool GetSelectedMovie(string formMovieName)
        {
            bool found = false;
            myConn.Open();
            SqlCommand readCmd = new SqlCommand("MovieShow", myConn);
            readCmd.CommandType = CommandType.StoredProcedure;
            readCmd.Parameters.Add("@movName", SqlDbType.NVarChar).Value = formMovieName;
            SqlDataReader dr;
            dr = readCmd.ExecuteReader();

            while (dr.Read())
            {
                found = true;
                Moviename = dr.GetString(0);
               Moviegenre = dr.GetString(1);
               Rentalfee = dr.GetDecimal(2);
                break;
            }
            myConn.Close();
            return found;
        }
        public void EditMovie(string getMovieName, string newMovieName, string newGenre, decimal newRecFee)
        {
            myConn.Open();
            SqlCommand editCmd = new SqlCommand("MovieEdit", myConn);
            editCmd.CommandType = CommandType.StoredProcedure;
            editCmd.Parameters.Add("@movName", SqlDbType.NVarChar).Value = getMovieName;
            editCmd.Parameters.Add("@newmovName", SqlDbType.NVarChar).Value = newMovieName;
            editCmd.Parameters.Add("@movGenre", SqlDbType.NVarChar).Value = newGenre;
            editCmd.Parameters.Add("@renFee", SqlDbType.Decimal).Value = newRecFee;

            editCmd.ExecuteNonQuery();
            myConn.Close();
        }


        //delete movie 
        public void DeleteMovie(string getMovieName)
        {
            myConn.Open();
            SqlCommand deleteCmd = new SqlCommand("MovieDelete", myConn);
            deleteCmd.CommandType = CommandType.StoredProcedure;
            deleteCmd.Parameters.Add("@movName", SqlDbType.NVarChar).Value = getMovieName;
            deleteCmd.ExecuteNonQuery();
            myConn.Close();
        }
        #endregion

        #region //SALES
        //SAVE A NEW SALE



        #endregion

        #region price Calcs
        public Decimal PaymentCal(decimal getDays, decimal getRenFee )
        {
            return getDays * getRenFee;
        }

        public Decimal PaymentChecker(decimal enteredPrice, decimal getTotFee)
        {
            return getTotFee - enteredPrice;

        }

        //Add saving to database function

        public void SaveMovieSale(string getMovieName, string getGenre, decimal getRecFee, decimal getChange, decimal getDuration, string getUsername)
        {
            myConn.Open();
            SqlCommand saveCmd = new SqlCommand("SaveMovie", myConn);
            saveCmd.CommandType = CommandType.StoredProcedure;
            saveCmd.Parameters.Add("@movName", SqlDbType.NVarChar).Value = getMovieName;
            saveCmd.Parameters.Add("@movGenre", SqlDbType.NVarChar).Value = getGenre;
            saveCmd.Parameters.Add("@totalPrice", SqlDbType.Decimal).Value = getRecFee;//totalprice of the transaction value/columns
            saveCmd.Parameters.Add("@change", SqlDbType.Decimal).Value = getChange;
            saveCmd.Parameters.Add("@userPurchaser", SqlDbType.NVarChar).Value = getUsername;
            saveCmd.Parameters.Add("@duration", SqlDbType.Int).Value = getDuration;
            int getCurrYear = DateTime.UtcNow.Year;
            int getCurrDay = DateTime.UtcNow.Day;
            saveCmd.Parameters.Add("@year", SqlDbType.Int).Value = getCurrYear;

            saveCmd.ExecuteNonQuery();
            myConn.Close();
        }

        #endregion
    }
}
