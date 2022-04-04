﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(car=> car.Description).NotEmpty();
            RuleFor(car => car.Description).MinimumLength(1);
            RuleFor(car => car.DailyPrice).NotEmpty();
            RuleFor(car => car.DailyPrice).GreaterThan(200000).When(car => car.BrandId == 1);
        }
    }
}
