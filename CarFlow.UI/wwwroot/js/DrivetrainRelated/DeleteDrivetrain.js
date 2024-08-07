﻿function deleteDrivetrain(id) {
    if (confirm("Are you sure you want to delete this drivetrain?")) {
        fetch('/Drivetrain/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this drivetrain.");
            }
        }).catch(error => {
            console.error('Error', error);
            alert("An error occured while deleting this drivetrain.");
        })
    }
}