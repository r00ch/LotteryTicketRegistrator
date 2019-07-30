// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#password')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'qwerty',
        autoAccept: true
    })
    .addTyping();

$('#password').click(function () {
    var kb = $('#password').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});

$('#login')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'qwerty',
        autoAccept: true
    })
    .addTyping();

$('#login').click(function () {
    var kb = $('#login').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});

$('#phoneNumber')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'num',
        autoAccept: true
    })
    .addTyping();

$('#phoneNumber').click(function () {
    var kb = $('#phoneNumber').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});

$('#firstName')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'qwerty'
    })
    .addTyping();

$('#firstName').click(function () {
    var kb = $('#firstName').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});

$('#lastName')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'qwerty'
    })
    .addTyping();

$('#lastName').click(function () {
    var kb = $('#lastName').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});

$('#postalCode')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'num'
    })
    .addTyping();

$('#postalCode').click(function () {
    var kb = $('#postalCode').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});

$('#emailAddress')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'qwerty'
    })
    .addTyping();

$('#emailAddress').click(function () {
    var kb = $('#emailAddress').getkeyboard();

    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});