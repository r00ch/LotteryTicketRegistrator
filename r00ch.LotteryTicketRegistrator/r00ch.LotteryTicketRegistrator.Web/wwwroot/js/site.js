// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$('#password')
    .keyboard({
        openOn: null,
        stayOpen: true,
        layout: 'qwerty'
    })
    .addTyping();

$('#password').click(function () {
    var kb = $('#password').getkeyboard();
    // close the keyboard if the keyboard is visible and the button is clicked a second time
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
        layout: 'qwerty'
    })
    .addTyping();

$('#login').click(function () {
    var kb = $('#login').getkeyboard();
    // close the keyboard if the keyboard is visible and the button is clicked a second time
    if (kb.isOpen) {
        kb.close();
    } else {
        kb.reveal();
    }
});