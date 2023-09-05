﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventController
{
    internal class db
    {


        public static string Connection_String()
        {
            return @"Data Source=.\SQLEXPRESS;Initial Catalog=cse299;User Id=ggwp;password=123;TrustServerCertificate=True";
        }

        public class Set
        {

        }

        public class Post
        {
            public static void InsertNewTeam(string TeamID, string TeamName, string Image, string Banner,
                string OwnerImage, string OwnerName, string ManagerImage, string ManagerName,
                string TeamShortName)
            {
                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    using (SqlCommand cmd = new SqlCommand("InsertNewTeam", connection))
                    {
                        connection.Open();
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("@TeamID", TeamID);
                        cmd.Parameters.AddWithValue("@TeamName", TeamName);
                        cmd.Parameters.AddWithValue("@Image", Image);
                        cmd.Parameters.AddWithValue("@Banner", Banner);
                        cmd.Parameters.AddWithValue("@OwnerImage", OwnerImage);
                        cmd.Parameters.AddWithValue("@OwnerName", OwnerName);
                        cmd.Parameters.AddWithValue("@ManagerImage", ManagerImage);
                        cmd.Parameters.AddWithValue("@ManagerName", ManagerName);
                        cmd.Parameters.AddWithValue("@DateTime", DateTime.Now);
                        cmd.Parameters.AddWithValue("@TeamShortName", TeamShortName);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            


            public static void InsertNewAdminDetails(
                string adminID, string name, string email, 
                string address, string phoneNumber, string nid, 
                string password
            )
            {
                using (SqlConnection connection = new SqlConnection(db.Connection_String()))
                {
                    using (SqlCommand command = new SqlCommand("InsertNewAdminDetails", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@AdminID", adminID);
                        command.Parameters.AddWithValue("@Name", name);
                        command.Parameters.AddWithValue("@Email", email);
                        command.Parameters.AddWithValue("@Address", address);
                        command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@NID", nid);
                        command.Parameters.AddWithValue("@Password", password);
                        command.Parameters.AddWithValue("@DateNTime", DateTime.Now);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
        }


        public class Get
        {
            public static bool LoginAuth(string email, string password)
            {
                using (SqlConnection con = new SqlConnection(db.Connection_String()))
                {
                    using (SqlCommand cmd = new SqlCommand("SELECT  '#' FROM [cse299].[dbo].[AdminDetails] where [Email]='" + email + "' and [Password]='" + password + "'", con))
                    {
                        con.Open();

                        SqlDataReader sdr = cmd.ExecuteReader();
                        if (sdr.Read())
                        {
                            con.Close();
                            return true;
                        }
                        else
                        {
                            con.Close();
                            return false;
                        }
                    }

                }
            }
        }
    }
}
