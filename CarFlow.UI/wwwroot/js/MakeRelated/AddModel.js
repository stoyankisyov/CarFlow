$(function () {
    $('#add-model').on('click', function () {
        const index = $('.model').length;
        const modelHtml = '<div class="model">' +
            '<div class="mb-3">' +
            '<label for="Model[' + index + '].Name">Model Name</label>' +
            '<input type="text" name="Models[' + index + '].Name" class="form-control" />' +
            '<label for="Model[' + index + '].ModelVariant">Model Variant</label>' +
            '<input type="text" name="Models[' + index + '].ModelVariant" class="form-control" />' +
            '<span class="text-danger" data-valmsg-for="Models[' + index + '].Name" data-valmsg-replace="true"></span>' +
            '<span class="text-danger" data-valmsg-for="Models[' + index + '].ModelVariant" data-valmsg-replace="true"></span>' +
            '</div>' +
            '<button type="button" class="remove-model deleteModelButton">Cancel</button>' +
            '</div>';
        $('#model-container').append(modelHtml);
    });

    $('#model-container').on('click', '.remove-model', function () {
        $(this).parent('.model').remove();
    });
});
