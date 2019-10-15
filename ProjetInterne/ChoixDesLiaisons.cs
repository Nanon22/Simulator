using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetInterne
{
    public partial class ChoixDesLiaisons : Form
    {
        
        public ChoixDesLiaisons()
        {
            InitializeComponent();
            //RangementDeChoix.Hide();

            int i = 0;
            int stat;
            while (i < Form1.NombreDeRouter)
            {
                stat = 1; 
                //215,100
                TableLayoutPanel MyTable = new TableLayoutPanel();
                MyTable.Size = new Size(300, 100);
                MyTable.ColumnCount = 2;
                MyTable.RowCount = 1;
                MyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                MyTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
                MyTable.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
                MyTable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;

                Bunifu.UI.WinForms.BunifuPictureBox MyPicture = new Bunifu.UI.WinForms.BunifuPictureBox();
                MyPicture.Size = new Size(50, 50);
                MyPicture.Image = Properties.Resources.SoftwareTools7;

                Label MyLabel = new Label();
                MyLabel.Text = "Router" + (i + 1);

                FlowLayoutPanel MyFlowPanel1 = new FlowLayoutPanel();
                MyFlowPanel1.FlowDirection = FlowDirection.TopDown;
                MyFlowPanel1.AutoScroll = true;
                MyFlowPanel1.WrapContents = false;
                MyFlowPanel1.Controls.Add(MyPicture);
                MyFlowPanel1.Controls.Add(MyLabel);
                MyTable.Controls.Add(MyFlowPanel1, 0, 0);

                FlowLayoutPanel MyFlowPanel2 = new FlowLayoutPanel();
                MyFlowPanel2.FlowDirection = FlowDirection.TopDown;
                MyFlowPanel2.AutoScroll = true;
                MyFlowPanel2.WrapContents = false;


                while (stat <= Form1.NombreDeRouter)
                {
                    if((i+1) == stat)
                    {
                        stat++;
                    }
                    else
                    {
                        Bunifu.Framework.UI.BunifuCheckbox MyCheckbox = new Bunifu.Framework.UI.BunifuCheckbox();
                        MyCheckbox.Checked = false;
                        MyCheckbox.Tag = "" + stat;

                        Label MyLabel2 = new Label();
                        MyLabel2.Text = "Router" + stat;

                        MyFlowPanel2.Controls.Add(MyCheckbox);
                        MyFlowPanel2.Controls.Add(MyLabel2);
                        stat++;
                    }

                }
                MyTable.Controls.Add(MyFlowPanel2, 1, 0);
                LiaisonMainFlow.Controls.Add(MyTable);
                i++;
            }
        }

        private void LiaisonFormClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Form1.Step = 1;
            Close();
        }
    }
}
