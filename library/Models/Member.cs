namespace library.Models;

// One Member object holds one row of lending.member.
public class Member
{
    public long MemberId { get; set; }             // member_id, primary key
    public string FullName { get; set; } = "";     // full_name, NOT NULL
    public string? Email { get; set; }             // email, may be NULL
    public string MemberType { get; set; } = "Regular"; // member_type, NOT NULL
}