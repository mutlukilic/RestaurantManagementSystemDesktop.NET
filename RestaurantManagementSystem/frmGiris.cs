using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantManagementSystem
{
    public partial class frmGiris : Form
    {
        cGenel gnl = new cGenel();
        public frmGiris()
        {
            InitializeComponent();
        }


        private void frmGiris_Load(object sender, EventArgs e)
        {
            cPersoneller p = new cPersoneller();
            p.personelGetByInformation(cbKullanici);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            cGenel gnl = new cGenel();
            cPersoneller p = new cPersoneller();
            bool result = p.personelEntryControl(textSifre.Text, cGenel._EmployeeId);

            if (result)
            {
                CPersonelHareketleri ch = new CPersonelHareketleri();
                ch.EmployeeId = cGenel._EmployeeId;
                ch.Operation = "Giriş Yaptı";
                ch.Date = DateTime.Now;
                ch.PersonelActionSave(ch);

                this.Hide();
                frmMenu menu = new frmMenu();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Şifreniz Yanlış?", "Uyarı!!!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbKullanici_SelectedIndexChanged(object sender, EventArgs e)
        {
            cPersoneller p = (cPersoneller)cbKullanici.SelectedItem;
            cGenel._EmployeeId = p.EmployeeId;
            cGenel._TaskId = p.TaskId;
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Cıkmak istediginizden emin misiniz?","Uyarı !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
