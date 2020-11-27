using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using Utilitario.Acceso.BaseDatos.Models;
using WindowsFormsApp1.Models;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        string nombreTabla = "";


        public Form1()
        {
            InitializeComponent();
        }

        private Databases baseDatosReader(SqlDataReader reader)
        {
            int posName = reader.GetOrdinal("name");
            int poscreateDate = reader.GetOrdinal("create_date");
            return new Databases()
            {
                Name = reader.GetString(posName),
                createDate = reader.GetDateTime(poscreateDate),
            };
        }
        private void btnConectarServidor_Click_Click(object sender, EventArgs e)
        {
            string cadenaConn = $"server={txtNameServidor.Text.Trim()};database=master;Trusted_Connection=True";
            List<Databases> lstBaseDatos = null;
            cbDatabases.DataSource = null;
            SqlConnection conexion = new SqlConnection(cadenaConn);
            conexion.Open();

            string queryDatabase = "select name,create_date from sys.databases where name not in('master','tempdb','model','msdb')";
            SqlCommand cmd = new SqlCommand(queryDatabase, conexion);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                lstBaseDatos = new List<Databases>();
                while (reader.Read())
                {
                    lstBaseDatos.Add(baseDatosReader(reader));
                }
            }
            cbDatabases.DataSource = lstBaseDatos;
            cbDatabases.DisplayMember = "Name";
            cbDatabases.ValueMember = "Name";
        }
        private void btnGetAllObject_Click(object sender, EventArgs e)
        {
            List<Objetos> lstObjetos = null;
            dvConsultaObjects.DataSource = null;
            string cadenaConn = $"server={txtNameServidor.Text.Trim()};database=master;Trusted_Connection=True";
            SqlConnection conexion = new SqlConnection(cadenaConn);
            conexion.Open();
            string queryTablas = $" use {cbDatabases.SelectedValue} SELECT T.object_id,T.name,Schema_name(T.schema_id) AS SchemaName,T.create_date FROM SYS.tables T";

            SqlCommand cmd = new SqlCommand(queryTablas, conexion);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                lstObjetos = new List<Objetos>();
                while (reader.Read())
                {
                    lstObjetos.Add(ObjetosReader(reader));
                }
            }

            dvConsultaObjects.DataSource = lstObjetos;
        }

        private Objetos ObjetosReader(SqlDataReader reader)
        {
            int posObjectId = reader.GetOrdinal("object_id");
            int posName = reader.GetOrdinal("name");
            int posSchemaName = reader.GetOrdinal("SchemaName");
            int poscreateDate = reader.GetOrdinal("create_date");

            return new Objetos()
            {
                ObjectId = reader.GetInt32(posObjectId).ToString(),
                Name = reader.GetString(posName),
                SchemaName = reader.GetString(posSchemaName),
                CreateDate = reader.GetDateTime(poscreateDate),
            };
        }
        private void btnBuscarObject_Click(object sender, EventArgs e)
        {
            List<DefinicionColumnas> lstDefinicionColumnas = null;
            List<DefinicionTablaIndex> lstDefinicionTablaIndex = null;
            List<DefinicionTablaConstraint> lstDefinicionTablaConstraint = null;


            string cadenaConn = $"server={txtNameServidor.Text.Trim()};database=master;Trusted_Connection=True";
            SqlConnection conexion = new SqlConnection(cadenaConn);
            conexion.Open();
            string queryColumnas = $" use {cbDatabases.SelectedValue} SELECT ORDINAL_POSITION AS OrdinalPostion, COLUMN_NAME as Columna, DATA_TYPE as Type, ISNULL(CHARACTER_MAXIMUM_LENGTH ,0) as Tamaño, IS_NULLABLE as Nulo FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME='{nombreTabla}' SELECT ISNULL(name, 'vacio') as Nombre, isnull(type_desc,'vacio') AS TipoIndex,ISNULL(is_unique,0) as [Unique], isnull(is_primary_key,0) as Primarykey FROM sys.indexes  WHERE [object_id] = OBJECT_ID('{nombreTabla}') SELECT CONSTRAINT_NAME AS ContraintName FROM INFORMATION_SCHEMA.CONSTRAINT_TABLE_USAGE WHERE TABLE_NAME = '{nombreTabla}'";

            SqlCommand cmd = new SqlCommand(queryColumnas, conexion);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader != null)
            {
                lstDefinicionColumnas = new List<DefinicionColumnas>();
                lstDefinicionTablaIndex = new List<DefinicionTablaIndex>();
                lstDefinicionTablaConstraint = new List<DefinicionTablaConstraint>();

                while (reader.Read())
                {
                    lstDefinicionColumnas.Add(DefinicionColumnasReader(reader));
                }

                reader.NextResult();

                while (reader.Read())
                {
                    lstDefinicionTablaIndex.Add(definicionTablaIndexReader(reader));
                }

                reader.NextResult();

                while (reader.Read())
                {
                    lstDefinicionTablaConstraint.Add(definicionTablaConstraint(reader));
                }
            }

            dvColumnasDefinicion.DataSource = lstDefinicionColumnas;
            dvPrimaryKeyUnique.DataSource = lstDefinicionTablaIndex;
            dvReferenciasConstraint.DataSource = lstDefinicionTablaConstraint;

        }

        private DefinicionColumnas DefinicionColumnasReader(SqlDataReader reader)
        {
            int posOrdinalPostion = reader.GetOrdinal("OrdinalPostion");
            int posColumna = reader.GetOrdinal("Columna");
            int posType = reader.GetOrdinal("Type");
            int posTamaño = reader.GetOrdinal("Tamaño");
            int posNulo = reader.GetOrdinal("Nulo");

            return new DefinicionColumnas()
            {
                OrdinalPostion = reader.GetInt32(posOrdinalPostion),
                Columna = reader.GetString(posColumna),
                Type = reader.GetString(posType),
                Tamaño = reader.GetInt32(posTamaño),
                Nulo = reader.GetString(posNulo)
            };
        }

        private DefinicionTablaIndex definicionTablaIndexReader(SqlDataReader reader)
        {
            int posNombre = reader.GetOrdinal("Nombre");
            int posTipoIndex = reader.GetOrdinal("TipoIndex");
            int posUnique = reader.GetOrdinal("Unique");
            int posPrimarykey = reader.GetOrdinal("Primarykey");

            return new DefinicionTablaIndex()
            {
                Nombre = reader.GetString(posNombre),
                TipoIndex = reader.GetString(posTipoIndex),
                Unique = reader.GetBoolean(posUnique),
                Primarykey = reader.GetBoolean(posPrimarykey),
            };
        }

        private DefinicionTablaConstraint definicionTablaConstraint(SqlDataReader reader)
        {
            int posContraintName = reader.GetOrdinal("ContraintName");
            return new DefinicionTablaConstraint()
            {
                ConstraintName = reader.GetString(posContraintName),
            };
        }


        private void dvConsultaObjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nombreTabla = dvConsultaObjects.CurrentRow.Cells["name"].Value.ToString().TrimEnd();
        }

        private void cbDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {
            dvColumnasDefinicion.DataSource = null;
            dvReferenciasConstraint.DataSource = null;
            dvPrimaryKeyUnique.DataSource = null;
            dvConsultaObjects.DataSource = null;
        }
    }
}

