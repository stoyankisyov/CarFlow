$(function () {
    $('#add-subregion').on('click', function () {
        const index = $('.subregion').length;
        const subregionHtml = '<div class="subregion">' +
            '<div class="mb-3">' +
            '<label for="Subregions">Subregion</label>' +
            '<input type="text" name="Subregions[' + index + '].Name" class="form-control" />' +
            '<input type="hidden" name="Subregions[' + index + '].RegionId" value="@Model.Id" />' +
            '<span class="text-danger" data-valmsg-for="Subregions[' + index + '].Name" data-valmsg-replace="true"></span>' +
            '</div>' +
            '<button type="button" class="remove-subregion deleteSubregionButton">Cancel</button>' +
            '</div>';
        $('#subregion-container').append(subregionHtml);
    });

    $('#subregion-container').on('click', '.remove-subregion', function () {
        $(this).parent('.subregion').remove();
    });
});
