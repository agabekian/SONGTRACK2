using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace cSharp2022.Models
{ 
    public class FormWrapper
    {
        public Recordis RecForm {get;set;}
        public Connect ConnectForm {get;set;}
    }
}