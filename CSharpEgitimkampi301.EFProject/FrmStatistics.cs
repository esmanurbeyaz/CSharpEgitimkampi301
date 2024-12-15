using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimkampi301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        EgitimKampiEfTravelDbEntities db = new EgitimKampiEfTravelDbEntities();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
           
            lblLocationCount.Text = db.Location.Count().ToString();    
            lblCapacity.Text = db.Location.Sum(x =>x.Capacity).ToString();
            lblGuide.Text = db.Guide.Count().ToString();
            lblAvarageCapacity.Text = Convert.ToDouble(db.Location.Average(x => x.Capacity)).ToString("F3"); //virgülden sonra sadece 3 basamak yazması için extra kod
            lblAvgLocationPrice.Text = Convert.ToDouble(db.Location.Average(x => x.Price)).ToString("F3") + "₺";
            int lastCountryId = db.Location.Max(x => x.LocationId);
            lblLastCountryName.Text = db.Location.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();
            lblCappacodociaCapacity.Text = db.Location.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            lblTurkiyeCapacityAvg.Text = db.Location.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();
            var romaGuideId = db.Location.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            lblRomaGuideName.Text = db.Guide.Where(x => x.GuideId  == romaGuideId).Select(y => y.GuideName.Trim() + " " + y.GuideSurname.Trim()).FirstOrDefault().ToString();
            var maxCapacity = db.Location.Max(x => x.Capacity);
            lblMaxCapacity.Text = db.Location.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();
            var maxPriceTour = db.Location.Max(x => x.Price);
            lblMaxPriceTour.Text = db.Location.Where(x => x.Price == maxPriceTour).Select(y => y.City).FirstOrDefault().ToString();
            var ayseId = db.Guide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(x => x.GuideId).FirstOrDefault();
            lblAyseTourCount.Text = db.Location.Where(x => x.GuideId == ayseId).Count().ToString();
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblTurkiyeCapacityAvg_Click(object sender, EventArgs e)
        {

        }
    }
}
