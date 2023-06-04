using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SICM.SubForms
{
    public partial class testeFrm : Form
    {
        public testeFrm()
        {
            InitializeComponent();

        }

        private void testeFrm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i <= 3; i++)
            {
                Cb_Lista.Items.Add("Item " + i);
            }

           
        }
    }
}
