function deleteTransmissionType(id) {
    if (confirm("Are you sure you want to delete this transmission?")) {
        fetch('/Transmissions/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this transmission.");
            }
        }).catch(error => {
            console.error('Error:', error);
            alert("An error occurred while deleting this transmission.");
        });
    }
}