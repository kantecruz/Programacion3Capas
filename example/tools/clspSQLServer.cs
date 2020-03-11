using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace example.tools
{
    public class clspSQLServer
    {
        private SqlConnection _connection;
        private SqlTransaction _transaction;
        private SqlCommand _command;
        private SqlDataReader _dataReader;
        private String _connectionString;

        private SqlConnection connection{
            get{
                return _connection;
            }
            set{
                _connection = value;
            }
        }
        private SqlTransaction transaction{
            get{
                return _transaction;
            }
            set{
                _transaction = value;
            }
        }
        private SqlCommand command{
            get{
                return _command;
            }
            set{
                _command = value;
            }
        }
        private SqlDataReader dataReader{
            get{
                return _dataReader;
            }
            set{
                _dataReader = value;
            }
        }
        private String connectionString{
            get{
                return _connectionString;
            }
            set{
                _connectionString = value.Trim();
            }
        }

        public clspSQLServer()
        {
            this.connection = new SqlConnection();
            this.command = new SqlCommand();
            this.connectionString = "Data Source=SERV;Database=db_almacen;User ID=USER; Password=***";
        }

        public void openConnection()
        {
            try{
                connection.ConnectionString = this.connectionString;
                connection.Open();
            }
            catch (SqlException vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public void closeConnection()
        {
            try{
                connection.Close();
            }
            catch (SqlException vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public SqlDataReader executeQuery(String vsql)
        {
            try{
                this.command.Connection = this.connection;
                this.command.Transaction = this.transaction;
                this.command.CommandText = vsql.Trim();
                this.command.CommandType = CommandType.Text;
                this.dataReader= this.command.ExecuteReader();
                
                return this.dataReader;
            }
            catch (SqlException vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public void closeQuery()
        {
            try{
                this.dataReader.Close();
            }
            catch (SqlException vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public Int32 executeNonQuery(String vsql)
        {
            try{
                this.command.Connection = this.connection;
                this.command.Transaction = this.transaction;
                this.command.CommandText = vsql.Trim();
                this.command.CommandType = CommandType.Text;
                return this.command.ExecuteNonQuery();
            }
            catch (SqlException vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public void beginTransaction()
        {
            try{
                this.transaction=this.connection.BeginTransaction();
            }
            catch (SqlException vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public void commitTransaction()
        {
            try{
                this.transaction.Commit();
            }
            catch (Exception vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }

        public void rollbackTransaction()
        {
            try{
                this.transaction.Rollback();
            }
            catch (Exception vexception){
                throw new Exception(vexception.Message, vexception.InnerException);
            }
        }


        ~clspSQLServer() { }
    }
}