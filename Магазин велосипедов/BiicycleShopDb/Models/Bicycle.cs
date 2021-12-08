using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BiicycleShopDb.Models
{
    public class Bicycle
    {
        public int BicycleId { get; set; }
        [Required(ErrorMessage="Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Class is required")]
        public string Class { get; set; }
        [Required(ErrorMessage = "Whel diameter is required")]
        public int Wheel_Diameter { get; set; }
        [Required(ErrorMessage = "Color is required")]
        public string Clolor { get; set; }
        [Required(ErrorMessage = "Number speed is required")]
        public int Number_Speeds { get; set; }
        [Required(ErrorMessage = "Frame is required")]
        public string Frame { get; set; }
        [Required(ErrorMessage = "Frame material is required")]
        public string Frame_Material { get; set; }
        [Required(ErrorMessage = "Img url is required")]
        public string Img_Url { get; set; }
        [Required(ErrorMessage = "Prise is required")]
        public int Prise { get; set; }
    }
}
