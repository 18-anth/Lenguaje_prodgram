using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TALLER_GRUPO_2_MDI
{
    public partial class Frm_TipoLetra : Form
    {
        // defino variable de la clase para validad la instancia 
        private static Frm_TipoLetra instVentana = null;
        public Frm_TipoLetra()
        {
            InitializeComponent();

        }
        //valido la creacion de mas de una instancia cuando creo el formulario
        public static Frm_TipoLetra UnaVentana()
        {
            if (instVentana == null)
            {
                instVentana = new Frm_TipoLetra();
                return instVentana;
            }
            return instVentana;
        }
        
            private void Frm_TipoLetra_Load(object sender, EventArgs e)

        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    }



