using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using GradeBook.Enums;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook: BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeighted): base(name)
        {
            Type = GradeBookType.Standard;
            isWeighted;

        }
    }

}
