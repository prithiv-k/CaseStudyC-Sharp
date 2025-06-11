﻿using StudentDAL.Domain;
using StudentDAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDAL.BusinessLogic
{
    public class StudentService
    {
        private readonly IStudentRepository _repository;

        public StudentService(IStudentRepository repository)
        {
            _repository = repository;
        }

        public List<Student> GetAllStudents()
        {
            return _repository.GetAll();
        }

        public Student GetStudentByRollNo(int rollNo)
        {
            return _repository.GetByRollNo(rollNo);
        }

        public Student GetStudentByName(string name)
        {
            return _repository.GetByName(name);
        }

        public void AddStudent(Student student)
        {
            _repository.Add(student);
        }

        public void UpdateStudent(Student student)
        {
            _repository.Update(student);
        }

        public void DeleteStudent(int rollNo)
        {
            _repository.Delete(rollNo);
        }
    }
}