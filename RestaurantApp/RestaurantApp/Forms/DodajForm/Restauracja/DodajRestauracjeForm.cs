using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantApp.Forms.DodajForm.Restauracja
{
    public partial class DodajRestauracje : Form
    {
        public DodajRestauracje()
        {
            InitializeComponent();
        }

        private static DodajRestauracje? _instance = null;
        public static DodajRestauracje Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DodajRestauracje();
                }
                return _instance;
            }
        }

        public static bool TruOrFalseInstance
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
