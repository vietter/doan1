namespace QL_KhachSan
{
    partial class BaoCaoDaLat
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BaoCaoDL = new QL_KhachSan.BaoCaoDL();
            this.HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.HoaDonTableAdapter = new QL_KhachSan.BaoCaoDLTableAdapters.HoaDonTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_KhachSan.RP_DL.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(57, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(731, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // BaoCaoDL
            // 
            this.BaoCaoDL.DataSetName = "BaoCaoDL";
            this.BaoCaoDL.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // HoaDonBindingSource
            // 
            this.HoaDonBindingSource.DataMember = "HoaDon";
            this.HoaDonBindingSource.DataSource = this.BaoCaoDL;
            // 
            // HoaDonTableAdapter
            // 
            this.HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // BaoCaoDaLat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "BaoCaoDaLat";
            this.Text = "BaoCaoDaLat";
            this.Load += new System.EventHandler(this.BaoCaoDaLat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BaoCaoDL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource HoaDonBindingSource;
        private BaoCaoDL BaoCaoDL;
        private BaoCaoDLTableAdapters.HoaDonTableAdapter HoaDonTableAdapter;
    }
}