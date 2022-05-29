using FormInterface.Views.PageViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormInterface.Views
{
    internal class ControlsHandler
    {
        private bool MouseIsOverControl(Control ctl) => ctl.ClientRectangle.Contains(ctl.PointToClient(Cursor.Position));

        private readonly Color pnl_select = Color.FromArgb(60, 73, 92);
        private readonly Color pnl_default = Color.FromArgb(22, 27, 34);
        public void SelectStripPanel(object? sender, EventArgs e)
        {
            if (sender == null) { return; }

            Control c = (Control)sender;
            if (MouseIsOverControl(c))
            {
                c.BackColor = pnl_select;
                c.Cursor = Cursors.Hand;
            }
        }
        public void UnselectStripPanel(object? sender, EventArgs e)
        {
            if (sender == null) { return; }

            Control c = (Control)sender;
            if (!MouseIsOverControl(c))
            {
                c.BackColor = pnl_default;
                c.Cursor = Cursors.Default;
            }
        }

        public void ClickStripPanel(object? sender, EventArgs e)
        {
            if (sender == null) { return; }

            Control c = (Control)sender;

            if (c is Label || c is PictureBox)
            {
                if (Enum.TryParse<Pages>(c.Parent.Name.Split('_')[1], out Pages page))
                {
                    SwitchPage(page);
                }
            }
            else
            {
                if (Enum.TryParse<Pages>(c.Name.Split('_')[1], out Pages page))
                {
                    SwitchPage(page);
                }
            }

        }

        private void SwitchPage(Pages page)
        {
            MessageBox.Show(page.ToString());
        }
    }
}
