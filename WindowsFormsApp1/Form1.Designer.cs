
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtNameServidor = new System.Windows.Forms.TextBox();
            this.btnConectarServidor_Click = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDatabases = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckbSchema = new System.Windows.Forms.CheckBox();
            this.ckbView = new System.Windows.Forms.CheckBox();
            this.ckbTriggers = new System.Windows.Forms.CheckBox();
            this.ckbFunction = new System.Windows.Forms.CheckBox();
            this.ckbStoreProcedures = new System.Windows.Forms.CheckBox();
            this.ckbTabla = new System.Windows.Forms.CheckBox();
            this.btnGetAllObject = new System.Windows.Forms.Button();
            this.Busquedas = new System.Windows.Forms.GroupBox();
            this.btnBuscarObject = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.dvConsultaObjects = new System.Windows.Forms.DataGridView();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.dvReferenciasConstraint = new System.Windows.Forms.DataGridView();
            this.dvPrimaryKeyUnique = new System.Windows.Forms.DataGridView();
            this.dvColumnasDefinicion = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.Busquedas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsultaObjects)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvReferenciasConstraint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPrimaryKeyUnique)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvColumnasDefinicion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox6);
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Location = new System.Drawing.Point(12, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(648, 310);
            this.panel4.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtNameServidor);
            this.groupBox6.Controls.Add(this.btnConectarServidor_Click);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Controls.Add(this.cbDatabases);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtPassword);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.txtUser);
            this.groupBox6.Location = new System.Drawing.Point(21, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(609, 177);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Conectar Servidor";
            // 
            // txtNameServidor
            // 
            this.txtNameServidor.Location = new System.Drawing.Point(81, 29);
            this.txtNameServidor.Name = "txtNameServidor";
            this.txtNameServidor.Size = new System.Drawing.Size(396, 22);
            this.txtNameServidor.TabIndex = 1;
            // 
            // btnConectarServidor_Click
            // 
            this.btnConectarServidor_Click.Location = new System.Drawing.Point(499, 59);
            this.btnConectarServidor_Click.Name = "btnConectarServidor_Click";
            this.btnConectarServidor_Click.Size = new System.Drawing.Size(90, 42);
            this.btnConectarServidor_Click.TabIndex = 0;
            this.btnConectarServidor_Click.Text = "Conectar...";
            this.btnConectarServidor_Click.UseVisualStyleBackColor = true;
            this.btnConectarServidor_Click.Click += new System.EventHandler(this.btnConectarServidor_Click_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Green;
            this.label14.Location = new System.Drawing.Point(218, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "conectando...";
            // 
            // cbDatabases
            // 
            this.cbDatabases.FormattingEnabled = true;
            this.cbDatabases.Location = new System.Drawing.Point(130, 129);
            this.cbDatabases.Name = "cbDatabases";
            this.cbDatabases.Size = new System.Drawing.Size(343, 24);
            this.cbDatabases.TabIndex = 2;
            this.cbDatabases.SelectedIndexChanged += new System.EventHandler(this.cbDatabases_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(230, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 19);
            this.label13.TabIndex = 8;
            this.label13.Text = "Password :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(9, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Servidor : ";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(318, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(155, 22);
            this.txtPassword.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label11.Location = new System.Drawing.Point(17, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "Base de Datos :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "User :";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(81, 69);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(131, 22);
            this.txtUser.TabIndex = 5;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckbSchema);
            this.groupBox5.Controls.Add(this.ckbView);
            this.groupBox5.Controls.Add(this.ckbTriggers);
            this.groupBox5.Controls.Add(this.ckbFunction);
            this.groupBox5.Controls.Add(this.ckbStoreProcedures);
            this.groupBox5.Controls.Add(this.ckbTabla);
            this.groupBox5.Controls.Add(this.btnGetAllObject);
            this.groupBox5.Location = new System.Drawing.Point(21, 195);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(609, 105);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Seleccion de Objetos";
            // 
            // ckbSchema
            // 
            this.ckbSchema.AutoSize = true;
            this.ckbSchema.Location = new System.Drawing.Point(288, 76);
            this.ckbSchema.Name = "ckbSchema";
            this.ckbSchema.Size = new System.Drawing.Size(88, 21);
            this.ckbSchema.TabIndex = 16;
            this.ckbSchema.Text = "Schemas";
            this.ckbSchema.UseVisualStyleBackColor = true;
            // 
            // ckbView
            // 
            this.ckbView.AutoSize = true;
            this.ckbView.Location = new System.Drawing.Point(288, 40);
            this.ckbView.Name = "ckbView";
            this.ckbView.Size = new System.Drawing.Size(59, 21);
            this.ckbView.TabIndex = 15;
            this.ckbView.Text = "View";
            this.ckbView.UseVisualStyleBackColor = true;
            // 
            // ckbTriggers
            // 
            this.ckbTriggers.AutoSize = true;
            this.ckbTriggers.Location = new System.Drawing.Point(130, 76);
            this.ckbTriggers.Name = "ckbTriggers";
            this.ckbTriggers.Size = new System.Drawing.Size(76, 21);
            this.ckbTriggers.TabIndex = 14;
            this.ckbTriggers.Text = "Trigger";
            this.ckbTriggers.UseVisualStyleBackColor = true;
            // 
            // ckbFunction
            // 
            this.ckbFunction.AutoSize = true;
            this.ckbFunction.Location = new System.Drawing.Point(10, 76);
            this.ckbFunction.Name = "ckbFunction";
            this.ckbFunction.Size = new System.Drawing.Size(91, 21);
            this.ckbFunction.TabIndex = 13;
            this.ckbFunction.Text = "Functions";
            this.ckbFunction.UseVisualStyleBackColor = true;
            // 
            // ckbStoreProcedures
            // 
            this.ckbStoreProcedures.AutoSize = true;
            this.ckbStoreProcedures.Location = new System.Drawing.Point(130, 35);
            this.ckbStoreProcedures.Name = "ckbStoreProcedures";
            this.ckbStoreProcedures.Size = new System.Drawing.Size(134, 21);
            this.ckbStoreProcedures.TabIndex = 12;
            this.ckbStoreProcedures.Text = "Store Procedure";
            this.ckbStoreProcedures.UseVisualStyleBackColor = true;
            // 
            // ckbTabla
            // 
            this.ckbTabla.AutoSize = true;
            this.ckbTabla.Location = new System.Drawing.Point(10, 40);
            this.ckbTabla.Name = "ckbTabla";
            this.ckbTabla.Size = new System.Drawing.Size(73, 21);
            this.ckbTabla.TabIndex = 11;
            this.ckbTabla.Text = "Tablas";
            this.ckbTabla.UseVisualStyleBackColor = true;
            // 
            // btnGetAllObject
            // 
            this.btnGetAllObject.Location = new System.Drawing.Point(418, 35);
            this.btnGetAllObject.Name = "btnGetAllObject";
            this.btnGetAllObject.Size = new System.Drawing.Size(171, 42);
            this.btnGetAllObject.TabIndex = 10;
            this.btnGetAllObject.Text = "Cargar Objetos";
            this.btnGetAllObject.UseVisualStyleBackColor = true;
            this.btnGetAllObject.Click += new System.EventHandler(this.btnGetAllObject_Click);
            // 
            // Busquedas
            // 
            this.Busquedas.Controls.Add(this.btnBuscarObject);
            this.Busquedas.Controls.Add(this.txtBuscar);
            this.Busquedas.Controls.Add(this.label16);
            this.Busquedas.Controls.Add(this.dvConsultaObjects);
            this.Busquedas.Location = new System.Drawing.Point(11, 320);
            this.Busquedas.Name = "Busquedas";
            this.Busquedas.Size = new System.Drawing.Size(649, 302);
            this.Busquedas.TabIndex = 1;
            this.Busquedas.TabStop = false;
            this.Busquedas.Text = "Busquedas";
            // 
            // btnBuscarObject
            // 
            this.btnBuscarObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarObject.ForeColor = System.Drawing.Color.Navy;
            this.btnBuscarObject.Location = new System.Drawing.Point(521, 28);
            this.btnBuscarObject.Name = "btnBuscarObject";
            this.btnBuscarObject.Size = new System.Drawing.Size(110, 32);
            this.btnBuscarObject.TabIndex = 10;
            this.btnBuscarObject.Text = "&Consultar...";
            this.btnBuscarObject.UseVisualStyleBackColor = true;
            this.btnBuscarObject.Click += new System.EventHandler(this.btnBuscarObject_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(89, 33);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(426, 22);
            this.txtBuscar.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(12, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 19);
            this.label16.TabIndex = 11;
            this.label16.Text = "Buscar : ";
            // 
            // dvConsultaObjects
            // 
            this.dvConsultaObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvConsultaObjects.Location = new System.Drawing.Point(6, 69);
            this.dvConsultaObjects.Name = "dvConsultaObjects";
            this.dvConsultaObjects.RowHeadersWidth = 51;
            this.dvConsultaObjects.RowTemplate.Height = 24;
            this.dvConsultaObjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvConsultaObjects.Size = new System.Drawing.Size(625, 223);
            this.dvConsultaObjects.TabIndex = 0;
            this.dvConsultaObjects.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvConsultaObjects_CellClick);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label19);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.dvReferenciasConstraint);
            this.groupBox7.Controls.Add(this.dvPrimaryKeyUnique);
            this.groupBox7.Controls.Add(this.dvColumnasDefinicion);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.ForeColor = System.Drawing.Color.Green;
            this.groupBox7.Location = new System.Drawing.Point(666, 2);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(731, 622);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Detalles de Objetos";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Green;
            this.label19.Location = new System.Drawing.Point(6, 318);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 17);
            this.label19.TabIndex = 17;
            this.label19.Text = "Primary Key y Unique";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Green;
            this.label18.Location = new System.Drawing.Point(6, 499);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(167, 17);
            this.label18.TabIndex = 16;
            this.label18.Text = " Referencias y Constraint";
            // 
            // dvReferenciasConstraint
            // 
            this.dvReferenciasConstraint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvReferenciasConstraint.Location = new System.Drawing.Point(12, 520);
            this.dvReferenciasConstraint.Name = "dvReferenciasConstraint";
            this.dvReferenciasConstraint.RowHeadersWidth = 51;
            this.dvReferenciasConstraint.RowTemplate.Height = 24;
            this.dvReferenciasConstraint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvReferenciasConstraint.Size = new System.Drawing.Size(716, 90);
            this.dvReferenciasConstraint.TabIndex = 14;
            // 
            // dvPrimaryKeyUnique
            // 
            this.dvPrimaryKeyUnique.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvPrimaryKeyUnique.Location = new System.Drawing.Point(9, 340);
            this.dvPrimaryKeyUnique.Name = "dvPrimaryKeyUnique";
            this.dvPrimaryKeyUnique.RowHeadersWidth = 51;
            this.dvPrimaryKeyUnique.RowTemplate.Height = 24;
            this.dvPrimaryKeyUnique.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvPrimaryKeyUnique.Size = new System.Drawing.Size(716, 147);
            this.dvPrimaryKeyUnique.TabIndex = 13;
            // 
            // dvColumnasDefinicion
            // 
            this.dvColumnasDefinicion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvColumnasDefinicion.Location = new System.Drawing.Point(9, 58);
            this.dvColumnasDefinicion.Name = "dvColumnasDefinicion";
            this.dvColumnasDefinicion.RowHeadersWidth = 51;
            this.dvColumnasDefinicion.RowTemplate.Height = 24;
            this.dvColumnasDefinicion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvColumnasDefinicion.Size = new System.Drawing.Size(716, 242);
            this.dvColumnasDefinicion.TabIndex = 12;
            
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Green;
            this.label15.Location = new System.Drawing.Point(11, 32);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 17);
            this.label15.TabIndex = 10;
            this.label15.Text = "Columnas y definiciòn";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1409, 654);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.Busquedas);
            this.Controls.Add(this.panel4);
            this.Name = "Form1";
            this.panel4.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.Busquedas.ResumeLayout(false);
            this.Busquedas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvConsultaObjects)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvReferenciasConstraint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvPrimaryKeyUnique)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvColumnasDefinicion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCargarObjetos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConectarServidor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbTrigger;
        private System.Windows.Forms.CheckBox ckbFunctions;
        private System.Windows.Forms.CheckBox ckbStoreProcedure;
        private System.Windows.Forms.CheckBox ckbTablas;
        private System.Windows.Forms.Button btnConsultarObjetos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBuscarDescripcionObjetos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscarObjetos;
        private System.Windows.Forms.DataGridView dvCargaObjetos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDefinicionObjetos;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnConectarServidor_Click;
        private System.Windows.Forms.TextBox txtNameServidor;
        private System.Windows.Forms.ComboBox cbDatabases;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGetAllObject;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckbSchema;
        private System.Windows.Forms.CheckBox ckbView;
        private System.Windows.Forms.CheckBox ckbTriggers;
        private System.Windows.Forms.CheckBox ckbFunction;
        private System.Windows.Forms.CheckBox ckbStoreProcedures;
        private System.Windows.Forms.CheckBox ckbTabla;
        private System.Windows.Forms.GroupBox Busquedas;
        private System.Windows.Forms.DataGridView dvConsultaObjects;
        private System.Windows.Forms.Button btnBuscarObject;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dvReferenciasConstraint;
        private System.Windows.Forms.DataGridView dvPrimaryKeyUnique;
        private System.Windows.Forms.DataGridView dvColumnasDefinicion;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
    }
}

