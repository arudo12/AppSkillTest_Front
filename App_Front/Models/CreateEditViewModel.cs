using System.ComponentModel.DataAnnotations;

namespace App_Front.Models
{
    public class CreateEditViewModel
    {
        [Display(Name = "Agreement Number")]
        public string AggrementNumber { get; set; }
        [Display(Name = "Branch Id")]
        public int BranchID { get; set; }
        [Display(Name = "No. BPKB")]
        public string NoBPKB { get; set; }
        [Display(Name = "Tanggal BPKB In")]
        public DateTime TanggalBPKBIn { get; set; }
        [Display(Name = "Tanggal BPKB")]
        public DateTime TanggalBPKB { get; set; }
        [Display(Name = "No. Faktur")]
        public string NoFaktur { get; set; }
        [Display(Name = "Tanggal Faktur")]
        public DateTime TanggalFaktur { get; set; }
        [Display(Name = "Nomor Polisi")]
        public string NoPolisi { get; set; }
        [Display(Name = "Lokasi Penyimpanan")]
        public string LocationID { get; set; }

    }
}
