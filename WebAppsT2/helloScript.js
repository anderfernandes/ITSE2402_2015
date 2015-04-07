function sayHello() {
    var nameText = document.getElementById("nameTextField").value;
    var displayString = "Hello, " + nameText + "!";
    document.getElementById("nameLabel").innerHTML = displayString;
}