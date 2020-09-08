function confirmDelete(uniqueId, isDeleteClicked) {
    var confirmDeleteSpan = 'confirmDeleteSpan_' + uniqueId;
    var deleteSpan = 'deleteSpan_' + uniqueId;

    if (isDeleteClicked) {
        $('#' + deleteSpan).hide();
        $('#' + confirmDeleteSpan).show();
    }
    else
    {
        $('#' + deleteSpan).show();
        $('#' + confirmDeleteSpan).hide();
    }
}