using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEgitimKampiMY301.EFProject
{
    public partial class FrmStatistics : Form
    {
        public FrmStatistics()
        {
            InitializeComponent();
        }

        CSharpEgitimKampi301EFTravelDbEntities db = new CSharpEgitimKampi301EFTravelDbEntities();

        private void FrmStatistics_Load(object sender, EventArgs e)
        {
            lblLocationCount.Text = db.TblLocation.Count().ToString();

            lblSumCapacity.Text = db.TblLocation.Sum(x => x.Capacity).ToString();

            lblGuideCount.Text = db.TblGuide.Count().ToString();

            lblAvgCapacity.Text = db.TblLocation.Average(x => x.Capacity).Value.ToString("F2");

            lblAvgLocationPrice.Text = db.TblLocation.Average(x => x.Price).Value.ToString("F2") + " ₺";

            int lastCountryId = db.TblLocation.Max(x => x.LocationId);
            lblLastCountryName.Text = db.TblLocation.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            lblCappadociaLocationCapacity.Text = db.TblLocation.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();
            
            lblTurkiyeAvgCapacity.Text = db.TblLocation.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            var romeGuideId = db.TblLocation.Where(x => x.City == "Roma Turistik").Select(y => y.GuideId).FirstOrDefault();
            lblRomeGuideName.Text = db.TblGuide.Where(x => x.GuideId == romeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault();

            var maxCapacity = db.TblLocation.Max(x => x.Capacity);
            lblMaxCapacityLocation.Text = db.TblLocation.Where(x => x.Capacity == maxCapacity).Select(y => y.City).FirstOrDefault().ToString();

            var maxPrice = db.TblLocation.Max(x => x.Price);
            lblMaxLocationPrice.Text = db.TblLocation.Where(x => x.Price == maxPrice).Select(y => y.City).FirstOrDefault().ToString();

            var guideIdByNameAysegulCinar = db.TblGuide.Where(x => x.GuideName == "Ayşegül" && x.GuideSurname == "Çınar").Select(y => y.GuideId).FirstOrDefault();
            lblAysegulCinarLocationCount.Text = db.TblLocation.Where(x => x.GuideId == guideIdByNameAysegulCinar).Count().ToString();
        }
    }
}
