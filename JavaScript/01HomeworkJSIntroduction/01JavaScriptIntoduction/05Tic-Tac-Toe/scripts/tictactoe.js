var cells = document.getElementsByClassName("cell");
var isPlayerOne = true;

for (var i = 0; i < cells.length; i++) {
    cells[i].addEventListener("click", listener, false);
}

function listener() {
    this.style.fontSize = "70px";

    if (this.innerHTML == "") {
        if (isPlayerOne) {
            this.style.color = "red";
            this.innerHTML = "X";

        } else {
            this.innerHTML = "O";
            this.style.color = "blue";
        }

        checkForWinner();
        isPlayerOne = !isPlayerOne;
    }
}

function checkForWinner() {
    checkRows();
    checkColumns();
    checkDiagonals();
}

function checkRows() {
    for (var row = 0; row < 3; row++) {
        var cells = [];

        for (var col = 0; col < 3; col++) {
            var cell = document.getElementById(row+""+col).innerHTML;
            cells[col] = cell;
        }

        if (cells[0] != "" && cells[0] == cells[1] && cells[0] == cells[2]) {
            announceWinner();
            return;
        }
    }
}

function checkColumns() {
    for (var col = 0; col < 3; col++) {
        var cells = [];

        for (var row = 0; row < 3; row++) {
            var cell = document.getElementById(row+""+col).innerHTML;
            cells[row] = cell;
        }

        if (cells[0] != "" && cells[0] == cells[1] && cells[0] == cells[2]) {
            announceWinner();
            return;
        }
    }
}

function checkDiagonals() {
    checkLeftDiagonal();
    checkRightDiagonal();
}

function checkLeftDiagonal() {
    var leftDiagonal = [];
    leftDiagonal[0] = document.getElementById("20").innerHTML;
    leftDiagonal[1] = document.getElementById("11").innerHTML;
    leftDiagonal[2] = document.getElementById("02").innerHTML;

    if (leftDiagonal[0] != "" && leftDiagonal[0] == leftDiagonal[1] && leftDiagonal[0] == leftDiagonal[2]) {
        announceWinner();
        return;
    }
}

function checkRightDiagonal() {
    var rightDiagonal = [];
    rightDiagonal[0] = document.getElementById("00").innerHTML;
    rightDiagonal[1] = document.getElementById("11").innerHTML;
    rightDiagonal[2] = document.getElementById("22").innerHTML;

    if (rightDiagonal[0] != "" && rightDiagonal[0] == rightDiagonal[1] && rightDiagonal[0] == rightDiagonal[2]) {
        announceWinner();
        return;
    }
}

function announceWinner() {
    if (isPlayerOne) {
        alert("Player one wins the game.");
    } else {
        alert("Player two wins the game.");
    }

    exit();
}

function exit() {
    for (var i = 0; i < cells.length; i++) {
        cells[i].removeEventListener("click", listener, false);
    }
}