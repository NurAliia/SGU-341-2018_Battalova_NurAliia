﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgu.StudentTesting.BLL.Contracts
{
    public interface ISubjectLogic
    {
        void AddSubject(Subject subject);
        Subject GetSubjectById(int id);
        IEnumerable<Question> GetQuestionBySubject(int idSubject);
        IEnumerable<Subject> GetSubjectByTeacher(int idUser);
        IEnumerable<Subject> GetSubjectsStudent(int idUser);
        IEnumerable<string> GetListTheme(int idsubject);
    }
}
