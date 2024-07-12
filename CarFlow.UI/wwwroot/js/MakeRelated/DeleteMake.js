function deleteMake(id) {
    if (confirm("Are you sure you want to delete this make?")) {
        fetch('/Make/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this make.");
            }
        }).catch(error => {
            console.error('Error: ', error);
            alert("An error occured while deleting this make.");
        });
    }
}