namespace WebApplication1.Features
{
    public class GetAllEjerciciosResponse
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public bool IsDone { get; set; }
        public int Category { get; set; }
        public bool IsActive { get; set; } 
        
    }

}