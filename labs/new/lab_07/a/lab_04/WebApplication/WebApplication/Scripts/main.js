$('#submitCreateBtn').click(function (e) {
    e.preventDefault();
    AddUser();
});

$('#submitUpdateBtn').click(function (e) {
    e.preventDefault();
    EditUser();
});

$(document).ready(function () {
    GetContacts();
});

function WriteResponse(data) {
    let users = JSON.parse(data);
    let html = '<tr>';
    users.forEach(item => html += `<th>${item.Id}</th><th>${item.Name}</th><th>${item.PhoneNumber}</th><th><button onclick='EditUser(${item.Id})'>Edit</button></th><th><button onclick='DeleteUser(${item.Id})'>Edit</button></th>`);
    $('#tbody').html()
}


function GetContacts() {
    $.ajax({
        url: '/api/dict',
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
        url: '/api/dict/',
        type: 'POST',
        contentType: 'application/json;charset=utf-8',
        data: JSON.stringify(user),
        success: function (data) {
            GetContacts();
        }
    })
}

function DeleteUser(id) {
    $.ajax({
        url: '/api/dict/'+id,
        type: 'GET',
        contentType: 'application/json;charset=utf-8',
        success: function (data) {
            GetContacts();
        }
    })
}

function EditUser() {
    let user = {
        Name: $('#addName').val(),
        PhoneNumber: $('#addPhoneNumber').val()
    };

    $.ajax({
        url: '/api/dict/'+id,
        type: 'PUT',
        contentType: 'application/json;charset=utf-8',
        data: JSON.stringify(user),
        success: function (data) {
            GetContacts();
        }
    })
}