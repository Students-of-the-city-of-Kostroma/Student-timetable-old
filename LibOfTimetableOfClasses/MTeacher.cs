using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableOfClasses
{
    public class MTeacher : MObject
    {
        string name;
        string surname;
        string middleName;
        string academicDegree;
        string academicRank;
        byte sizeOfTeachingExperience;
        public MTeacher() : base()
        {
            this.keyValuePairs.Add("Name", "");
            this.keyValuePairs.Add("Surname", "");
            this.keyValuePairs.Add("MiddleName", "");
            this.keyValuePairs.Add("AcademicDegree", "");
            this.keyValuePairs.Add("AcademicRank", "");
            this.keyValuePairs.Add("SizeOfTeachingExperience", "");
        }
        public MTeacher(Guid id, string name, string surname, string middleName, string academicDegree, string academicRank, byte sizeOfTeachingExperience) : base(id)
        {
            this.keyValuePairs.Add("Name", name);
            this.keyValuePairs.Add("Surname", surname);
            this.keyValuePairs.Add("MiddleName", middleName);
            this.keyValuePairs.Add("AcademicDegree", academicDegree);
            this.keyValuePairs.Add("AcademicRank", academicRank);
            this.keyValuePairs.Add("SizeOfTeachingExperience", sizeOfTeachingExperience);
        }
    }
}
