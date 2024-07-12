$(function () {
    function showSelectedCarTypePartial() {
        var selectedCarType = $('#carType').val();
        var baseCarPartial = $('#baseCarPartial');
        $('.car-type-partial').hide();
        if (selectedCarType === 'CombustionEngineCar') {
            baseCarPartial.show();
            $('#combustionEngineCarPartial').show();
        } else if (selectedCarType === 'ElectricCar') {
            baseCarPartial.show();
            $('#electricCarPartial').show();
        }
    }

    $('#carType').on('change', function () {
        showSelectedCarTypePartial();
    });
});
