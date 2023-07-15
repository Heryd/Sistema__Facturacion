using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

/*GRUPO G03 - INTEGRANTES
 * Morla Gordillo Heryd Xavier (Líder)
 * Sánchez Vargas Bryan Jonas
 * Solorzano Terán Petter Max
 * Valencia Quintero Angelo Jardel
*/

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_Actualizar_Factura : Form
    {
        //Fields
        CN_GetData objCapaNegocio = new CN_GetData();
        public Frm_Actualizar_Factura()
        {
            InitializeComponent();
            txt_fecha.Text = Get_Date();
        }

        //Obtener la fecha actual en formato "([día de la semana], [Mes] [número], [año])"
        private string Get_Date() => objCapaNegocio.ObtenerFechaActual();

        //Cerrar el Formulario
        private void btn_CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Verifica si los campos se han llenado correctamente, de lo contrario presenta unm mensaje de alerta
        private bool ValidarCampos()
        {
            string mensajeValidacion = "";
            int confirm = -1;
            if (string.IsNullOrWhiteSpace(txt_Nombre_Encargado.Texts))
            {
                mensajeValidacion += "\n\t- Nombre del Encargado";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Descripcion.Text))
            {
                mensajeValidacion += "\n\t- Descripción del Servicio";
                confirm++;
            }
            if (string.IsNullOrWhiteSpace(txt_Precio_Unitario.Texts))
            {
                mensajeValidacion += "\n\t- Precio Unitario del Servicio";
                confirm++;
            }
            if (mensajeValidacion.Length > 0 || !string.IsNullOrWhiteSpace(mensajeValidacion))
            {
                MessageBox.Show("Por favor, llene y/o seleccione los campos de: " + mensajeValidacion, "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return (confirm >= 0 ? false : true);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos()) 
            { 

            }
        }
    }
}
