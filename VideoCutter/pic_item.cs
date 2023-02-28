using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoCutter
{
    public partial class pic_item : UserControl
    {
        public pic_item()
        {
            InitializeComponent();
            get_status_update();
        }
        public void init(Image img, bool check,int id)
        {
            pictureBox1.Image = img;
            selected = check;
            label1.Text = id.ToString();
            get_status_update();
        }
        public bool selected=false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (selected)
            {
                selected = false;
                get_status_update();
            }
            else
            {
                selected = true;
                get_status_update();
            }
        }
        private void get_status_update()
        {
            if (selected)
            {
                this.BackColor = Color.OrangeRed;
                label1.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.LightGray;
                label1.ForeColor = Color.Black;
            }
        }
        
    }
}
