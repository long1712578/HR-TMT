using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HumanResource.Api.Dtos
{
    public class EmployeeDtos
    {
        public string FullName { get; set; }
       /* [Remote(action: "VerifyEmail", controller: "Auth")] //client side
        [EmailUnique]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]*/
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
/*
        [StringLength(16, MinimumLength = 8, ErrorMessage = "Password length must be between 8 and 16")]
        [PasswordPolicy]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]*/
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Addresses { get; set; }
        public string AvatarUrl { get; set; }
        public string ProfileUrl { get; set; }
        public string Position { get; set; }
        public bool? Status { get; set; }
        public int? RoleId { set; get; }
        public int? DepartmentId { get; set; }
        public int? ShiftWorkId { get; set; }
        public int? ManagerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } = null;
        //  public List<BlogDTO> Blogs { set; get; }
       // public List<PositionHistoryDTO> PositionHistories { get; set; }
    }
}
