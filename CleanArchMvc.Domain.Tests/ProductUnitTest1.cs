using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        //[Fact (DisplayName = "Create Product Valid Parameters")]
        //public void CreateProduct_WithValidParameters_ResultObjectValidState()
        //{
        //    Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "Image");
        //    action.Should()
        //        .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        //}
        [Fact(DisplayName = "Create Product Negative Id Value")]
        public void CreateProduct_NegativeIdValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 9.99m, 99, "Product Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid Id value");
        }
        [Fact(DisplayName = "Create Product Short Name Value")]
        public void CreateProduct_ShortNameValue_DomainExceptionInvalidId()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 9.99m, 99, "Product Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid name, too short, minimum 3 characters");
        }
        [Fact(DisplayName = "Create Product Long Image Name Value")]
        public void CreateProduct_LongImageName_DomainExceptionInvalidId()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 
                99, "Product Image tooooooooooooooooooooooooooooooooooooooooooooooo longggggggggggggggggggggggggggggggggggggggggggggggg");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid image name, too long, maximum 250 characters");
        }
        //[Fact(DisplayName = "Create Product Empty Image Name Value")]
        //public void CreateProduct_WithEmptyImageName_NoDomainException()
        //{
        //    Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, "");
        //    action.Should()
        //        .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        //}
        [Fact(DisplayName = "Create Product Null Image Name Value")]
        public void CreateProduct_WithNullImageName_NoDomainExceptionInvalidId()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 9.99m, 99, null);
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact (DisplayName ="Create Product Invalid Prive Value")]
        public void CreateProduct_InvalidPriceValue_DomainException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", -9.99m, 99, "Product Image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid price value");
        }

        [Theory (DisplayName ="Create Product Invalid Stock Value")]
        [InlineData(-5)]
        public void CreateProduct_InvalidStockValue_ExceptionDomainNegativeValue(int value)
        {
            Action action = () => new Product(1, "Pro", "Product Description", 9.99m, value, "product image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Invalid stock value");
        }

    }
}
