using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Schematix.CommonProperties
{
    public partial class GraphicsOptionsUserControl : UserControl
    {
        private GraphicsOptions graphicsOptions;
        public GraphicsOptionsUserControl()
        {
            InitializeComponent();
            graphicsOptions = new GraphicsOptions();
        }

        public void SetOptionsData(GraphicsOptions options)
        {
            graphicsOptions.BGColor = options.BGColor;
            graphicsOptions.BorderColor = options.BorderColor;
            graphicsOptions.ShowBorder = options.ShowBorder;
            graphicsOptions.ShowGrid = options.ShowGrid;
            graphicsOptions.SelectColor = options.SelectColor;

            checkBoxShowBorder.Checked = options.ShowBorder;
            checkBoxShowGrid.Checked = options.ShowGrid;

            SetColorText(labelBGColor, graphicsOptions.BGColor);
            SetColorText(labelLineColor, graphicsOptions.BorderColor);
            SetColorText(labelSelectColor, graphicsOptions.SelectColor);
        }

        public void GetOptionsData(GraphicsOptions options)
        {
            options.SelectColor = graphicsOptions.SelectColor;
            options.BGColor = graphicsOptions.BGColor;
            options.BorderColor = graphicsOptions.BorderColor;
            options.ShowBorder = graphicsOptions.ShowBorder;
            options.ShowGrid = graphicsOptions.ShowGrid;
        }

        public static void SetColorText(Label label, Color color)
        {
            if (color.ToKnownColor().ToString() == "0")
                label.Text = string.Format("Текущий цвет: {0}", color.ToString());
            else
                label.Text = string.Format("Текущий цвет: {0}", color.ToKnownColor().ToString());
        }

        private void buttonhangeBGColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = graphicsOptions.BGColor;
            DialogResult res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                graphicsOptions.BGColor = colorDialog.Color;
                SetColorText(labelBGColor, graphicsOptions.BGColor);
            }
        }

        private void buttonChangeLineColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = graphicsOptions.BorderColor;
            DialogResult res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                graphicsOptions.BorderColor = colorDialog.Color;
                SetColorText(labelLineColor, graphicsOptions.BorderColor);
            }
        }

        private void buttonChangeSelectColor_Click(object sender, EventArgs e)
        {
            colorDialog.Color = graphicsOptions.SelectColor;
            DialogResult res = colorDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                graphicsOptions.SelectColor = colorDialog.Color;
                SetColorText(labelSelectColor, graphicsOptions.SelectColor);
            }
        }

        private void checkBoxShowBorder_CheckedChanged(object sender, EventArgs e)
        {
            graphicsOptions.ShowBorder = checkBoxShowBorder.Checked;
        }

        private void checkBoxShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            graphicsOptions.ShowGrid = checkBoxShowGrid.Checked;
        }
    }
}
