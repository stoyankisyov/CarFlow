function populateSelectedCarBrandRelatedModels() {
    var brandId = parseInt(document.getElementById('Brand_Id').value, 10);
    var modelSelect = document.getElementById('Model_Id');

    modelSelect.innerHTML = '<option value="">Select Model</option>';

    if (isNaN(brandId)) {
        console.log("No brand selected or invalid brand ID.");
        return;
    }

    modelsData.forEach(function (model) {
        if (model.brandId === brandId) {
            console.log("Matching model found:", model);
            var displayName = model.name + (model.modelVariant ? " - " + model.modelVariant : "");
            var option = new Option(displayName, model.id);
            modelSelect.add(option);
        }
    });
}
