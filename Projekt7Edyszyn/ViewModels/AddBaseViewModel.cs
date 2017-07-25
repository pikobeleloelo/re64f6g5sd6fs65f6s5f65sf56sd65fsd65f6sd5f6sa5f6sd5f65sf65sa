using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Projekt7Edyszyn.Models;

namespace Projekt7Edyszyn.ViewModels
{
    public class AddBaseViewModel
    {
        public Base Base { get; set; }
        public List<Customer> Customers { get; set;}
    }
}