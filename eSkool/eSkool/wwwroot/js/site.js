// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//    var dt = new Date();
//document.getElementById('date-time').innerHTML = dt;

//n = new Date();
//y = n.getFullYear();
//m = n.getMonth() + 1;
//d = n.getDate();
//date = m + "/" + d + "/" + y;
//time = n.getHours() + ":" + n.getMinutes() + ":" + n.getSeconds();
//dateTime = date + ' ' + time;
//document.getElementById("date-time").innerHTML = dateTime;

//--------modal popup in showw class module--------
// Get the modal
//modal = document.getElementById("myModal");

//// Get the button that opens the modal
//btn = document.getElementsByClassName("show-btn");

//// Get the <span> element that closes the modal
//span = document.getElementsByClassName("close")[0];

//// When the user clicks the button, open the modal
//btn[0].onclick = function () {
//    modal.style.display = "block";
//}
//btn[1].onclick = function () {
//    modal.style.display = "block";
//}
//btn[2].onclick = function () {
//    modal.style.display = "block";
//}

//// When the user clicks on <span> (x), close the modal
//span.onclick = function () {
//    modal.style.display = "none";
//}

//// When the user clicks anywhere outside of the modal, close it

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
function leaveModal() {
    modal = document.getElementById("leave-Modal");
    btn = document.getElementsByClassName("show-leave");
    modal.style.display = "block";
}
function closeLeave() {
    modal = document.getElementById("leave-Modal");
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

//to = document.getElementById("to");
//from = document.getElementById("from");
//duration = document.getElementById("duration");
function calculateDuration() {
    if (from.value != null && to.value != null) {
        days1 = to.value;
        days2 = from.value;
        m1 = parseInt(days1[5] + days1[6]);
        d1 = parseInt(days1[8] + days1[9]);
        m2 = parseInt(days2[5] + days2[6]);
        d2 = parseInt(days2[8] + days2[9]);
        if (m2 < m1) {

            if (m2 % 2 == 0) {
                temp = 30 - d2;
                total = temp + d1 + 1;

            }
            else {
                temp = 31 - d2;
                total = temp + d1 + 1;
            }

        }
        else if (m2 == m1) {
            if (d1 < d2) {
                total = 0;
            }
            else
                total = d1 - d2 + 1;
        }
        else
            total = 0;
    }
    else
        total = 0;
    //total = (to.value - from.value).Days;

    document.getElementById("leaves-duration").innerHTML = total;
}

function assign() {
    s = document.getElementById("subject-name");
    selectedS = s.options[s.selectedIndex].text;
    t = document.getElementById("teacher-name");
    selectedT = t.options[t.selectedIndex].text;
    //document.getElementById("text").value = selectedT + " will teach " + selectedS;

    table = document.getElementById("assign");

    rowCount = table.rows.length;
    row = table.insertRow(rowCount);

    cell1 = row.insertCell(0);
    cell1.innerHTML = selectedS;

    cell2 = row.insertCell(1);
    cell2.innerHTML = "is assigned to";

    cell3 = row.insertCell(2);
    cell3.innerHTML = selectedT;

    cell4 = row.insertCell(3);
    //element1 = document.createElement("a");
    //element1.addEventListener("click", unassign, false); 
    cell4.className = "dlt-row";
    cell4.innerHTML = "X";
    cell4.addEventListener("click", unassign, false);
    
    //cell4.appendChild(element1);
}
//function myFunction() {
//    document.getElementById("myTable").deleteRow(0);
//}

function unassign() {
    this.parentElement.style.display = 'none';
    //closebtns = document.getElementsByClassName("dlt-row");
    //for (i = 0; i < closebtns.length; i++) {
    //    closebtns[i].addEventListener("click", function () {
           
    //    });
    //}
}
currentTab = 0; // Current tab is set to be the first tab (0)
showTab(currentTab); // Display the current tab

function showTab(n) {
    // This function will display the specified tab of the form...
     x = document.getElementsByClassName("tab");
    x[n].style.display = "block";
    //... and fix the Previous/Next buttons:
    if (n == 0) {
        document.getElementById("prevBtn").style.display = "none";
    } else {
        document.getElementById("prevBtn").style.display = "inline";
    }
    if (n == (x.length - 1)) {
        document.getElementById("nextBtn").innerHTML = "Submit";
    } else {
        document.getElementById("nextBtn").innerHTML = "Next";
    }
    //... and run a function that will display the correct step indicator:
    fixStepIndicator(n)
}
function nextPrev(n) {
    // This function will figure out which tab to display
     x = document.getElementsByClassName("tab");
    // Exit the function if any field in the current tab is invalid:
    if (n == 1 && !validateForm()) return false;
    // Hide the current tab:
    x[currentTab].style.display = "none";
    // Increase or decrease the current tab by 1:
    currentTab = currentTab + n;
    // if you have reached the end of the form...
    if (currentTab >= x.length) {
        // ... the form gets submitted:
        document.getElementById("regForm").submit();
        return false;
    }
    // Otherwise, display the correct tab:
    showTab(currentTab);
}

function validateForm() {
    // This function deals with validation of the form fields
     var x, y, i, valid = true;
    x = document.getElementsByClassName("tab");
    y = x[currentTab].getElementsByTagName("input","select");
    // A loop that checks every input field in the current tab:
    for (i = 0; i < y.length; i++) {
        // If a field is empty...
        if (y[i].value == "") {
            // add an "invalid" class to the field:
            y[i].className += " invalid";
            // and set the current valid status to false 
            valid = false;
        }
    }
    // If the valid status is true, mark the step as finished and valid:
    if (valid) {
        document.getElementsByClassName("step")[currentTab].className += " finish";
    }
    return valid; // return the valid status
}

function fixStepIndicator(n) {
    // This function removes the "active" class of all steps...
     i, x = document.getElementsByClassName("step");
    for (i = 0; i < x.length; i++) {
        x[i].className = x[i].className.replace(" active", "");
    }
    //... and adds the "active" class on the current step:
    x[n].className += " active";
}
//window.onload = function () {
//    openChart();
//};
function openChart(yValues) {
    xValues = ["English", "Urdu", "Mathematics", "Science","Pak-Study", "Islamiat", "Physics", "Chemistry", "Computer", "Boilogy"];
        
       
    //yValues = { e, u, m, s, pak, i, p, c, comp, b };
    barColors = [
        "#e5a0c3",
        "#00aba9",
        "#2b5797",
        "#41e6f7",
        "#ef28a9",
        "#ecef28",
        "#9ea5c5",
        "#a0e5c5",
        "#ef9628",
        "purple"
    ];

    new Chart("myChart", {
        type: "doughnut",
        data: {
            labels: xValues,
            datasets: [{
                backgroundColor: barColors,
                data: yValues
            }]
        },
        options: {
            title: {
                display: true,
                text: "Subject Teachers"
            }
        }
    });
}




function displayCalendar() {
     dt = new Date();
     month = dt.getMonth(); // read the current month
     year = dt.getFullYear(); // read the current year

    dt = new Date(year, month, 01);//Year , month,date format

    first_day = dt.getDay(); //, first day of present month
   
    //document.write("first_day=" + first_day + "<br><br>");
    
    dt.setMonth(month + 1, 0); // Set to next month and one day backward.
    last_date = dt.getDate(); // Last date of present month
   
    //document.write(dt); // Last date in full
   
    //document.write("<br><br> Last Date of the month =" + last_date + "<br><br>");

    dy = 1; // day variable for adjustment of starting date.
    //cal.innerHTML += "<table><tr><td>Su</td><td>Mon</td><td>Tue</td><td>Wed</td><td>Thu</td><td>Fri</td><td>Sat</td></tr></table>";
    //document.write("<table><tr><td>Su</td><td>Mon</td><td>Tue</td><td>Wed</td><td>Thu</td><td>Fri</td><td>Sat</td>");
    //cal.innerHTML += "<table><tr>";
    table = document.getElementById("calendar");

    rowCount = table.rows.length;
    row = table.insertRow(rowCount);
    row.className = "row1";
    cell1 = row.insertCell(0);
    cell1.innerHTML = "SUN";
    cell2 = row.insertCell(1);
    cell2.innerHTML = "MON";
    cell3 = row.insertCell(2);
    cell3.innerHTML = "TUE";
    cell4 = row.insertCell(3);
    cell4.innerHTML = "WED";
    cell5 = row.insertCell(4);
    cell5.innerHTML = "THU";
    cell6 = row.insertCell(5);
    cell6.innerHTML = "FRI";
    cell7 = row.insertCell(6);
    cell7.innerHTML = "SAT";

    j = 0;
    for (i = 0; i <= 41; i++) {
        if ((i % 7) == 0) {
            rowCount = table.rows.length;
            row = table.insertRow(rowCount);
            j = 0;
            //document.write("</tr><tr>");
        } // if week is over then start a new line
        if ((i >= first_day) && (dy <= last_date)) {
            cell = row.insertCell(j); 
            cell.innerHTML = dy;
            cd = new Date();
            d = cd.getDate();
            if (dy == d) {
                cell.className = "today";
            }
            j++;
            //document.write("<td>" + dy + "</td>");
            dy = dy + 1;

        } else {
            cell = row.insertCell(j); 
            cell.innerHTML = "*";
            cell.className = "aesterik";
            j++;
            //document.write("<td>*</td>");
        } // Blank dates.
    } // end of for loop
    
    //document.write("</tr></table>")
}

