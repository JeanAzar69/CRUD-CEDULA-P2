using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsIDs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        #region btn
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region metodos privados
        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenDetailsDialog();
        }

        private void OpenDetailsDialog() 
        {
            Details details = new Details();
            details.ShowDialog();
        }
        #endregion
    }
}
