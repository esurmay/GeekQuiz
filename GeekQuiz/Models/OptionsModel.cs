using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class OptionsModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int QuestionId { get; set; }

        public bool IsCorrect { get; set; }
    }
}