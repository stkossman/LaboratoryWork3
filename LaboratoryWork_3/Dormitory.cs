using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratoryWork_3
{
    public class Dormitory
    {
        public int Places { get; set; }
        public int OccupiedPlaces { get; set; }
        public List<Student> students;
        public List<Student> settledStudents;
        public readonly string Path = "students.txt";
        private static int currentId = 1;

        public Dormitory(int totalplaces)
        {
            Places = totalplaces;
            students = new List<Student>();
            settledStudents = new List<Student>();
        }

        public void Save()
        {
            var studentLines = students.Select(std => $"{std.Id} | {std.Name} | {std.Contact} | {std.Priority}");
            var settledStudentLines = settledStudents.Select(std => $"{std.Id} | {std.Name} | {std.Contact} | settled");

            File.WriteAllLines(Path, studentLines.Concat(settledStudentLines));
        }

        public void Load()
        {
            students.Clear();
            settledStudents.Clear();
            if (!File.Exists(Path)) return;

            foreach (var line in File.ReadLines(Path))
            {
                var parts = line.Split('|').Select(p => p.Trim()).ToArray();

                if (parts.Length < 3 || !int.TryParse(parts[0], out int id)) continue;

                var student = new Student { Id = id, Name = parts[1], Contact = parts[2] };

                if (parts.Length == 3)
                    settledStudents.Add(student);
                else if (parts.Length == 4 && int.TryParse(parts[3], out int priority) && parts[3] != "settled")
                {
                    student.Priority = priority;
                    students.Add(student);
                }
            }
            OccupiedPlaces = settledStudents.Count;
        }

        public void Edit(Student student, bool isSettled = false)
        {
            if (!isSettled)
            {
                var existingStd = settledStudents.FirstOrDefault(std => std.Id == student.Id);
                if (existingStd != null)
                {
                    existingStd.Name = student.Name;
                    existingStd.Contact = student.Contact;
                    Save();
                }
            }
            else
            {
                var existingStd = students.FirstOrDefault(std => std.Id == student.Id);
                if (existingStd != null)
                {
                    existingStd.Name = student.Name;
                    existingStd.Contact = student.Contact;
                    existingStd.Priority = student.Priority;
                    Save();
                }
            }
        }

        public void Delete(int stdId)
        {
            var student = students.FirstOrDefault(std => std.Id == stdId);
            if (student != null)
            {
                students.Remove(student);
                Save();
            }
        }

        public void DeleteSettled(int stdId)
        {
            var student = settledStudents.FirstOrDefault(std => std.Id == stdId);
            if (student != null)
            {
                settledStudents.Remove(student);
                OccupiedPlaces--;
                Save();
            }
        }

        public List<Student> Get()
        {
            return students.OrderBy(std => std.Priority).ToList();
        }

        public List<Student> GetSettledStudents()
        {
            return settledStudents;
        }

        public bool Settle(int stdId)
        {
            if (OccupiedPlaces > Places)
                return false;

            var student = students.FirstOrDefault(std => std.Id == stdId);
            if (student != null)
            {
                students.Remove(student);
                settledStudents.Add(student);
                OccupiedPlaces++;
                Save();
                return true;
            }
            return false;
        }

        public void Add(Student student)
        {
            student.Id = currentId++;
            students.Add(student);
            Save();
        }

        public int GetAvailable()
        {
            return Places - OccupiedPlaces;
        }
    }
}
