namespace SecondApp;
using System.ComponentModel.DataAnnotations;

public class Numbers
{ 
    [Key]
    public int Id { get; set; }
    
    public double Number1 { get; set; }
    public double Number2 { get; set; }
}