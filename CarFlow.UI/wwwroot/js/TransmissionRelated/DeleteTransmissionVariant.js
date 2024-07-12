function deleteTransmissionVariant(transmissionVariantId) {
    if (!confirm("Are you sure you want to delete this transmission variant?")) return;
    
    $("#transmissionVariant_" + transmissionVariantId).remove();
    
    $('.transmissionVariant').each(function (index) {
        $(this).find('input').each(function () {
            var name = $(this).attr('name');
            var newName = name.replace(/\[\d+\]/, '[' + index + ']');
            $(this).attr('name', newName);
        });
    });
}