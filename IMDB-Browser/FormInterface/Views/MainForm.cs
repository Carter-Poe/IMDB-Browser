using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormInterface.Views
{
    public partial class MainForm : Form
    {
        private bool MouseIsOverControl(Control btn) => btn.ClientRectangle.Contains(btn.PointToClient(Cursor.Position));

        ControlsHandler controlsHandler = new ControlsHandler();
        public MainForm()
        {
            InitializeComponent();

            //Dashboard Button
            lbl_dashboard.Click += controlsHandler.SelectStripPanel;
            pb_dashboard.Click += controlsHandler.SelectStripPanel;
            pnl_dashboard.Click += controlsHandler.SelectStripPanel;
            pnl_dashboard.MouseEnter += controlsHandler.SelectStripPanel;
            pnl_dashboard.MouseLeave += controlsHandler.UnselectStripPanel;

            //Browse Button
            lbl_browse.Click += controlsHandler.SelectStripPanel;
            pb_browse.Click += controlsHandler.SelectStripPanel;
            pnl_browse.Click += controlsHandler.SelectStripPanel;
            pnl_browse.MouseEnter += controlsHandler.SelectStripPanel;
            pnl_browse.MouseLeave += controlsHandler.UnselectStripPanel;

            //Calender Button
            lbl_calender.Click += controlsHandler.SelectStripPanel;
            pb_calender.Click += controlsHandler.SelectStripPanel;
            pnl_calender.Click += controlsHandler.SelectStripPanel;
            pnl_calender.MouseEnter += controlsHandler.SelectStripPanel;
            pnl_calender.MouseLeave += controlsHandler.UnselectStripPanel;

            //Settings Button
            pb_settings.Click += controlsHandler.SelectStripPanel;
            pnl_settings.Click += controlsHandler.SelectStripPanel;
            pnl_settings.MouseEnter += controlsHandler.SelectStripPanel;
            pnl_settings.MouseLeave += controlsHandler.UnselectStripPanel;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
