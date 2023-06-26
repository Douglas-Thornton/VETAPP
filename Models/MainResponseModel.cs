using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VETAPP.Models
{
    internal class MainResponseModel
    {
        public bool IsSuccess { get; set; }
        public string ErrorMEssage { get; set; }
        public object Content { get; set; }
    }
}
