using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeekQuiz.Models
{
    public class QuestionModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public IEnumerable<OptionsModel> Options { get; set; }
    }
}