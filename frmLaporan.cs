using SIP.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIP
{
    public partial class frmLaporan : Form
    {
        private bool isCollapsed;     
        public frmLaporan()
        {
            InitializeComponent();
        }

        private void btnPeminjaman_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnPeminjaman.Image = Resources.expand_white_inversed_36;
                panelPeminjaman.Height += 74;
                panelPengembalian.Location = new Point(0, 45 + 74);
                panelPengadaan.Location = new Point(0, 90 + 74);
                panelDenda.Location = new Point(0, 135 + 74);
                panelInventaris.Location = new Point(0, 180 + 74);                
                    
                isCollapsed = false;
                    
                
            }
            else
            {
                btnPeminjaman.Image = Resources.expand_white_36;
                panelPeminjaman.Height -= 74;
                panelPengembalian.Location = new Point(0, 45);
                panelPengadaan.Location = new Point(0, 90);
                panelDenda.Location = new Point(0, 135);
                panelInventaris.Location = new Point(0, 180);

                isCollapsed = true;
                
            }
        }

        private void btnPengembalian_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnPengembalian.Image = Resources.expand_white_inversed_36;
                panelPengembalian.Height += 74;                
                panelPengadaan.Location = new Point(0, 90 + 74);
                panelDenda.Location = new Point(0, 135 + 74);
                panelInventaris.Location = new Point(0, 180 + 74);

                isCollapsed = false;


            }
            else
            {
                btnPengembalian.Image = Resources.expand_white_36;
                panelPengembalian.Height -= 74;
                panelPengadaan.Location = new Point(0, 90);
                panelDenda.Location = new Point(0, 135);
                panelInventaris.Location = new Point(0, 180);

                isCollapsed = true;

            }
        }

        private void btnPengadaan_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnPengadaan.Image = Resources.expand_white_inversed_36;
                panelPengadaan.Height += 74;                
                panelDenda.Location = new Point(0, 135 + 74);
                panelInventaris.Location = new Point(0, 180 + 74);

                isCollapsed = false;


            }
            else
            {
                btnPengadaan.Image = Resources.expand_white_36;
                panelPengadaan.Height -= 74;                
                panelDenda.Location = new Point(0, 135);
                panelInventaris.Location = new Point(0, 180);

                isCollapsed = true;

            }
        }

        private void btnDenda_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnDenda.Image = Resources.expand_white_inversed_36;
                panelDenda.Height += 74;                
                panelInventaris.Location = new Point(0, 180 + 74);

                isCollapsed = false;


            }
            else
            {
                btnDenda.Image = Resources.expand_white_36;
                panelDenda.Height -= 74;                
                panelInventaris.Location = new Point(0, 180);

                isCollapsed = true;

            }
        }

        private void btnInventaris_Click(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                btnInventaris.Image = Resources.expand_white_inversed_36;
                panelInventaris.Height += 74;                

                isCollapsed = false;


            }
            else
            {
                btnInventaris.Image = Resources.expand_white_36;
                panelInventaris.Height -= 74;               

                isCollapsed = true;

            }
        }
    }   
}
