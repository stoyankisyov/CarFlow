using CarFlow.UI.Enums;
using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CarFlow.UI.CustomBinders;

public class CarModelBinder(Dictionary<Type, (ModelMetadata, IModelBinder)> binders) : IModelBinder
{
    public async Task BindModelAsync(ModelBindingContext bindingContext)
    {
        var modelCarTypeName =
            ModelNames.CreatePropertyModelName(bindingContext.ModelName, nameof(CarViewModel.CarType));
        var modelTypeValue = bindingContext.ValueProvider.GetValue(modelCarTypeName).FirstValue;

        IModelBinder modelBinder;
        ModelMetadata modelMetadata;

        if (modelTypeValue == CarType.CombustionEngineCar.ToString())
        {
            (modelMetadata, modelBinder) = binders[typeof(CombustionEngineCarViewViewModel)];
        }
        else if (modelTypeValue == CarType.ElectricCar.ToString())
        {
            (modelMetadata, modelBinder) = binders[typeof(ElectricCarViewViewModel)];
        }
        else
        {
            bindingContext.Result = ModelBindingResult.Failed();

            return;
        }

        var newBindingContext = DefaultModelBindingContext.CreateBindingContext(
            bindingContext.ActionContext,
            bindingContext.ValueProvider,
            modelMetadata,
            null,
            bindingContext.ModelName);

        await modelBinder.BindModelAsync(newBindingContext);
        bindingContext.Result = newBindingContext.Result;

        if (newBindingContext.Result is { IsModelSet: true, Model: not null })
        {
            bindingContext.ValidationState[newBindingContext.Result.Model] = new ValidationStateEntry
            {
                Metadata = modelMetadata
            };
        }
    }
}