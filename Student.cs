namespace CourseManagment
{
    internal class Student
    {
        private string _name;
        private string _surname;
        private Group group;
        public bool IsGuaranteed;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                //if (value.NameCheck())
                //{
                //   _name = value.StringCorrector();
                //}
                //else
                //{
                //    Console.WriteLine("Name must include at least 3 letters, and no digits");

                //}              
            }
        }
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        public Student()
        {
        }
    }
}
