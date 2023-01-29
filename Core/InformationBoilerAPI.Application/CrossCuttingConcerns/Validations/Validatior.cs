using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.CrossCuttingConcerns.Validations
{
    public class Validatior
    {
        public Validatior(IValidator validator, object obje)
        {
            var validate = new ValidationContext<object>(obje);
            var result =  validator.Validate(validate);
            if (!result.IsValid)
                throw new ValidationException(result.Errors);

        }
    }
}
