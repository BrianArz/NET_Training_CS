﻿namespace Task2_3
{
    internal class Lecture : Lesson
    {
        public string? Topic { get; set; }

        public Lecture(string? description, string? topic) : base(description)
        {
            Topic = topic;
        }
    }
}
