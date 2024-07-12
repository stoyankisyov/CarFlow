function populateTransmissionVariants() {
    var transmissionId = parseInt(document.getElementById('Transmission_Id').value, 10);
    var transmissionVariantSelect = document.getElementById('TransmissionVariant_Id');

    console.log("Selected Transmission ID:", transmissionId);
    transmissionVariantSelect.innerHTML = '<option value="">Select Transmission Variant</option>';

    if (isNaN(transmissionId)) {
        console.log("No transmission selected or invalid transmission Id.");
        return;  
    }

    transmissionVariantsData.forEach(function (transmissionVariant) {
        if (parseInt(transmissionVariant.transmissionId, 10) === transmissionId) {
            var displayName = transmissionVariant.gearCount; 
            var option = new Option(displayName, transmissionVariant.id);
            transmissionVariantSelect.add(option);
        }
    });
}
