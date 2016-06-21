using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//Add MySql Library
using MySql.Data.MySqlClient;
using Microsoft.Win32;
using System.Windows.Media.Imaging;
using System.IO;

namespace MagicCardOrganizer.Models
{
    class MagicCardCollectionModel
    {
        public MagicCardCollectionModel()
        {
            Initialize();
        }


        private MySqlConnection connection;
        private String server;
        private String database;
        private String uid;
        private String password;

        //Initialize values
        private void Initialize()
        {
            server = "10.100.16.40";
            database = "magic";
            uid = "username";
            password = "password";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            //OpenConnection();
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        //Close connection
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

        }

        public byte[] GetBlobDataForImage(Card cardToInsert)
        {
            byte[] data;
            JpegBitmapEncoder encoder = new JpegBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(cardToInsert.Image));
            using (MemoryStream ms = new MemoryStream())
            {
                encoder.Save(ms);
                data = ms.ToArray();
            }
            return data;
        }

        //Insert statement
        public void Insert(Card cardToInsert)
        {
            byte[] dataToWriteToBlob = this.GetBlobDataForImage(cardToInsert);
            // From byte array to string
            string stringToWriteToBlob = System.Text.Encoding.UTF8.GetString(dataToWriteToBlob, 0, dataToWriteToBlob.Length);

            string query = "INSERT INTO card (Name, Power, Defense, Special, Image) VALUES(@NAME, @POWER, @DEFENSE, @SPECIAL, @IMAGE)";

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("@NAME",MySqlDbType.VarString);
                cmd.Parameters.Add("@POWER",MySqlDbType.Int16);
                cmd.Parameters.Add("@DEFENSE",MySqlDbType.Int16);
                cmd.Parameters.Add("@SPECIAL",MySqlDbType.VarString);
                cmd.Parameters.Add("@IMAGE",MySqlDbType.Blob);
                cmd.Parameters["@NAME"].Value = cardToInsert.Name;
                cmd.Parameters["@POWER"].Value = cardToInsert.Power;
                cmd.Parameters["@DEFENSE"].Value = cardToInsert.Defense;
                cmd.Parameters["@SPECIAL"].Value = cardToInsert.Special;
                cmd.Parameters["@IMAGE"].Value = dataToWriteToBlob;



        
                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update()
        {
        }

        //Delete statement
        public void Delete()
        {
        }

        //Select statement
        public List<String>[] Select()
        {
            return new List<String>[2];
        }

        //Count statement
        public int Count()
        {
            return 0;
        }

        //Backup
        public void Backup()
        {
        }

        //Restore
        public void Restore()
        {
        }
    }
}
