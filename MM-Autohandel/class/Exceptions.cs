using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Autohandel
{
    internal class Exceptions
    {
        public static void invalidFilter()
        {
            MessageBox.Show("Please enter valid Filter");
        }

        public static void invalidCharacter()
        {
            MessageBox.Show("Please enter valid value");
        }
    }
}
