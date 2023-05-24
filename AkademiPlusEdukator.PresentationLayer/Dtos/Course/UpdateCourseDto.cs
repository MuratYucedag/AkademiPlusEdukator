﻿namespace AkademiPlusEdukator.PresentationLayer.Dtos.Course
{
    public class UpdateCourseDto
    {
        public int CourseID { get; set; }
        public string CourseTitle { get; set; }
        public decimal Price { get; set; }
        public int Score { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryID { get; set; }
    }
}
