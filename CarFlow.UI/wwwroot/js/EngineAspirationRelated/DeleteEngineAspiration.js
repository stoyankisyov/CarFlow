function deleteEngineAspiration(id) {
    if (confirm("Are you sure you want to delete this engine aspiration?")) {
        fetch('/EngineAspiration/Delete/' + id, {
            method: 'DELETE'
        }).then(response => {
            if (response.ok) {
                window.location.reload();
            } else {
                alert("There was an error deleting this engine aspiration.");
            }
        }).catch(error => {
            console.log('Error', error);
            alert("An error occured while deleting this engine aspiration.")
        })
    }
}