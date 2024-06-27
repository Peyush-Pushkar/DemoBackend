using System.ComponentModel.DataAnnotations;

namespace DemoProject01.Entities
{
    public class TestEntity2
    {

            [Key]
            public int Id { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
        
    }
}
