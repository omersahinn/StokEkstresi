using DevExpress.Utils;
using StokExtresi.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokExtresi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //Başlangıç tarihi integer'a çevrilir
            int BaslangicTarih = Convert.ToInt32((new DateTime(dtpFirstDate.Value.Year, dtpFirstDate.Value.Month, dtpFirstDate.Value.Day, dtpFirstDate.Value.Hour, dtpFirstDate.Value.Minute, dtpFirstDate.Value.Second)).ToOADate());

            //Bitiş tarihi integer'a çevrilir
            int BitisTarih = Convert.ToInt32((new DateTime(dtpLastDate.Value.Year, dtpLastDate.Value.Month, dtpLastDate.Value.Day, dtpLastDate.Value.Hour, dtpLastDate.Value.Minute, dtpLastDate.Value.Second)).ToOADate());

            string MalKodu = txtMalKodu.Text;
            if (MalKodu=="")
            {
                MessageBox.Show("Mal Kodu veya Mal Adı alanı boş olamaz");
               
                
            }
            List<STI> Data = Procedure(BaslangicTarih, BitisTarih, MalKodu);
            if (Data.Count()==0)
            {
                MessageBox.Show("Belirtilen Tarih Aralığında Veri Bulunamadı.");
                
            }
            gridStok.DataSource = Data;
        }

        public List<STI> Procedure(int BaslangicTarih, int BitisTarih, string MalKodu)
        {
            string command = "";

            //BaslangicTarih, BitisTarih ve MalKodu bilgileriyle vertabanında sorgu yapan sorgumuz.
            command = "select * from STI where STI.MalKodu=(select STK.MalKodu from STK where STK.MalKodu='" + MalKodu + "' or STK.MalAdi='" + MalKodu + "') and STI.Tarih between '" + BaslangicTarih + "' and '" + BitisTarih + "' ";

            SqlDataAdapter adp = new SqlDataAdapter(command, Sql.Connection); //Sql server ile command sorgusuyla bağlantı kuruluyor. 
            DataTable dt = new DataTable();
            adp.Fill(dt); // Çekilen datalar datatable 'a kaydediliyor.
            List<STI> stiList = new List<STI>();

            int i = 1;
            int temp = 0;
            foreach (DataRow item in dt.Rows) // Datatable.Rows daki verilerde dolaşıyoruz 
            {
              
                STI sti = new STI(); // GridView de ki tabloları STI isimli class ta oluşturduk ve Bütün satırları STI listesine ekledik. 
                sti.SiraNo = i;
                if (Convert.ToBoolean(item.ItemArray[1]) == false)
                {
                    sti.IslemTur = "Giriş";
                    sti.GirisMiktar =Convert.ToDecimal(item.ItemArray[5]);
                    sti.CikisMiktar = 0;
                }
                else
                {
                    sti.IslemTur = "Çıkış";
                    sti.GirisMiktar = 0;
                    sti.CikisMiktar = Convert.ToDecimal(item.ItemArray[5]);
                }
                sti.EvrakNo = item.ItemArray[2].ToString();
                DateTime tarih = DateTime.FromOADate(Convert.ToDouble(item.ItemArray[3]));
                sti.Tarih = tarih.ToString("yyyy-MM-dd");
                stiList.Add(sti);
                i++;
            }
              foreach (var item in stiList.OrderBy(x => DateTime.Parse(x.Tarih)).ToList())
            {
                if (item.IslemTur=="Giriş")
                {
                    temp = temp + Convert.ToInt32(item.GirisMiktar + item.CikisMiktar);
                }
                else
                {
                    temp = temp - Convert.ToInt32(item.GirisMiktar + item.CikisMiktar);
                }
                item.Stok = temp;
            }
            return stiList.OrderBy(x => DateTime.Parse(x.Tarih)).ToList();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            string path = @"D:\StokExtresi.xlsx"; //Dosyanın kaydedileceği adres
            gridStok.ExportToXlsx(path);
            System.Diagnostics.Process.Start(path);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            gridStok.ShowPrintPreview();
        }

       
    }
}
