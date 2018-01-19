﻿using System.Globalization;
using System.Windows.Data;
using Forge.Forms.DynamicExpressions;

namespace Forge.Forms.Validation
{
    public class FalseValidator : FieldValidator
    {
        public FalseValidator(ValidationPipe pipe, IErrorStringProvider errorProvider, IBoolProxy isEnforced,
            IValueConverter valueConverter,
            bool strictValidation, bool validatesOnTargetUpdated)
            : base(pipe, errorProvider, isEnforced, valueConverter, strictValidation, validatesOnTargetUpdated)
        {
        }

        protected override bool ValidateValue(object value, CultureInfo cultureInfo)
        {
            return value is false;
        }
    }
}
