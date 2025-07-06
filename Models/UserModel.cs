using System.ComponentModel.DataAnnotations;


    namespace DashboardDaiNam.Models
    {
        public class UserModel
        {
            public string Ten { get; set; }
            public string Email { get; set; }
            public string VaiTro { get; set; }
            public string KyNang { get; set; }
            public DateTime NgayTao { get; set; }
        }
    }

