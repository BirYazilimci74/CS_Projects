class Student
{
    public string? Name {get; set;}
    public string? Surname {get; set;}
    public int Id {get; set;}
    public int[] Grades {get; set;}
    public bool is_Passed {get; set;}

    public Student()
    {
        Grades = new int[3];
    }
}