using Castle.DynamicProxy;
using FluentValidation;
using InformationBoilerAPI.Application.CrossCuttingConcerns.Validations;
using InformationBoilerAPI.Application.Utilities.Interceptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.CrossCuttingConcerns.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            _validatorType = validatorType;
        }

        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                CheckValidation.Validate(validator, entity);
            }
        }
    }
}
