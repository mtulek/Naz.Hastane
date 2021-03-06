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
using meno.MyWSDL_A00;

namespace meno
{
    public partial class A00 : Form
    {
        public A00()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string strerr = "";
            try
            {
                int i = Convert.ToInt32(saglikTesisKodu.Text);
            }
            catch
            {
                strerr += "-Sağlık Tesis Kodu bölümü geçerli bir değer içermeli.\r\n";
            }

            if (strerr != "")
            {
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = strerr;
                erxf.ShowDialog();
                erxf.Dispose();
                return;
            } 
            
            
            try
            {
                button3.Enabled = false;
                toolStripStatusLabel1.Text = GlobalClass.msg01;
                this.Refresh();

                ProvizyonIslemleriService servis = new ProvizyonIslemleriService();
                servis.Credentials = new System.Net.NetworkCredential(GlobalClass.WSDLUserName, GlobalClass.WSDLUserPassword);
                servis.PreAuthenticate = true;                

                ProvizyonGirisDVO MyInput = new ProvizyonGirisDVO();
                ProvizyonCevapDVO WSOutPut = new ProvizyonCevapDVO();
                
                MyInput.hastaTCKimlikNo = hastaTCKimlikNo.Text;
                MyInput.saglikTesisKodu = Convert.ToInt32(saglikTesisKodu.Text);
                MyInput.hastaSosyalGuvNo = hastaSosyalGuvNo.Text;
                MyInput.hastaKarneNo = hastaKarneNo.Text;
                MyInput.sigortaliTuru = Convert.ToString(sigortaliTuru.SelectedIndex + 1);
                MyInput.yakinlikKodu = yakinlikKodu.Text;
                if (devredilenKurum.SelectedIndex == 0)
                    MyInput.devredilenKurum = "";
                else MyInput.devredilenKurum = Convert.ToString(devredilenKurum.SelectedIndex);
                MyInput.provizyonTarihi = provizyonTarihi.Text;
                MyInput.takipTuru = Convert.ToString(takipTuru.SelectedIndex+1);
                MyInput.provizyonTipi = provizyonTipi.Text[0].ToString();
                MyInput.takipNo = takipNo.Text;
                

                WSOutPut = servis.hastaKabul(MyInput);

                wS_Result1.FillText(ref WSOutPut);
                button3.Enabled = true;
                toolStripStatusLabel1.Text = GlobalClass.msg02;
            }
            catch ( Exception ex )
            {
                toolStripStatusLabel1.Text = GlobalClass.msg03;
                ErrFrm erxf = new ErrFrm();
                erxf.ermessage = ex.Message;
                erxf.ShowDialog();
                erxf.Dispose();                

                button3.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {            

            sigortaliTuru.SelectedIndex = 0;
            devredilenKurum.SelectedIndex = 0;
            provizyonTipi.SelectedIndex = 0;
            takipTuru.SelectedIndex = 0;                                               
            //provizyonTarihi.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process Proc = new System.Diagnostics.Process();
            Proc.StartInfo.FileName = GlobalClass.GetAxPath() + @"\yakinlik_kodlari.htm";
            Proc.Start();
        }

    }
}