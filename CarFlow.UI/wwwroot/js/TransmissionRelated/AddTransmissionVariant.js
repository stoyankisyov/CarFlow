$(function () {
    $('#add-transmissionVariant').on('click', function () {
        var index = $('.transmission').length;
        var transmissionHtml = '<div class="transmission">' +
            '<div class="mb-3">' +
            '<label for="Transmissions">Gear Count</label>' +
            '<input type="number" name="TransmissionVariants[' + index + '].GearCount" class="form-control" />' +
            '<span class="text-danger" data-valmsg-for="TransmissionVariants[' + index + '].GearCount" data-valmsg-replace="true"></span>' +
            '</div>' +
            '<button type="button" class="remove-transmissionVariant deleteTransmissionVariantButton">Cancel</button>' +
            '</div>';
        $('#transmissionVariant-container').append(transmissionHtml);
    });

    $('#transmissionVariant-container').on('click', '.remove-transmissionVariant', function () {
        $(this).parent('.transmission').remove();
    });
});
