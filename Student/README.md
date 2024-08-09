# Student

```C#
  public class Student : IComparable<Student>
    {

        public Student(string program, string dateRegistered, int studentId)
        {
            Program = program;
            DateRegistered = dateRegistered;
            StudentId = studentId;
        }

        public String Program { get; set; }
        public String DateRegistered { get; set; }
        public int StudentId { get; set; }

        public static bool operator ==(Student x, Student y)
        {

            return object.Equals(x, y);
        }

        public static bool operator !=(Student x, Student y)
        {
            return !object.Equals(x, y);
        }

        int IComparable<Student>.CompareTo(Student dStudents)
        {
            return this.StudentId.CompareTo(dStudents.StudentId);
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != this.GetType())
                return false;
            Student rhs = obj as Student;
            return this.Program == rhs.Program && this.DateRegistered == rhs.DateRegistered && this.StudentId == rhs.StudentId;
        }

        public override int GetHashCode()
        {
            return this.Program.GetHashCode() ^ this.DateRegistered.GetHashCode() ^ this.StudentId.GetHashCode();
        }

        public override string ToString()
        {
            return Program + " " + DateRegistered + " " + StudentId;

        }
    }

```
 
