function populateSelectedCarMakeRelatedModels() {
    var makeId = parseInt(document.getElementById('Make_Id').value, 10);
    var modelSelect = document.getElementById('Model_Id');

    modelSelect.innerHTML = '<option value="">Select Model</option>';

    if (isNaN(makeId)) {
        console.log("No make selected or invalid make ID.");
        return;
    }

    modelsData.forEach(function (model) {
        if (model.makeId === makeId) {
            console.log("Matching model found:", model);
            var displayName = model.name + (model.modelVariant ? " - " + model.modelVariant : "");
            var option = new Option(displayName, model.id);
            modelSelect.add(option);
        }
    });
}
