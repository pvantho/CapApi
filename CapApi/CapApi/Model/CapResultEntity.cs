using System;
using System.Collections.Generic;
namespace CapApi.Model
{
    public class YearGrade
    {
        public int year { get; set; }
        public string grade { get; set; }

        public YearGrade(int year, String grade)
        {
            this.year = year;
            this.grade = grade;
        }
    }

    //{"subject":"Strategic Management Accounting","results":[{"year":2015,"grade":"FAIL"}
    public class CapResultEntity
    {
        public String subject { get; set; }
        public List<YearGrade> results { get; set; }

        public CapResultEntity(String subject, List<YearGrade> gradeList)
        {
            this.subject = subject;
            this.results = gradeList;

        }
    }
}
