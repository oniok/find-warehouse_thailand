using findwarehouse.models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

/** This is file for connection object 
 * @auther Thanusin Dhammalongkrot
 * @Copyright Siam System Consulting Co.,Ltd.
 **/


namespace findwarehouse.Database
{

    class Connector
    {
        private static Connector Instance = null; //Connector Must have only one Instance in application this is Singleton object Design.
        //For development
        private MySqlConnection mySqlConnect { set; get; } // mysql database connector
        private const String _HOST = "192.168.1.105";//"192.168.1.5"; //host address
        private const String _USER = "dev"; // username database
        private const String _PWD = "12345"; // password database 
        private const String _DATABASE = "find-warehouse_thailand"; //database name
        private const String _SYS_SECURE_INFO = "true"; //system security setting;
        private const String _CHARSET = "utf8"; //charset in database for show

        //For testing
        //private MySqlConnection mySqlConnect { set; get; } // mysql database connector
        //private const String _HOST = "ocean.oniok.com";//"192.168.1.5"; //host address
        //private const String _USER = "find-warehouse"; // username database
        //private const String _PWD = "47fyi-xatv"; // password database 
        //private const String _DATABASE = "find-warehouse_thailand"; //database name
        //private const String _SYS_SECURE_INFO = "true"; //system security setting;
        //private const String _CHARSET = "utf8"; //charset in database for show

        public Connector()
        {
            mySqlConnect = new MySqlConnection(getConnectionString());
        }

        public static Connector getInstance()
        {
            if (Instance == null)
            {
                Instance = new Connector();
            }
            return Instance;
        }

        /** Get Connection String from Confirm **/
        private String getConnectionString()
        {
            StringBuilder _HOST_DATA = new StringBuilder(); // create data for return connection string.
            _HOST_DATA.Append("server = " + _HOST + ";");
            _HOST_DATA.Append("user id = " + _USER + ";");
            _HOST_DATA.Append("password = " + _PWD + ";");
            _HOST_DATA.Append("persistsecurityinfo = " + _SYS_SECURE_INFO + ";");
            _HOST_DATA.Append("database = " + _DATABASE + ";");
            _HOST_DATA.Append("Character Set = " + _CHARSET + ";");
            return _HOST_DATA.ToString();
        }

        /** Open Database **/
        /** return result of connection **/
        public bool OpenDatabase()
        {
            if (mySqlConnect.State == ConnectionState.Open) CloseDatabase();
            try
            {
                mySqlConnect.Open();// open it.
            }
            catch (Exception e)
            {
                CloseDatabase();
                mySqlConnect = null; //set variable to null for return memory.
                System.Windows.Forms.MessageBox.Show(e.Message);//show message when error connect.
                return false; // return false when fail
            }
           
            return true; // return result about connect open connection
        }

        /** Close Connection **/
        public void CloseDatabase()
        {
           try { 
                mySqlConnect.Close(); // force close connection.
               // mySqlConnect.Dispose();// return memory
            }
            catch (Exception)
            {
                mySqlConnect = null;
            }
        }

        /** Get Data as list Can get Whatever from Inherit from IModel in other word whatever model can query **/
        public DataTable GetData(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable dataTable = new DataTable();
            DataSet dataset = new DataSet();
            try
            {
                if (OpenDatabase())
                {
                    adapter.SelectCommand = command;
                    dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    adapter.Fill(dataset,"data");
                    dataTable = dataset.Tables[0];

                }
            }
            catch (Exception e)
            {
                CloseDatabase();
                return null;
            }
            finally
            {
                CloseDatabase();
            }

            return dataTable; //return list
        }

        /** Insert Data **/
        public bool InsertUpdateData(MySqlCommand command)
        {
            try{
                if(OpenDatabase()) command.ExecuteNonQuery(); // execute command
            }catch(Exception e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);//show message when error connect.
                return false; //return false when command error.
            }
            return true; //return true when command no error.
        }

        /** Create Command by no parameter **/
        public MySqlCommand CreateCommand(String commandText)
        {
            return CreateCommand(commandText,null);
        }

        /** Override method from Create Command **/
        public MySqlCommand CreateCommand(String commandText, Dictionary<String,Object> parameters)
        {
            //create command as SqlCommand
            MySqlCommand command = new MySqlCommand();
            command.Connection = mySqlConnect;
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = commandText;

            if (parameters != null)
            {
                foreach(KeyValuePair<String,Object> entry in parameters)
                {
                    if(entry.Value.GetType() == typeof(Int16)) //check datatype is numberic?
                    {
                        command.Parameters.AddWithValue(entry.Key, (Int16)entry.Value);
                    }
                    else if(entry.Value.GetType() == typeof(String))//check datatype is String?
                    {
                        command.Parameters.AddWithValue(entry.Key, (String)entry.Value);
                    }
                }
            }
            return command;
        }
  
    }
}   
    
