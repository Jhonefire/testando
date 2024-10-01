using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using LojaDeRoupas.Models;
using LojaDeRoupas.Models.ViewModels;

namespace LojaDeRoupas.Models.ViewModels
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
