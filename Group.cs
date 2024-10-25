namespace CourseManagment
{
    internal class Group
    {
        public List<Student> Students;
        public string No;
        public static int GroupCountNo = 100;
        public string Category;
        public bool IsOnline;
        public byte Limit;
        public Group group;
        public Group(string no, string category, bool isOnline, byte limit)
        {
            No = no;
            Category = category;
            IsOnline = isOnline;
            Limit = limit;

        }

        public void CreateStudent(Student student)
        {
            Students.Add(student);

        }


    }
}
