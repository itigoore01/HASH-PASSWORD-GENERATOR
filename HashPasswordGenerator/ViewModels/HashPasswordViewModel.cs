using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashPasswordGenerator.ViewModels
{
    [ImplementPropertyChanged]
    public class HashPasswordViewModel
    {
        public string Password { get; set; }

        public string HashPassword { get; set; }

        public bool AutoCopy { get; set; }

        public HashPasswordViewModel()
        {
            AutoCopy = true;
        }
    }
}
