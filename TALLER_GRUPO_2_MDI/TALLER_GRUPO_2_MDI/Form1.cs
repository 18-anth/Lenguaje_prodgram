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
    public partial class MDIFORM : Form
    {
        public MDIFORM()
        {
            InitializeComponent();
        }

        private void tipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Frm_TipoLetra frm_TipoLetra =  Frm_TipoLetra.UnaVentana();
            frm_TipoLetra.MdiParent = this; //Ejecuta Frm_TipoLetra dentro MDI
            frm_TipoLetra.Show();
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLetra frmLetra = FrmLetra.UnaVentana();
            frmLetra.MdiParent = this; //Ejecuta Frm_TipoLetra dentro MDI
            frmLetra.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MDIFORM_Load(object sender, EventArgs e)
        {

        }
    }
}
