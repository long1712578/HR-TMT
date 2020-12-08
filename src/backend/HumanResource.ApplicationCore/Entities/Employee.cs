using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.ApplicationCore.Entities
{
    public class Employee: BaseEntity
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; } = null;
        public DateTime DateOfBirth { get; set; }
        public DateTime? DateCreateNewPassword { set; get; } = null;
        public string PhoneNumber { get; set; }
        public string Addresses { get; set; }
        public string Gender { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string AvatarUrl { get; set; }
        public string ProfileUrl { get; set; }
        public bool IsActive { get; set; }
        public int? RoleId { set; get; }
        public int? DepartmentId { get; set; } = null;
        public int? ShiftWorkId { set; get; } = null;

        public virtual Role Role { set; get; }
        public virtual ShiftWork ShiftWork { get; set; }
        public virtual ICollection<Blog> Blogs { get; set; }
        public Department Department { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
        public List<PositionHistory> PositionHistories { get; set; } = null;
        public virtual ICollection<RequestApproval> RequestApprovals { get; set; }
        public int ManagerId { get; set; }

    }
}