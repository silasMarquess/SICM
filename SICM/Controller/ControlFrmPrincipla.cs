using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SICM.SubForms;
using System.Windows.Forms;
using SICM.Entidades;

namespace SICM
{
    class ControlFrmPrincipla
    {
        
        private  FrmMenuPrincipal _form;
        

        public ControlFrmPrincipla(FrmMenuPrincipal form)
        {
            _form = form;
        }

        public  void GetPainel(Form _painelFilho)
        {
            if (_form.Pn_Plataforma.Controls.Count > 0)
            {
                _form.Pn_Plataforma.Controls.Clear();
            }

            _painelFilho.TopLevel = false;
            _form.Pn_Plataforma.Controls.Add(_painelFilho);
            _painelFilho.Dock = DockStyle.Fill;
            _painelFilho.Show();
        }

    }
}
