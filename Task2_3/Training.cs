﻿using System.IO;
using System.Security.Cryptography;

namespace Task2_3
{
    internal class Training
    {
        public string? Description { get; set; }
        public object[]? LecturesAndLessons { get; set; }

        public Training()
        {
        }

        public Training(string? description, object[] lecturesAndLessons)        {
            Description = description;
            LecturesAndLessons = lecturesAndLessons;
        }

        public void Add(object lecutureOrLesson)
        {
            var currentSize = 0;
            if (LecturesAndLessons != null)
            {
                currentSize = LecturesAndLessons.Length;
            }
            var newSize = currentSize + 1;
            var tempArray = new object[newSize];

            if (currentSize > 0)
            {
                for (int index = 0; index < currentSize; index++)
                {
                    tempArray[index] = LecturesAndLessons[index];
                }
            }

            tempArray[newSize - 1] = lecutureOrLesson;

            LecturesAndLessons = tempArray;
        }

        public bool IsPractical()
        {
            if (LecturesAndLessons == null)
                return false;

            foreach (var element in LecturesAndLessons)
            {
                if(element is Lecture) return false;
            }

            return true;
        }

        public Training Clone()
        {
            var clonedTraining = new Training();
            foreach (var element in LecturesAndLessons)
            {
                if (element is Lecture lecture)
                {
                    clonedTraining.Add(new Lecture(lecture.Description, lecture.Topic));
                }
                else if (element is PracticalLesson practical)
                {
                    clonedTraining.Add(new PracticalLesson(practical.Description, practical.TaskLink, practical.SolutionLink));
                }
            }

            clonedTraining.Description = Description;
            return clonedTraining;
        }
    }
}
