using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssignment01.Components
{
    class Diseases
    {
        public string DisName { get; set; }
        public string DisSeverity { get; set; }
        public string DisCause { get; set; }
        public string DisDescription { get; set; }

    }
    class Symptoms:Diseases
    {
        public string Symptom { get; set; } = null;
        public string SymptomDescription { get; set; } = null;

    }
}
