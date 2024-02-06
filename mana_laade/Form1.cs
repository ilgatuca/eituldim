using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mana_laade
{
    public partial class Form1 : Form
    {
        static SQLiteConnection CreateConeection()
        {
            SQLiteConnection reikin;
            reikin = new SQLiteConnection("Data Source=reikin.db; Version = 3; New = true; Compress = True;");
            try
            {
                reikin.Open();

            }
            catch
            {

            }
            return reikin;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string klientaVards = vards.Text;
            string veltijumaTeksts = velejums.Text;
            int platums = int.Parse(platumstb.Text);
            int garums = int.Parse(garumstb.Text);
            int augstums = int.Parse(augstumstb.Text);
            double materialaCena = double.Parse(materialstb.Text);


            double darbaSamaksa = 15;
            double PVN = 21;

            double produktaCena = (veltijumaTeksts.Length * 1.2) +
                                  ((platums / 100.0) * (garums / 100.0) * (augstums / 100.0) / 3.0 * materialaCena);

            double PVNSumma = (produktaCena + darbaSamaksa) * PVN / 100;
            double rekinaSumma = produktaCena + darbaSamaksa + PVNSumma;

            IzvaditRekinaInformaciju(klientaVards, veltijumaTeksts, platums, garums, augstums, materialaCena, darbaSamaksa, PVN, produktaCena, PVNSumma, rekinaSumma);
            SaglabatRekinuFaila(klientaVards, veltijumaTeksts, platums, garums, augstums, materialaCena, darbaSamaksa, PVN, produktaCena, PVNSumma, rekinaSumma);

        }
        private void IzvaditRekinaInformaciju(string vards, string veltijums, int platumstb, int garumstb, int augstumstb, double materialstb, double darbaSamaksa, double PVN, double produktaCena, double PVNSumma, double rekinaSumma)
        {

            rekinstb.AppendText($"Rekins izveidots {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n" +
                                   $"Klients: {vards}\n" +
                                   $"Veltījuma teksts: {veltijums}\n" +
                                   $"Lādītes izmērs: Platums: {platumstb}mm, Garums: {garumstb}mm, Augstums: {augstumstb}mm\n" +
                                   $"Kokmateriāla cena: {materialstb} EUR/m2\n" +
                                   $"Darba samaksa: {darbaSamaksa} EUR\n" +
                                   $"PVN: {PVN}%\n" +
                                   $"Produkta cena: {produktaCena} EUR\n" +
                                   $"PVN summa: {PVNSumma} EUR\n" +
                                   $"Rekina summa: {rekinaSumma} EUR\n\n");


        }
        private void SaglabatRekinuFaila(string vards, string veltijums, int platumstb, int garumstb, int augstumstb, double materialstb, double darbaSamaksa, double PVN, double produktaCena, double PVNSumma, double rekinaSumma)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Teksta faili|*.txt|Visi faili|*.*";
            saveFileDialog.Title = "Saglabāt reķinu failā";
            saveFileDialog.FileName = "Rekins_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName))
                {
                    sw.WriteLine($"Rekins izveidots {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
                    sw.WriteLine($"Klients: {vards}");
                    sw.WriteLine($"Veltījuma teksts: {veltijums}");
                    sw.WriteLine($"Lādītes izmērs: Platums: {platumstb}mm, Garums: {garumstb}mm, Augstums: {augstumstb}mm");
                    sw.WriteLine($"Kokmateriāla cena: {materialstb} EUR/m2");
                    sw.WriteLine($"Darba samaksa: {darbaSamaksa} EUR");
                    sw.WriteLine($"PVN: {PVN}%");
                    sw.WriteLine($"Produkta cena: {produktaCena} EUR");
                    sw.WriteLine($"PVN summa: {PVNSumma} EUR");
                    sw.WriteLine($"Rekina summa: {rekinaSumma} EUR");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                StreamWriter a = new StreamWriter("rekins.txt");



                a.WriteLine(label1.Text + " " + vards.Text);
                a.WriteLine(label2.Text + " " + velejums.Text);
                a.WriteLine(label3.Text + " " + platumstb.Text);
                a.WriteLine(label4.Text + " " + garumstb.Text);
                a.WriteLine(label5.Text + " " + augstumstb.Text);
                a.WriteLine(label6.Text + " " + materialstb.Text);




                a.Close();

            }
        }

    }
}//NESTRADA NEKAS MAN TE BET NAV NEVIENA ERRORA
