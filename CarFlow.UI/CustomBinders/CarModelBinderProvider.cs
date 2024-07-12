using CarFlow.UI.Models.ViewModels;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CarFlow.UI.CustomBinders
{
    public class CarModelBinderProvider : IModelBinderProvider
    {
        public IModelBinder? GetBinder(ModelBinderProviderContext context)
        {
            if (context.Metadata.ModelType != typeof(CarViewModel))
            {
                return null;
            }

            var subclasses = new[] { typeof(CombustionEngineCarViewViewModel), typeof(ElectricCarViewViewModel) };

            var binders = new Dictionary<Type, (ModelMetadata, IModelBinder)>();
            foreach (var type in subclasses)
            {
                var modelMetadata = context.MetadataProvider.GetMetadataForType(type);
                binders[type] = (modelMetadata, context.CreateBinder(modelMetadata));
            }

            return new CarModelBinder(binders);
        }
    }
}
