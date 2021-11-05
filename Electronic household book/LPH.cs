using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electronic_household_book
{
    public partial class LPH : Form
    {
        public int x;

        public LPH()
        {
            InitializeComponent();
        }

        public LPH(int x, string text)
        {
            this.x = x;
            string fio = text;
            InitializeComponent();
        }

        public LPH(int x) : this(x, null) { }
    }
}
