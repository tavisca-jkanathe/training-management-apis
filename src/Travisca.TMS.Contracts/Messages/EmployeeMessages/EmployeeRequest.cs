namespace Tavisca.TMS.Contracts.Messages.EmployeeMessages
{
    public class EmployeeRequest
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Type { get; set; }
        public string Source { get; set; }
        public string TeamId { get; set; }
    }
}
