using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Capa_Presentacion.user_controls
{
    public partial class TextBox_Control : UserControl
    {
        public TextBox_Control()
        {
            InitializeComponent();
        }
        //
        // Resumen:
        //     Obtiene o establece el punto de inicio del texto seleccionado en el cuadro de
        //     texto.
        //
        // Devuelve:
        //     Posición de inicio del texto seleccionado en el cuadro de texto.
        //
        // Excepciones:
        //   T:System.ArgumentOutOfRangeException:
        //     El valor asignado es menor que cero.
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [Category("CatAppearance")]
        [IODescription("TextBoxSelectionStartDescr")]
        public int SelectionStart { get; set; }
    }
}
