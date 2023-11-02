using Castle.DynamicProxy;
using FluentValidation;
using Shop.Core_.Core.Utilities.Interceptors;
using Shop.Core_.CrossCuttingConcerns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core_.Aspects.Autofac.Validation
{
    public class ValidationAspect: MethodInterception
    {
        private readonly Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("bu bir doğrulama sınıfı değil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator?)Activator.CreateInstance(_validatorType);
            var entityType = _validatorType.BaseType?.GetGenericArguments()?.FirstOrDefault() ?? typeof(object);

            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                if (validator != null)
                {
                    ValidationTool.Validate(validator, entity);
                }
                else
                {
                    // validator null ise yapılacak işlem (opsiyonel)
                }
            }
        }

    }
}
