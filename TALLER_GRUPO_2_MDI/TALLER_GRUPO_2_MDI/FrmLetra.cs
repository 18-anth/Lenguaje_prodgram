using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALLER_GRUPO_2_MDI
{
    public partial class FrmLetra : Form
    {
        private static FrmLetra instVentana = null;
        public FrmLetra()
        {
            InitializeComponent();
        }
        public static FrmLetra UnaVentana()
        {
            if (instVentana == null)
            {
                instVentana = new FrmLetra();
                return instVentana;
            }
            return instVentana;
        }
        private void Frm_Letra_Load(object sender, EventArgs e)
        {

        }

        private void FrmLetra_Load(object sender, EventArgs e)
        {

        }
    }
}
