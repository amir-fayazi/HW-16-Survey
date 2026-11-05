using Survey.Domain.Enums;


namespace Survey.Domain.Dtos
{
    public class LoginResultDto
    {
        public int? Id { get; set; }
        public Role? Role { get; set; }
        public bool IsSuccessful { get; set; }
        public string? Message { get; set; }
    }
}
