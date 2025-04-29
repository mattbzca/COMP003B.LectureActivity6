﻿namespace COMP003B.LectureActivity6.Models
{
    public class Enrollments
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        
        // Nullable navigation properties
        public virtual Student? Student { get; set; }
        public virtual Course? Course { get; set; }
    }
}
