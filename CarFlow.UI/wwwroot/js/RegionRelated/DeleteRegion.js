function deleteRegion(id) {
    if (confirm("Are you sure you want to delete this region?")) {
        fetch('/Region/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting the region.");
            }
        }).catch(error => {
            console.error('Error:', error);
            alert("An error occurred while deleting the region.");
        });
    }
}
