namespace LU1_1._3.Models
{
    public class Child
    {
        public Guid Id { get; set; } // NVARCHAR(450)
        public string Name { get; set; } // NVARCHAR(50)
        public string TrajectName { get; set; } // NVARCHAR(50)
        public string ArtsName { get; set; } // NVARCHAR(50)
        public Guid UserId { get; set; } // NVARCHAR(450)
    }
}
