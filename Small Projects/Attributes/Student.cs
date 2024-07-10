using System.ComponentModel.DataAnnotations;
namespace Attributes;

public class Student
{
    [RequiredAttribute]
    public int Id { get; set;}
    public string Name { get; set;}
}
