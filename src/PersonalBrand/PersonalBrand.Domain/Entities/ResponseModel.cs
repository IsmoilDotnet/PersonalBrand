namespace PersonalBrand.Domain.Entities
{
    public class ResponseModel
    {
        public string Message { get; set; }
        public bool IsSuccess { get; set; } = false;
        public int StatusCode { get; set; }
    }
}
