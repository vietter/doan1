namespace QL_KhachSan
{
    partial class BaoCaoPhuQuoc
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoPhuQuoc));
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BaoCaoPQ = new QL_KhachSan.BaoCaoPQ();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.HoaDonTableAdapter = new QL_KhachSan.BaoCaoPQTableAdapters.HoaDonTableAdapter();
            this.pbTroVe = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoPQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).BeginInit();
            this.SuspendLayout();
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.BaoCaoPQ;
            // 
            // BaoCaoPQ
            // 
            this.BaoCaoPQ.DataSetName = "BaoCaoPQ";
            this.BaoCaoPQ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_KhachSan.RP_PQ.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(583, 256);
            this.reportViewer1.TabIndex = 0;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // pbTroVe
            // 
            this.pbTroVe.Image = ((System.Drawing.Image)(resources.GetObject("pbTroVe.Image")));
            this.pbTroVe.Location = new System.Drawing.Point(601, 222);
            this.pbTroVe.Name = "pbTroVe";
            this.pbTroVe.Size = new System.Drawing.Size(54, 46);
            this.pbTroVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTroVe.TabIndex = 27;
            this.pbTroVe.TabStop = false;
            this.pbTroVe.Click += new System.EventHandler(this.pbTroVe_Click);
            // 
            // BaoCaoPhuQuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 279);
            this.Controls.Add(this.pbTroVe);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoPhuQuoc";
            this.Text = "BaoCaoPhuQuoc";
            this.Load += new System.EventHandler(this.BaoCaoPhuQuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoPQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTroVe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private BaoCaoPQ BaoCaoPQ;
        private BaoCaoPQTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
        private System.Windows.Forms.PictureBox pbTroVe;
    }
}