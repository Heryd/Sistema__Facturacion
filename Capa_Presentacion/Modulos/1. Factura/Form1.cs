using Capa_Negocio;
using Capa_Datos.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf.qrcode;
using iTextSharp.text.pdf;
using iTextSharp.text;
using iTextSharp.tool.xml;
using System.IO;

namespace Capa_Presentacion.Modulos._1._Factura
{
    public partial class Frm_Input_Data_Records : Form
    {

        #region Atributos
        /// <summary>
        /// Ojbeto de solo lectura para la invocación de los métodos de la clase <b>CN_GetData</b>
        /// </summary> 
        private readonly CN_GetData objCapaNegocio = new CN_GetData();
        private IEnumerable<object> objects = new List<object>();
        private string nombres = "";
        private string cedula = "";
        private string fecha = "";
        private string filas = string.Empty;
        private float total = 0f;
        #endregion

        public Frm_Input_Data_Records()
        {
            InitializeComponent();
        }

        private void txt_Cedula_Cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char c = e.KeyChar;
            if (Char.IsDigit(c) && txt_Cedula_Cliente.Texts.Length <= 10)
            {
                e.Handled = false;
            }
            else if (c == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            if (txt_Cedula_Cliente.Texts.Length > 10 && c != ((char)Keys.Back))
            {
                MessageBox.Show("La cédula debe contener máximo 10 d\u00edgitos", "Validaci\u00f3n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_Generar_Reporte_Click(object sender, EventArgs e)
        {
            if (txt_Cedula_Cliente.Texts.Equals(""))
            {
                label2.Text = "El campo cédula está vacío (*)";
                label2.Visible = true;
            }
            else
            {
                label2.Visible = false;
                var objeto = objCapaNegocio.CN_DevolverCliente()
                    .Where(cl => ("0" + cl.Cedula.ToString()).Contains(txt_Cedula_Cliente.Texts.Trim()))
                    .Join(objCapaNegocio.CN_DevolverFactura(),
                        cliente => cliente.Id,
                        factura => factura.IdCliente,
                        (cliente, factura) =>
                        new
                        {
                            CEDULA = cliente.Cedula,
                            Nombres = cliente.Nombres + " " + cliente.Apellidos,
                            CANTIDAD = factura.Cantidad,
                            DESCRIPCION = factura.Descripcion,
                            VALOR_UNITARIO = factura.ValorUnitario,
                            TOTAL = factura.Total,
                            Fecha = DateTime.Today.ToString("d")
                        });
                foreach (var item in objeto)
                {
                    cedula = "0"+item.CEDULA+"";
                    nombres = item.Nombres;
                    fecha = item.Fecha;
                    filas += "<tr>";
                    filas += "<td>" +item.CANTIDAD+"</td>";
                    filas += "<td>" + item.DESCRIPCION + "</td>";
                    filas += "<td>" + item.VALOR_UNITARIO + "</td>";
                    filas += "<td>" + item.TOTAL + "</td>";
                    filas += "</tr>";
                    total += (float)Math.Round(item.TOTAL, 2, MidpointRounding.ToEven);
                }
                if (objeto != null && objeto.Any())
                {
                    label2.Visible = false;
                    if (objCapaNegocio.CN_DevolverFactura().Count > 0)
                    {
                        SaveFileDialog guardar_reporte = new SaveFileDialog()
                        {
                            FileName = DateTime.Now.ToString("dddd_d_MMM_yyyy") + ".pdf",
                            Title = "Reporte de Facturas",
                        };

                        var contenido = Properties.Resources.Plantilla.ToString();
                        contenido = contenido.Replace("@Cliente",nombres);
                        contenido = contenido.Replace("@Cedula", cedula);
                        contenido = contenido.Replace("@Fecha", fecha);
                        contenido = contenido.Replace("@FILAS", filas);
                        contenido = contenido.Replace("@Total", total.ToString());
                        contenido = contenido.Replace("@NroFactura", "000000001");

                        if (guardar_reporte.ShowDialog() == DialogResult.OK)
                        {
                            using (FileStream stream = new FileStream(guardar_reporte.FileName, FileMode.Create))
                            {
                                Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
                                PdfWriter writer = PdfWriter.GetInstance(pdf, stream);
                                pdf.Open();

                                pdf.Add(new Phrase(""));
                                using (StringReader str = new StringReader(contenido))
                                {
                                    //Leer el objeto del contenido y se pueda incrustar en el pdf
                                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, str);
                                }

                                pdf.Close();
                                stream.Close();
                                MessageBox.Show("Reporte generado con éxito", "Reporte de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo generar el reporte.\n\tNo hay facturas generadas.", "Fallo al generar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    label2.Visible = true;
                    label2.Text = "No se encontró el registro (*)";
                }
            }
        }

        //private void GenerarReporteFactura()
        //{
        //    if (objCapaNegocio.CN_DevolverFactura().Count > 0)
        //    {
        //        SaveFileDialog guardar_reporte = new SaveFileDialog()
        //        {
        //            FileName = DateTime.Now.ToString("dddd_d_MMM_yyyy") + ".pdf",
        //            Title = "Reporte de Facturas",
        //        };

        //        var contenido = Properties.Resources.Plantilla.ToString();
        //        contenido = contenido.Replace("@Cliente")

        //        if (guardar_reporte.ShowDialog() == DialogResult.OK)
        //        {
        //            using (FileStream stream = new FileStream(guardar_reporte.FileName, FileMode.Create))
        //            {
        //                Document pdf = new Document(PageSize.A4, 25, 25, 25, 25);
        //                PdfWriter writer = PdfWriter.GetInstance(pdf, stream);
        //                pdf.Open();

        //                pdf.Add(new Phrase(""));
        //                using (StringReader str = new StringReader(contenido))
        //                {
        //                    Leer el objeto del conteniod y se pueda incrustar en el pdf
        //                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdf, str);
        //                }

        //                pdf.Close();
        //                stream.Close();
        //                MessageBox.Show("Reporte generado con éxito", "Reporte de Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("No se pudo generar el reporte.\n\tNo hay facturas generadas.", "Fallo al generar Reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}
