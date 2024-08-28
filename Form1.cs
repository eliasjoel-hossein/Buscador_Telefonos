using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Buscador_Telefonos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string consulta_sql(string documento, string telefono, string cliente)
        {
            string query;

            if (check_clientes.Checked) // Busca solo clientes
            {
                query = "SELECT DISTINCT NRO_DOCUMENTO, TELEFONO, ESTADO, NOMBRE_COMPLETO, ORIGEN, CASE WHEN FLAG_ENVIAR = 1 THEN 'SI' ELSE 'NO' END AS RECIBE_SMS, TIPO, CUIT, NRO_CLIENTE_ID FROM TELEFONOS_CLIENTES WHERE";
                if (documento != "")
                {
                    if (telefono != "")
                    {
                        if (cliente != "")
                        {
                            query += " NRO_DOCUMENTO = " + documento + " AND TELEFONO = " + telefono + " AND NRO_CLIENTE_ID = " + cliente;
                        }
                        else
                        {
                            query += " NRO_DOCUMENTO = " + documento + " AND TELEFONO = " + telefono;
                        }
                    }
                    else
                    {
                        if (cliente != "")
                        {
                            query += " NRO_DOCUMENTO = " + documento + " AND NRO_CLIENTE_ID = " + cliente;
                        }
                        else
                        {
                            query += " NRO_DOCUMENTO = " + documento;
                        }
                    }
                }
                else if (telefono != "")
                {
                    if (cliente != "")
                    {
                        query += " TELEFONO = " + telefono + "AND NRO_CLIENTE_D = " + cliente;
                    }
                    else
                    {
                        query += " TELEFONO = " + telefono;
                    }
                }
                else
                {
                    query += " NRO_CLIENTE_ID = " + cliente;

                }
            }
            else // Busca clientes y no clientes
            {
                query = "SELECT DISTINCT a.NRO_DOCUMENTO, a.TELEFONO, a.ESTADO, b.NOMBRE_COMPLETO, a.ORIGEN, CASE WHEN a.FLAG_ENVIAR = 1 THEN 'SI' ELSE 'NO' END AS RECIBE_SMS, a.TIPO, b.CUIT, b.NRO_CLIENTE_ID FROM CANALES_MAESTRO_TELEFONOS a LEFT JOIN TELEFONOS_CLIENTES b ON a.NRO_DOCUMENTO = b.NRO_DOCUMENTO WHERE";

                if (documento != "")
                {
                    if (telefono != "")
                    {
                        query += " a.NRO_DOCUMENTO = " + documento + " AND a.TELEFONO = " + telefono;
                    }
                    else
                    {
                        query += " a.NRO_DOCUMENTO = " + documento;
                    }
                }
                else
                {
                    query += " a.TELEFONO = " + telefono;
                }
            }
            return query;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            string documento = txt_documento.Text;
            string telefono = txt_telefono.Text;
            string cliente;
            if (txt_cliente.Enabled)
            {
                cliente = txt_cliente.Text;
            }
            else cliente = "";

            // Validar entradas de TextBox
            // 1) Valido que los campos ingresados sean números
            if ((!documento.All(char.IsNumber) && documento != "") || (!telefono.All(char.IsNumber) && telefono != "") || (!cliente.All(char.IsNumber) && cliente != ""))
            {
                MessageBox.Show("Algunos de los campos ingresados no son válidos");
                return;
            }
            // 2) Valido que el número de teléfono sea válido
            if (telefono != "" && telefono.All(char.IsNumber) && telefono.Length != 10)
            {
                MessageBox.Show("El número de teléfono ingresado no es válido. Debe tener 10 dígitos (Cod. Área + Nro). Sin 0 ni 15");
                return;
            }
            // 3) Valido que los campos no sean todos vacíos
            if (documento == "" && telefono == "" && cliente == "")
            {
                MessageBox.Show("Debe ingresar al menos 1 campo de Búsqueda");
                return;
            }

            string query = consulta_sql(documento, telefono, cliente);

            // Creo tabla en nuevo formulario y realizo conexión SQL
            Tabla resultado = new Tabla();
            string conexionSql = "Data Source=CSPMA000DW02;Initial Catalog=DMCOBRANZAS;Integrated Security=True";
            var conexion = new SqlConnection(conexionSql);
            try
            {
                conexion.Open();
                var adaptador = new SqlDataAdapter(query, conexion);
                var ds = new DataSet();
                adaptador.Fill(ds);
                resultado.dgv1.ReadOnly = true;
                resultado.dgv1.DataSource = ds.Tables[0];

                resultado.lbl_info.Text = "(" + resultado.dgv1.ColumnCount + " Campos, " + resultado.dgv1.RowCount + " Registros)";

                resultado.Show();
                conexion.Close();
            }
            catch
            {
                MessageBox.Show("No fue posible conectar a la base de Datos. Verifique sus permisos.");
            }
            
        }

        private void txt_KeyPress_Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_buscar_Click(sender, e);
            }
        }
        private void txt_KeyPress_Escape(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)27)
            {
                this.Close();
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_documento.Text = string.Empty;
            txt_telefono.Text = string.Empty;
            txt_cliente.Text = string.Empty;

        }

        private void check_clientes_CheckedChanged(object sender, EventArgs e)
        {
            if (check_clientes.Checked == true)
            {
                txt_cliente.Enabled = true;
            }
            else
            {
                txt_cliente.Enabled = false;
            }
        }
    }
}
