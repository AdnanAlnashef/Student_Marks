using System;
using System.Collections.Generic;
using System.Text;
using Student_Marks.Enums;

namespace Student_Marks.Helpers
{
    public static class StudentHelper
    {
        //هذه الميثود تاخذ علامة الاختبار الاول والثاني وتحسب تقدير الطالب على حسب مجموع العلامتين وتقسيمهم على 2
        public static Estimates SumEstimate(double firstMarks, double secondMarks)
        {
            double total = (firstMarks + secondMarks) / 2;
            if (total >= 0 && total < 50)
                return Estimates.Failed;
            if (total >= 50 && total <= 70)
                return Estimates.Good;
            if (total > 70 && total < 90)
                return Estimates.VeryGood;
            else
                return Estimates.Excellent;
        }
    }
}
