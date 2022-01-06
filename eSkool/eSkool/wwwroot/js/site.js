// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//    var dt = new Date();
//document.getElementById('date-time').innerHTML = dt;

n = new Date();
y = n.getFullYear();
m = n.getMonth() + 1;
d = n.getDate();
date = m + "/" + d + "/" + y;
time = n.getHours() + ":" + n.getMinutes() + ":" + n.getSeconds();
dateTime = date + ' ' + time;
document.getElementById("date-time").innerHTML = dateTime;

//--------modal popup in showw class module--------
// Get the modal
modal = document.getElementById("myModal");

//// Get the button that opens the modal
btn = document.getElementsByClassName("show-btn");

//// Get the <span> element that closes the modal
span = document.getElementsByClassName("close")[0];

//// When the user clicks the button, open the modal
btn[0].onclick = function () {
    modal.style.display = "block";
}
//btn[1].onclick = function () {
//    modal.style.display = "block";
//}
//btn[2].onclick = function () {
//    modal.style.display = "block";
//}

//// When the user clicks on <span> (x), close the modal
span.onclick = function () {
    modal.style.display = "none";
}

//// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
    if (event.target == modal) {
        modal.style.display = "none";
        span = document.getElementsByClassName("close")[0];
    }
}
//----------function to print challan-----------
function printDiv() {
    divContents = document.getElementById("challan").innerHTML;
    a = window.open('', '', 'height=600, width=600');
    a.document.write('<html><body>');
    a.document.write(divContents); 
    a.document.write('</body></html>');
    a.document.close();
    a.print();
}
function popModal() {
    modal = document.getElementById("myModal");
    btn = document.getElementsByClassName("show-btn");
    modal.style.display = "block";  
}
function closeModal() {
    modal = document.getElementById("myModal");
    modal.style.display = "none";
}
//modal = document.getElementsByClassName("modal")[0];

// Get the button that opens the modal
//btn = document.getElementsByClassName("complain-btn")[0];

//// Get the <span> element that closes the modal
//span = document.getElementsByClassName("close")[0];

//// When the user clicks the button, open the modal
//btn[0].onclick = function () {
//    modal.style.display = "block";
//}


//// When the user clicks on <span> (x), close the modal
//span.onclick = function () {
//    modal.style.display = "none";
//}

//// When the user clicks anywhere outside of the modal, close it
//window.onclick = function (event) {
//    if (event.target == modal) {
//        modal.style.display = "none";
//    }
//}    



