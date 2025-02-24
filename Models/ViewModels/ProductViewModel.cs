﻿using DoAnWeb.Models.Repository.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DoAnWeb.Models.ViewModels;

public class ProductViewModel
{
    public int Id { get; set; }

    [Required, MinLength(4, ErrorMessage = "yêu cầu nhập tên sản phẩm ")]
    public string Name { get; set; }
    [Required, MinLength(4, ErrorMessage = "yêu cầu nhập mô tả sản phẩm")]
    public string Description { get; set; }

    [Required(ErrorMessage = "yêu cầu nhập giá sản phẩm ")]
    public decimal Price { get; set; }

    public int Category { get; set; }
    public int Brad { get; set; }
    public string Image { get; set; } = "noimage.jpg";

    [NotMapped]
    [FileExtension]
    public IFormFile? ImageUpload { get; set; }
}
