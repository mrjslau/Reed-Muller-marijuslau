using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reed_Muller_marijuslau
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        public int RInt
        {
            get { return Convert.ToInt32(bitRInputBox.Text); }
        }

        public int MInt
        {
            get { return Convert.ToInt32(bitMInputBox.Text); }
        }

        public string BitStringTextBox
        {
            get { return bitStringInputBox.Text; }
        }

        private void bitEncodeButton_Click(object sender, EventArgs e)
        {
            GenMatrixGenerator gmGen = new GenMatrixGenerator(RInt, MInt);
            //GenMatrix gm = new GenMatrix();

            if (BitStringTextBox.Length != gmGen.Dimension)
            {
                MessageBox.Show("Žinutė turi būti " + Convert.ToString(gmGen.Dimension) + " simbolių ilgio");
            }
            else
            {
                Encoder encoder = new Encoder();
                BitCodedVectorBox.Text = encoder.EncodeBits(BitStringTextBox, gmGen);
                //BitTransmittedVectorBox.Text = 
            }

        }
    }
}
