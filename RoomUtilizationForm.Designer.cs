namespace MountainViewCommunityHospitalCrystalReport
{
    partial class RoomUtilizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rptCrystalViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptCrystalViewer
            // 
            this.rptCrystalViewer.ActiveViewIndex = -1;
            this.rptCrystalViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptCrystalViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptCrystalViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptCrystalViewer.Location = new System.Drawing.Point(0, 0);
            this.rptCrystalViewer.Name = "rptCrystalViewer";
            this.rptCrystalViewer.Size = new System.Drawing.Size(800, 450);
            this.rptCrystalViewer.TabIndex = 0;
            // 
            // RoomUtilizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptCrystalViewer);
            this.Name = "RoomUtilizationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Utilization Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MVCHForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptCrystalViewer;
    }
}

