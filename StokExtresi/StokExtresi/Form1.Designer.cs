namespace StokExtresi
{
    partial class Form1
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SiraNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.IslemTur = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EvrakNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridStok = new DevExpress.XtraGrid.GridControl();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMalKodu = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.dtpFirstDate = new System.Windows.Forms.DateTimePicker();
            this.dtpLastDate = new System.Windows.Forms.DateTimePicker();
            this.GirisMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CikisMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Stok = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExportExcel = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.SiraNo,
            this.IslemTur,
            this.EvrakNo,
            this.Tarih,
            this.GirisMiktar,
            this.CikisMiktar,
            this.Stok});
            this.gridView1.GridControl = this.gridStok;
            this.gridView1.Name = "gridView1";
            // 
            // SiraNo
            // 
            this.SiraNo.FieldName = "SiraNo";
            this.SiraNo.Name = "SiraNo";
            this.SiraNo.Visible = true;
            this.SiraNo.VisibleIndex = 0;
            // 
            // IslemTur
            // 
            this.IslemTur.FieldName = "IslemTur";
            this.IslemTur.Name = "IslemTur";
            this.IslemTur.Visible = true;
            this.IslemTur.VisibleIndex = 1;
            // 
            // EvrakNo
            // 
            this.EvrakNo.FieldName = "EvrakNo";
            this.EvrakNo.Name = "EvrakNo";
            this.EvrakNo.Visible = true;
            this.EvrakNo.VisibleIndex = 2;
            // 
            // Tarih
            // 
            this.Tarih.FieldName = "Tarih";
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 3;
            // 
            // gridStok
            // 
            this.gridStok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridStok.Location = new System.Drawing.Point(0, 91);
            this.gridStok.MainView = this.gridView1;
            this.gridStok.Name = "gridStok";
            this.gridStok.Size = new System.Drawing.Size(800, 349);
            this.gridStok.TabIndex = 0;
            this.gridStok.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "Tarih";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            // 
            // txtMalKodu
            // 
            this.txtMalKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMalKodu.Location = new System.Drawing.Point(161, 64);
            this.txtMalKodu.Name = "txtMalKodu";
            this.txtMalKodu.Size = new System.Drawing.Size(200, 21);
            this.txtMalKodu.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(379, 64);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Göster";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dtpFirstDate
            // 
            this.dtpFirstDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFirstDate.Location = new System.Drawing.Point(161, 12);
            this.dtpFirstDate.Name = "dtpFirstDate";
            this.dtpFirstDate.Size = new System.Drawing.Size(200, 21);
            this.dtpFirstDate.TabIndex = 5;
            // 
            // dtpLastDate
            // 
            this.dtpLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLastDate.Location = new System.Drawing.Point(161, 38);
            this.dtpLastDate.Name = "dtpLastDate";
            this.dtpLastDate.Size = new System.Drawing.Size(200, 21);
            this.dtpLastDate.TabIndex = 6;
            // 
            // GirisMiktar
            // 
            this.GirisMiktar.FieldName = "GirisMiktar";
            this.GirisMiktar.Name = "GirisMiktar";
            this.GirisMiktar.Visible = true;
            this.GirisMiktar.VisibleIndex = 4;
            // 
            // CikisMiktar
            // 
            this.CikisMiktar.FieldName = "CikisMiktar";
            this.CikisMiktar.Name = "CikisMiktar";
            this.CikisMiktar.Visible = true;
            this.CikisMiktar.VisibleIndex = 5;
            // 
            // Stok
            // 
            this.Stok.FieldName = "Stok";
            this.Stok.Name = "Stok";
            this.Stok.Visible = true;
            this.Stok.VisibleIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Mal Kodu veya Mal Adı";
            // 
            // btnExportExcel
            // 
            this.btnExportExcel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportExcel.Location = new System.Drawing.Point(686, 61);
            this.btnExportExcel.Name = "btnExportExcel";
            this.btnExportExcel.Size = new System.Drawing.Size(102, 23);
            this.btnExportExcel.TabIndex = 10;
            this.btnExportExcel.Text = "Excel\'e aktar";
            this.btnExportExcel.UseVisualStyleBackColor = true;
            this.btnExportExcel.Click += new System.EventHandler(this.btnExportExcel_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(605, 61);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Yazdır";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 440);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExportExcel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpLastDate);
            this.Controls.Add(this.dtpFirstDate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtMalKodu);
            this.Controls.Add(this.gridStok);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn SiraNo;
        private DevExpress.XtraGrid.Columns.GridColumn IslemTur;
        private DevExpress.XtraGrid.Columns.GridColumn EvrakNo;
        private DevExpress.XtraGrid.GridControl gridStok;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private System.Windows.Forms.TextBox txtMalKodu;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.DateTimePicker dtpFirstDate;
        private System.Windows.Forms.DateTimePicker dtpLastDate;
        private DevExpress.XtraGrid.Columns.GridColumn GirisMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn CikisMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn Stok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExportExcel;
        private System.Windows.Forms.Button btnPrint;
    }
}

