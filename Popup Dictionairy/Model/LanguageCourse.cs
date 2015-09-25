using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopupDictionairy.App.Model
{
    public class LanguageCourse
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime LastLesson { get; set; }

        public DateTime FirstLesson { get; set; }

        public string FromLanguage { get; set; }

        public string ToLanguage { get; set; }

        public List<IQuestion> CourseItems { get; set; }
    }
}
