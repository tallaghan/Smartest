using Smartest.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Smartest.Services
{
    public class QuestionsService
    {
        

        public QuestionsService()
        {

        }


        public Question NewQuestion()
        {
            return new Question();
        }
    }
}