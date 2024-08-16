function deleteBrand(id) {
    if (confirm("Are you sure you want to delete this brand?")) {
        fetch('/Brands/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this brand.");
            }
        }).catch(error => {
            console.error('Error: ', error);
            alert("An error occured while deleting this brand.");
        });
    }
}