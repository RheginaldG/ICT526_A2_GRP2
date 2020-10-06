using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT526_A2_GRP2
{
    class Min
    {
        int ID = 1814410;
        string name = "Min";

        public void Hello ()
        {

            MessageBox.Show(string.Format("{0},{1} send Hi to You!", name, ID), "hello", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }


    }
}
