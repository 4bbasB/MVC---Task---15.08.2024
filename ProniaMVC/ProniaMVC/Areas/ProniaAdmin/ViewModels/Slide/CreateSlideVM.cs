﻿using System.ComponentModel.DataAnnotations;
namespace ProniaMVC.Areas.ProniaAdmin.ViewModels
{
    public class CreateSlideVM
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public int Order { get; set; }
        [Required]
        public IFormFile Photo { get; set; }
    }
}
