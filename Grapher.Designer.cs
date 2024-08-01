namespace Catapult
{
    partial class Grapher
    {
        private void InitializeComponent()
        {
            this.plotViewStatic = new OxyPlot.WindowsForms.PlotView();
            this.plotViewRealTime = new OxyPlot.WindowsForms.PlotView();
            this.SuspendLayout();
            // 
            // plotViewStatic
            // 
            this.plotViewStatic.Dock = System.Windows.Forms.DockStyle.Top;
            this.plotViewStatic.Location = new System.Drawing.Point(0, 0);
            this.plotViewStatic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plotViewStatic.Name = "plotViewStatic";
            this.plotViewStatic.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewStatic.Size = new System.Drawing.Size(600, 248);
            this.plotViewStatic.TabIndex = 0;
            this.plotViewStatic.Text = "plotViewStatic";
            this.plotViewStatic.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewStatic.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewStatic.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // plotViewRealTime
            // 
            this.plotViewRealTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plotViewRealTime.Location = new System.Drawing.Point(0, 263);
            this.plotViewRealTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.plotViewRealTime.Name = "plotViewRealTime";
            this.plotViewRealTime.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotViewRealTime.Size = new System.Drawing.Size(600, 217);
            this.plotViewRealTime.TabIndex = 1;
            this.plotViewRealTime.Text = "plotViewRealTime";
            this.plotViewRealTime.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotViewRealTime.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotViewRealTime.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // Grapher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 480);
            this.Controls.Add(this.plotViewRealTime);
            this.Controls.Add(this.plotViewStatic);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Grapher";
            this.Text = "Grapher";
            this.ResumeLayout(false);

        }

        private OxyPlot.WindowsForms.PlotView plotViewStatic;
        private OxyPlot.WindowsForms.PlotView plotViewRealTime;
    }
}
