using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewdaBirdenFazlaModel.Models;

namespace ViewdaBirdenFazlaModel.ViewModels
{
    public class DepartmanPersonelViewModels
    {
        public Departman Departman { get; set; }
        public List<Personel> Personeller { get; set; }
    }
}