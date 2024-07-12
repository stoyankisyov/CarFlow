function deleteModel(modelId) {
    if (!confirm("Are you sure you want to delete this model?")) return;

    $('#model_' + modelId).remove();

    $('.model').each(function (index) {
        $(this).find('input').each(function () {
            var name = $(this).attr('name');
            var newName = name.replace(/\[\d+\]/, '[' + index + ']');
            $(this).attr('name', newName);
        })
    })
}