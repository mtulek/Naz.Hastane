/*
    Bu yazılımın tasarımı ve kaynak kodları Datakent'e aittir.
    istenildiği gibi geliştirilebilir, tasarımı değiştirilebilir.
    yazılımdaki kodlar ve tasarım referans gösterilerek kullanılabilir.
    ücretle VEYA dengi nesne karşılığında SATILMAMALIDIR.
    gönlüm bu yazılımın insanlar tarafından serbestçe kullanılmasından yanadır.
    emeğe haksızlık yapmak istemiyorsanız yazılımdaki DATAKENT'e ait bilgileri KALDIRMAYINIZ.
    yok ben emeği önemsemem, enayi gibi kodları yayınlamasaydınız diyorsanız İSTEDİĞİNİZİ yapabilirsiniz.
 
    http://www.datakent.com
    http://forum.datakent.com
    14-06-07
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using meno.MyWSDL_E00;

namespace meno
{
    public partial class E00_2 : Form
    {
        public FaturaCevapDVO FaturaCevap = new FaturaCevapDVO();
        
        public E00_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void E00_2_Load(object sender, EventArgs e)
        {
            textBox1.Text = FaturaCevap.sonucKodu.ToString();
            textBox2.Text = FaturaCevap.sonucMesaji.ToString();
            DataRow myr;

            try
            {
                if (FaturaCevap.hataliKayitlar != null)
                {
                    if (FaturaCevap.hataliKayitlar.Length > 0)
                    {
                        foreach (FaturaHataliKayitDVO ix in FaturaCevap.hataliKayitlar)
                        {
                            myr = c00_ds.Tables["tblFaturaHataliKayit"].NewRow();
                            myr[0] = ix.takipNo.ToString();
                            myr[1] = ix.hataKodu.ToString();
                            myr[2] = ix.hataMesaji.ToString();
                            c00_ds.Tables["tblFaturaHataliKayit"].Rows.Add(myr);
                        }
                    }
                }

                if (FaturaCevap.basariliKayitlar != null)
                {
                    if (FaturaCevap.basariliKayitlar.Length > 0)
                    {
                        foreach (FaturaBasariliKayitDVO ix in FaturaCevap.basariliKayitlar)
                        {
                            myr = c00_ds.Tables["tblFaturaBasariliKayit"].NewRow();
                            myr[0] = ix.takipNo.ToString();
                            myr[1] = ix.faturaTeslimNo.ToString();
                            myr[2] = ix.hesaplananTutar.ToString();
                            c00_ds.Tables["tblFaturaBasariliKayit"].Rows.Add(myr);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();
            }
        }
    }
}