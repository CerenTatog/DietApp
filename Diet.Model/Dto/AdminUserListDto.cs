using System;
using System.ComponentModel;

namespace Diet.Model.Dto
{
    public class AdminUserListDto
    {
        [DisplayName("Adı")]
        public string UserName { get; set; }
        [DisplayName("Soyadı")]
        public string UserSurname{ get; set; }
        [DisplayName("E-Posta")]
        public string Email { get; set; }
        [DisplayName("Kayıt Tarihi")]
        public DateTime? CreatedDate { get; set; }
    }
}
