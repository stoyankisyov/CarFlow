﻿function deleteFuelType(id) {
    if (confirm("Are you sure you want to delete this fuel type?")) {
        fetch('/FuelType/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this fuel type.");
            }
        }).catch(error => {
            console.error('Error', error);
            alert("An error occured while deleting this fuel type.")
        })
    }
}