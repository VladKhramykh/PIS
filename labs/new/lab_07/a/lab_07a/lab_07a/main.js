$(document).ready(function () {
    GetContacts();
});

function WriteResponse(data) {
    const container = $('#container');
    
    data.forEach(item => {
        container.append($(`
            <form>
                <div class="form-group" >
                    <label for="surnameId">Surname:</label>
                    <input type="text" id="name-${item.Id}" value="${item.Name}" />
                </div>
                <div class="form-group">
                    <label for="phoneId">Phone:</label>
                    <input type="text" id="phone-${item.Id}" value="${item.PhoneNumber}" />
                </div>                
                <button class="btn btn-danger" onclick="DeleteUser('${item.Id}')">Delete</button>
                <button class="btn btn-success" onclick="EditUser('${item.Id}')">Update</button>
            </form>
            <hr/>
        `))
    });
}


function GetContacts() {
    $.ajax({
        url: '/api/users',
        type: 'GET',
        contentType: 'application/json;charset=utf-8',
        success: function (data) {
            WriteResponse(data);
        }
    })
}

function AddUser() {
    let user = {
        Name: $('#addName').val(),
        PhoneNumber: $('#addPhoneNumber').val()
    };

    $.ajax({
        url: '/api/users/',
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        data: JSON.stringify(user),
        success: function (data) {
            GetContacts();
        }
    });
}

function DeleteUser(id) {
    $.ajax({
        url: '/api/users/' + id,
        type: 'DELETE',
        contentType: 'application/json;charset=utf-8',
        success: function (data) {
            GetContacts();
        }
    })
}

function EditUser(id) {
    let user = {
        Id: id,
        Name: $(`#name-${id}`).val(),
        PhoneNumber: $(`#phone-${id}`).val()
    };


    $.ajax({
        url: '/api/users/' + id,
        type: 'PUT',
        contentType: 'application/json;charset=utf-8',
        data: JSON.stringify(user),
        success: function (data) {
            GetContacts();
        }
    })
}