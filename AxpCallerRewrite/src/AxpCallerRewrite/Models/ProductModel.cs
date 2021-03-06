﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxpCallerRewrite.Models
{
    public class ProductModel
    {
        [Required(ErrorMessage = "Company ID are Required")]
        [RegularExpression("^([0-9a-zA-Z]{3}[-]){2}[0-9a-zA-Z]{3}$", ErrorMessage = "Company ID is Not Valid")]
        public string CompanyId { get; set; }
        public int UserId { get; set; }
        public string ProdIdLevelNum { get; set; }
        public string EnvironmentLevel { get; set; }
    }
}
