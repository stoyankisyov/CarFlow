function deleteSubregion(subregionId) {
    if (!confirm("Are you sure you want to delete this subregion?")) return;

    $("#subregion_" + subregionId).remove();

    $('.subregion').each(function (index) {
        $(this).find('input').each(function () {
            var name = $(this).attr('name');
            var newName = name.replace(/\[\d+\]/, '[' + index + ']');
            $(this).attr('name', newName);
        });
    });
}
