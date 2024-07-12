﻿function deleteEngine(id) {
    if (confirm("Are you sure you want to delete this engine?")) {
        fetch('/Engine/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this engine.");
            }
        }).catch(error => {
            console.log('Error', error);
            alert("An error occured while deleting this engine.")
        })
    }
}