using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1.Dialog
{
    public partial class ResultDialog : Form
    {
        public ResultDialog(object[] dataToPrint)
        {
            InitializeComponent();
            
            StringBuilder stringBuilder = new StringBuilder(); 
            foreach(Object value in dataToPrint)
            {
                stringBuilder.Append(value.ToString() + "\n"); 
            }
            
            label2.Text =  stringBuilder.ToString();
        }
    }
}
